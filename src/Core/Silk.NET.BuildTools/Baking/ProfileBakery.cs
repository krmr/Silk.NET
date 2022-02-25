// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common;
using Silk.NET.BuildTools.Common.Enums;
using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Overloading;
using Enum = Silk.NET.BuildTools.Common.Enums.Enum;

namespace Silk.NET.BuildTools.Baking
{
    /// <summary>
    /// A collection of methods for baking/fusing APIs together.
    /// </summary>
    public static class ProfileBakery
    {
        /// <summary>
        /// Bakes APIs together given the <see cref="ProfileBakeryInformation" />, and outputs the baked
        /// profile to the given folder.
        /// </summary>
        public static Profile Bake(string name, IReadOnlyList<Profile> impl, in BindTask task)
        {
            // create the profile
            var profile = new Profile
            {
                Name = name
            };
            profile.Projects.Add
            (
                "Core",
                new Project
                {
                    Namespace = string.Empty, IsRoot = true,
                    Classes = new List<Class>{}
                }
            );

            // bake in the implemented interfaces, enums, and extension projects
            var extProjects = impl.SelectMany(x => x.Projects.Where(y => y.Key != "Core"));
            var coreProjects = impl.Select(x => x.Projects["Core"]).ToList();
            var coreFunc = coreProjects.SelectMany(x => x.Classes);
            var coreEnums = coreProjects.SelectMany(x => x.Enums);
            var coreStructs = coreProjects.SelectMany(x => x.Structs);
            Console.WriteLine("Profile Bakery: Gathering all the ingredients...");
            profile.Projects["Core"].Classes = profile.Projects["Core"].Classes.Concat(coreFunc).ToList();
            profile.Projects["Core"].Enums.AddRange(coreEnums);
            profile.Projects["Core"].Structs.AddRange(coreStructs);
            profile.Projects = FuseProjects(profile.Projects.Concat(extProjects));

            Console.WriteLine("Profile Bakery: Stirring them until they form a nice paste...");
            MergeAll(profile); // note: the key of the Interfaces dictionary is changed here, so don't rely on it herein
            Console.WriteLine("Profile Bakery: Adding a bit of flavouring...");
            Vary(profile, task.OverloaderExclusions);
            Console.WriteLine("Profile Bakery: Putting it in the oven until it turns a nice golden colour...");
            CheckForDuplicates(profile);
            TypeMapper.MapEnums(profile); // we need to map the enums to make sure they are correct for their extension.
            Console.WriteLine($"Created profile \"{name}\".");
            return profile;
        }

        private static Dictionary<string, Project> FuseProjects(IEnumerable<KeyValuePair<string, Project>> projects)
        {
            var ret = new Dictionary<string, Project>();
            foreach (var project in projects)
            {
                if (ret.TryGetValue(project.Key, out var val) &&
                    val.IsRoot == project.Value.IsRoot &&
                    val.Namespace == project.Value.Namespace)
                {
                    val.Classes.AddRange(project.Value.Classes);
                    val.Enums.AddRange(project.Value.Enums);
                    val.Structs.AddRange(project.Value.Structs);
                }
                else
                {
                    ret[project.Key] = project.Value;
                }
            }

            return ret;
        }

        private static void Vary(Profile profile, Dictionary<string,string[]>? overloaderExclusions)
        {
            foreach (var project in profile.Projects.Values)
            {
                foreach (var @class in project.Classes)
                {
                    foreach (var @interface in @class.NativeApis.Values)
                    {
                        @interface.Functions = Overloader.GetWithVariants
                                (@interface.Functions, profile.Projects["Core"], overloaderExclusions)
                            .ToList();
                    }
                }
            }
        }

