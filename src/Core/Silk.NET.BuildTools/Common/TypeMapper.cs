// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using MoreLinq.Extensions;
using Silk.NET.BuildTools.Common.Functions;
using Type = Silk.NET.BuildTools.Common.Functions.Type;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A collection of methods for replacing type names using a dictionary.
    /// </summary>
    public static class TypeMapper
    {
        /// <summary>
        /// Replaces the type names of parameters and return types in the given functions using the given typemap.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="functions">The functions to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Function> functions)
        {
            foreach (var function in functions)
            {
                Map(map, function);
            }
        }

        /// <summary>
        /// Retrieve a type from a typemap.
        /// </summary>
        /// <param name="maps">The map to use.</param>
        /// <param name="og">The type to map.</param>
        /// <returns>The mapped type.</returns>
        public static Type MapOne(IEnumerable<Dictionary<string, string>> maps, Type og)
        {
            var type = og;
            foreach (var map in maps)
            {
                type = MapOne(map, type);
            }

            return type;
        }

        /// <summary>
        /// Retrieve a type from a typemap.
        /// </summary>
        /// <param name="map">The map to use.</param>
        /// <param name="og">The type to map.</param>
        /// <returns>The mapped type.</returns>
        public static Type MapOne(Dictionary<string, string> map, Type og)
        {
            var type = og;
            if (map.ContainsKey(type.ToString()))
            {
                type = ParseTypeSignature
                (
                    map[type.ToString()], type.OriginalName, type.OriginalGroup
                );
            }
            else if (map.ContainsKey(type.Name))
            {
                type.Name = map[type.Name];
            }

            if (og.FunctionPointerSignature is not null)
            {
                type.FunctionPointerSignature = og.FunctionPointerSignature;
                Map(map, type.FunctionPointerSignature);
            }

            return type;
        }

        /// <summary>
        /// Replaces the type names of parameters and return types in the given functions using the given typemap.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="structs">The functions to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Struct> structs)
        {
            foreach (var @struct in structs)
            {
                foreach (var field in @struct.Fields)
                {
                    field.Type = MapOne(map, field.Type);
                }

                for (var i = 0; i < @struct.ComBases.Count; i++)
                {
                    if (map.TryGetValue(@struct.ComBases[i], out var val))
                    {
                        @struct.ComBases[i] = val;
                    }
                }

                foreach (var function in @struct.Vtbl)
                {
                    Map(map, function);
                }

                foreach (var function in @struct.Functions)
                {
                    Map(map, function.Signature);
                }
            }
        }

        /// <summary>
        /// Replaces the type names in the given constants.
        /// </summary>
        /// <param name="map">The typemap/dictionary to use.</param>
        /// <param name="constants">The constants to map.</param>
        public static void Map(Dictionary<string, string> map, IEnumerable<Constant> constants)
        {
            foreach (var constant in constants)
            {
                constant.Type = MapOne(map, constant.Type);
            }
        }

        public static void Map(Dictionary<string, string> map, Function function)
        {
            function.ReturnType = MapOne(map, function.ReturnType);

            foreach (var parameter in function.Parameters)
            {
                parameter.Type = MapOne(map, parameter.Type);
            }
        }

        /// <summary>
        /// Replaces the type names of GLenum parameters with their associated enums.
        /// </summary>
        /// <param name="profile">The profile to map.</param>
        public static void MapEnums(Profile profile)
        {
            foreach (var project in profile.Projects.Values)
            {
                foreach (var @interface in project.Classes.SelectMany(x => x.NativeApis.Values))
                {
                    foreach (var function in @interface.Functions)
                    {
                        foreach (var parameter in function.Parameters)
                        {
                            if (parameter.Type.OriginalName == "GLenum" || parameter.Type.Name == "CLenum" ||
                                parameter.Type.Name == "EGLenum")
                            {
                                parameter.Type.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                            }

                            foreach (var genericType in parameter.Type.GenericTypes)
                            {
                                if (genericType.OriginalName == "GLenum" || genericType.Name == "CLenum")
                                {
                                    genericType.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                                }
                            }
                        }

                        if (function.ReturnType.OriginalName == "GLenum" || function.ReturnType.Name == "CLenum" ||
                            function.ReturnType.Name == "EGLenum")
                        {
                            function.ReturnType.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                        }

                        foreach (var genericType in function.ReturnType.GenericTypes)
                        {
                            if (genericType.OriginalName == "GLenum" || genericType.Name == "CLenum")
                            {
                                genericType.Name = project.Enums.First(x => x.NativeName == "GLenum").Name;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Creates a typemap mapping the native name of structs and enums alike to their new name.
        /// </summary>
        /// <returns>A map mapping those two things I just said.</returns>
        public static Dictionary<string, string> CreateVariedNameMap(Project project)
            => project.Structs.DistinctBy(x => x.NativeName)
                .ToDictionary(x => x.NativeName, x => x.Name)
                .Concat(project.Enums.ToDictionary(x => x.NativeName, x => x.Name))
                .ToDictionary();

        private static Type ParseTypeSignature(string type, string original = null, string group = null)
        {
            if (type.Contains('*') && (type.Contains('[') || type.Contains(']')))
            {
                throw new InvalidDataException("A type cannot be both a pointer and an array at the same time.");
            }

            const string constValueSpecifier = "const ";
            const string constPointerSpecifier = " const";
            const string structSpecifier = "struct ";

            // We'll ignore struct and const specifiers for the moment
            var isConstValue = type.StartsWith(constValueSpecifier);
            if (isConstValue)
            {
                type = type.Remove(0, constValueSpecifier.Length);
            }

            var isConstPointer = type.EndsWith(constPointerSpecifier);
            if (isConstPointer)
            {
                var specifierIndex = type.LastIndexOf(constPointerSpecifier, StringComparison.Ordinal);
                type = type.Remove(specifierIndex);
            }

            var isStruct = type.StartsWith(structSpecifier);
            if (isStruct)
            {
                type = type.Remove(0, structSpecifier.Length);
            }

            var typeName = new string(type.ToCharArray().Where(c => !char.IsWhiteSpace(c)).ToArray());

            var pointerLevel = 0;
            var isPointer = type.EndsWith("*");
            if (isPointer)
            {
                var firstPointerLevelIndex = typeName.IndexOf('*');
                var lastPointerLevelIndex = typeName.LastIndexOf('*');

                pointerLevel = Math.Abs(lastPointerLevelIndex - firstPointerLevelIndex) + 1;

                typeName = typeName.Remove(firstPointerLevelIndex);
            }

            var arrayLevel = 0;
            var isArray = typeName.EndsWith("]");
            if (isArray)
            {
                var firstArrayIndex = typeName.IndexOf('[');
                var lastArrayIndex = typeName.IndexOf(']');

                arrayLevel = Math.Abs(firstArrayIndex - lastArrayIndex);

                typeName = typeName.Remove(firstArrayIndex);
            }

            return new Type
            {
                Name = typeName,
                OriginalName = original ?? typeName,
                OriginalGroup = group,
                IndirectionLevels = pointerLevel,
                ArrayDimensions = arrayLevel
            };
        }
    }
}
