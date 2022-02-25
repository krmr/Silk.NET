﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using ClangSharp.Interop;

using Silk.NET.BuildTools.Common.Functions;
using Silk.NET.BuildTools.Common.Structs;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// Various utilities for use by the tool.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Gets a list of keywords in the C# language.
        /// </summary>
        public static readonly HashSet<string> CSharpKeywords = new HashSet<string>
        {
            "abstract",
            "event",
            "new",
            "struct",
            "as",
            "explicit",
            "null",
            "switch",
            "base",
            "extern",
            "object",
            "this",
            "bool",
            "false",
            "operator",
            "throw",
            "break",
            "finally",
            "out",
            "true",
            "byte",
            "fixed",
            "override",
            "try",
            "case",
            "float",
            "params",
            "typeof",
            "catch",
            "for",
            "private",
            "uint",
            "char",
            "foreach",
            "protected",
            "ulong",
            "checked",
            "goto",
            "public",
            "unchecked",
            "class",
            "if",
            "readonly",
            "unsafe",
            "const",
            "implicit",
            "ref",
            "ushort",
            "continue",
            "in",
            "return",
            "using",
            "decimal",
            "int",
            "sbyte",
            "virtual",
            "default",
            "interface",
            "sealed",
            "volatile",
            "delegate",
            "internal",
            "short",
            "void",
            "do",
            "is",
            "sizeof",
            "while",
            "double",
            "lock",
            "stackalloc",
            "else",
            "long",
            "static",
            "enum",
            "namespace",
            "string"
        };

        /// <summary>
        /// An extension method which returns the given enumerable without duplicate elements.
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicates<T>(this IEnumerable<T> enumerable)
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            foreach (var item in enumerable)
            {
                if (!ret.Any(x => x.Equals(item)))
                {
                    ret.Add(item);
                }
            }

            return ret;
        }

        /// <summary>
        /// An extension method which returns the given enumerable without duplicate elements.
        /// </summary>
        /// <param name="enumerable">The enumerable to process.</param>
        /// <param name="isDuplicate">A function that checks whether or not items are duplicates.</param>
        /// <typeparam name="T">The type contained within this enumerable.</typeparam>
        /// <returns>An enumerable with no duplicates.</returns>
        public static IEnumerable<T> RemoveDuplicates<T>(this IEnumerable<T> enumerable, Func<T, T, bool> isDuplicate)
        {
            // note: this is required because ApiProfile.GetCategories() returns duplicates.
            var ret = new List<T>();
            foreach (var item in enumerable)
            {
                if (!ret.Any(x => isDuplicate(x, item)))
                {
                    ret.Add(item);
                }
            }

            return ret;
        }

        /// <summary>
        /// Gets an array declaration string that matches the given level of array dimensions.
        /// </summary>
        /// <param name="arrayDimensions">The dimension.</param>
        /// <returns>The string.</returns>
        public static string GetArrayDimensionString(int arrayDimensions)
        {
            if (arrayDimensions == 0)
            {
                return string.Empty;
            }

            var builder = new StringBuilder();
            builder.Append('[');
            builder.Append(new string(',', arrayDimensions - 1));
            builder.Append(']');

            return builder.ToString();
        }

        /// <summary>
        /// Checks if member names are valid for C#.
        /// </summary>
        /// <param name="name">The name to check.</param>
        /// <param name="fPrefix">The prefix to append if the name fails the check.</param>
        /// <returns>The string after being validated.</returns>
        public static string CheckMemberName(this string name, string fPrefix)
        {
            name = name.Replace("_", null).Replace(" ", null);
            // ReSharper disable StringLiteralTypo
            if (!"ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().Contains(name[0]))
            // ReSharper restore StringLiteralTypo
            {
                return fPrefix.ToUpper() + name;
            }

            return name;
        }

        public static Field WithFixedFieldFixup09072020(this Field field)
        {
            if (field.Count is null)
            {
                return field;
            }
            
            if (field.Count.IsStatic)
            {
                field.Type.IndirectionLevels++;
            }
            
            return field;
        }

        public static sbyte? ParseSbyte(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return sbyte.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!sbyte.TryParse(chars, out var ret))
            {
                if (sbyte.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex sbyte \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a sbyte. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static byte? ParseByte(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return byte.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!byte.TryParse(chars, out var ret))
            {
                if (byte.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex byte \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a byte. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static short? ParseShort(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return short.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!short.TryParse(chars, out var ret))
            {
                if (short.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex short \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a short. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static ushort? ParseUshort(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return ushort.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!ushort.TryParse(chars, out var ret))
            {
                if (ushort.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex ushort \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a ushort. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static int? ParseInt(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return int.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!int.TryParse(chars, out var ret))
            {
                if (int.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex int \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a int. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static uint? ParseUint(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return uint.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!uint.TryParse(chars, out var ret))
            {
                if (uint.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex uint \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a uint. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static long? ParseLong(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return long.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!long.TryParse(chars, out var ret))
            {
                if (long.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex long \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a long. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }
        public static ulong? ParseUlong(ReadOnlySpan<char> chars)
        {
            if (chars.StartsWith("0x"))
            {
                return ulong.TryParse(chars.Slice(2), NumberStyles.HexNumber, null, out var hex) ? hex : null;
            }
            
            if (!ulong.TryParse(chars, out var ret))
            {
                if (ulong.TryParse(chars, NumberStyles.HexNumber, null, out ret))
                {
                    Console.WriteLine($"Warning: Implicitly treating \"{chars.ToString()}\" as hex ulong \"{ret}\"");
                }
                else
                {
                    Console.WriteLine($"Warning: Couldn't parse \"{chars.ToString()}\" as a ulong. Returning null.");
                    return null;
                }
            }
            
            return ret;
        }

        public static bool IsBuildToolsIntrinsic(this IEnumerable<Attribute> attributes, out List<string> args)
        {
            var ret = attributes.FirstOrDefault(x => x.Name == "BuildToolsIntrinsic");
            if (ret is null)
            {
                args = null;
                return false;
            }

            args = ret.Arguments;
            return true;
        }

        public static IEnumerable<T> Concat<T>(this IEnumerable<T> enumerable, T singleItem)
        {
            foreach (var item in enumerable)
            {
                yield return item;
            }

            yield return singleItem;
        }

        public static Accessibility MapAccessibility(this CX_CXXAccessSpecifier access) => access switch
        {
            CX_CXXAccessSpecifier.CX_CXXInvalidAccessSpecifier => Accessibility.Public,
            CX_CXXAccessSpecifier.CX_CXXPublic => Accessibility.Public,
            CX_CXXAccessSpecifier.CX_CXXProtected => Accessibility.Public,
            CX_CXXAccessSpecifier.CX_CXXPrivate => Accessibility.Private,
            _ => Accessibility.Internal
        };

        public static string MapAccessibility(this Accessibility access, bool s = false) => access switch
        {
            Accessibility.Public => "public" + (s ? " " : string.Empty),
            Accessibility.Protected => "protected" + (s ? " " : string.Empty),
            Accessibility.Internal => "internal" + (s ? " " : string.Empty),
            Accessibility.Private => "private" + (s ? " " : string.Empty),
            _ => string.Empty
        };

        public static bool ConstitutesVulkanOutOverload(this string name) => name.StartsWith
            ("vkCreate") || name.StartsWith("vkAllocate") || name.StartsWith
            ("vkGet");

        public static string MapNativeString(this Functions.Type type) => type.OriginalName?.ToUpper() switch
        {
            "BSTR" => "NativeStringEncoding.BStr",
            "LPSTR" or "LPCSTR" => "NativeStringEncoding.LPStr",
            "LPTSTR" or "LPCTSTR" => "NativeStringEncoding.LPTStr",
            "LPUTF8STR" => "NativeStringEncoding.LPUTF8Str",
            "LPWSTR" or "LPCWSTR" => "NativeStringEncoding.LPWStr",
            _ => "NativeStringEncoding.UTF8"
        };

        public static string MapUnmanagedType(this Functions.Type type) => type.OriginalName?.ToUpper() switch
        {
            "BSTR" => "Silk.NET.Core.Native.UnmanagedType.BStr",
            "LPSTR" or "LPCSTR" => "Silk.NET.Core.Native.UnmanagedType.LPStr",
            "LPTSTR" or "LPCTSTR" => "Silk.NET.Core.Native.UnmanagedType.LPTStr",
            "LPUTF8STR" => "Silk.NET.Core.Native.UnmanagedType.LPUTF8Str",
            "LPWSTR" or "LPCWSTR" => "Silk.NET.Core.Native.UnmanagedType.LPWStr",
            _ => "Silk.NET.Core.Native.UnmanagedType.LPUTF8Str"
        };
    }
}
