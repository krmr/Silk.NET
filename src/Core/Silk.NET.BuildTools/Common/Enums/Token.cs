// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Silk.NET.BuildTools.Common.Enums
{
    /// <summary>
    /// Represents an enum token.
    /// </summary>
    public class Token : IProfileConstituent
    {
        /// <summary>
        /// Gets or sets the name of this token.
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the name of this token, as defined by the API specification.
        /// </summary>
        public string NativeName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the numeric value of this token.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the formatted XML documentation.
        /// </summary>
        public string Doc { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets a list of attributes to be assigned to this token.
        /// </summary>
        public List<Attribute> Attributes { get; set; } = new List<Attribute>();
    }
}
