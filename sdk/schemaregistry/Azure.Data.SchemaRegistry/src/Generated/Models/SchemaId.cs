// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Data.SchemaRegistry.Models
{
    /// <summary> Object received from the registry containing schema identifiers. </summary>
    internal readonly partial struct SchemaId
    {
        /// <summary> Initializes a new instance of <see cref="SchemaId"/>. </summary>
        /// <param name="id"> Schema ID that uniquely identifies a schema in the registry namespace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal SchemaId(string id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Schema ID that uniquely identifies a schema in the registry namespace. </summary>
        public string Id { get; }
    }
}
