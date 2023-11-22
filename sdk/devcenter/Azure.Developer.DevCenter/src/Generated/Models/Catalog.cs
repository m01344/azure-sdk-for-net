// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> A catalog. </summary>
    public partial class Catalog
    {
        /// <summary> Initializes a new instance of Catalog. </summary>
        /// <param name="name"> Name of the catalog. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal Catalog(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Name of the catalog. </summary>
        public string Name { get; }
    }
}
