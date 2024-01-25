// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The QuerySerialization. </summary>
    internal partial class QuerySerialization
    {
        /// <summary> Initializes a new instance of <see cref="QuerySerialization"/>. </summary>
        /// <param name="format"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="format"/> is null. </exception>
        public QuerySerialization(QueryFormat format)
        {
            Argument.AssertNotNull(format, nameof(format));

            Format = format;
        }

        /// <summary> Gets the format. </summary>
        public QueryFormat Format { get; }
    }
}