        private static void MergeAll(Profile profile) // this method could also be called Stir ;)
        {
            foreach (var project in profile.Projects.Values)
            {
                var enums = new Dictionary<string, Enum>();
                var structs = new Dictionary<string, Struct>();
                var classes = new Dictionary<string, Class>();
                foreach (var enumeration in project.Enums)
                {
                    if (enums.ContainsKey(enumeration.Name))
                    {
                        enums[enumeration.Name].Tokens.AddRange(enumeration.Tokens);
                    }
                    else
                    {
                        enums.Add(enumeration.Name, enumeration);
                    }
                }

                foreach (var @class in project.Classes)
                {
                    if (classes.ContainsKey(@class.ClassName))
                    {
                        var interfaces = new Dictionary<string, NativeApiSet>();
                        foreach (var (key, @interface) in @class.NativeApis.Concat(classes[@class.ClassName].NativeApis))
                        {
                            if (interfaces.ContainsKey(key))
                            {
                                foreach (var function in @interface.Functions)
                                {
                                    if (interfaces[key].Functions.Any(x => x.Equals(function)))
                                    {
                                        continue;
                                    }

                                    interfaces[key].Functions.Add(function);
                                }
                            }
                            else
                            {
                                interfaces.Add(key, @interface);
                            }
                        }

                        classes[@class.ClassName].NativeApis = interfaces;
                        classes[@class.ClassName].Functions.AddRange(@class.Functions);

                        var constants = new Dictionary<string, Constant>();
                        foreach (var constant in @class.Constants.Concat(classes[@class.ClassName].Constants))
                        {
                            if (constants.ContainsKey(constant.Name))
                            {
                                if (constants[constant.Name].NativeName != constant.NativeName || constants[constant.Name].Value != constant.Value)
                                {
                                    Console.WriteLine($"Warning: Discarding duplicate constant {constant.Name}.");
                                    Console.WriteLine($"    Original: {constants[constant.Name].NativeName} = {constants[constant.Name].Value}");
                                    Console.WriteLine($"    Duplicate: {constant.NativeName} = {constant.Value}");
                                }
                            }
                            else
                            {
                                constants.Add(constant.Name, constant);
                            }
                        }
                    }
                    else
                    {
                        classes[@class.ClassName] = new Class
                        {
                            ClassName = @class.ClassName,
                            NativeApis = @class.NativeApis.ToDictionary(),
                            Constants = @class.Constants.ToList(),
                            Functions = @class.Functions.ToList()
                        };
                    }
                }

                foreach (var @struct in project.Structs)
                {
                    if (structs.ContainsKey(@struct.Name))
                    {
                        if (structs[@struct.Name].NativeName != @struct.NativeName)
                        {
                            Console.WriteLine
                            (
                                $"Warning: Discarding duplicate struct \"{@struct.Name}\" (Original was \"{@struct.NativeName}\", {structs[@struct.Name].NativeName} currently present)"
                            );
                        }
                    }
                    else
                    {
                        structs.Add(@struct.Name, @struct);
                    }
                }

                project.Enums = enums.Values.ToList();
                project.Classes = classes.Values.ToList();
                project.Structs = structs.Values.ToList();
            }
        }

        private static void CheckForDuplicates(Profile profile)
        {
            foreach (var project in (IDictionary<string, Project>)profile.Projects)
            {
                foreach (var @class in project.Value.Classes)
                {
                    foreach (var @interface in @class.NativeApis)
                    {
                        var functions = new List<Function>();
                        foreach (var f in @interface.Value.Functions)
                        {
                            if (functions.Any(x => x.Equals(f))) continue;
                            functions.Add(f);
                        }

                        @interface.Value.Functions = functions;
                    }

                    foreach (var @enum in project.Value.Enums)
                    {
                        var tokens = new List<Token>();
                        foreach (var token in @enum.Tokens)
                        {
                            var existingToken = tokens.FirstOrDefault(x => x.Name == token.Name);
                            if (!(existingToken is null))
                            {
                                if (existingToken.Value != token.Value)
                                {
                                    Console.WriteLine("Warning: Two tokens with the same name but different values.");
                                    Console.WriteLine($"    {existingToken.Name} = {existingToken.Value}");
                                    Console.WriteLine($"    {token.Name} = {token.Value}");
                                    Console.WriteLine($"{existingToken.Value} will be used.");
                                }

                                continue;
                            }

                            tokens.Add(token);
                        }

                        @enum.Tokens = tokens;
                    }
                }
            }
        }
    }
}
