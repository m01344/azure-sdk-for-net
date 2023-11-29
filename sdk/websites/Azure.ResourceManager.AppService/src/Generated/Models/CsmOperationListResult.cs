// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Collection of Azure resource manager operation metadata. </summary>
    internal partial class CsmOperationListResult
    {
        /// <summary> Initializes a new instance of <see cref="CsmOperationListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal CsmOperationListResult(IEnumerable<CsmOperationDescription> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CsmOperationListResult"/>. </summary>
        /// <param name="value"> Collection of resources. </param>
        /// <param name="nextLink"> Link to next page of resources. </param>
        internal CsmOperationListResult(IReadOnlyList<CsmOperationDescription> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resources. </summary>
        public IReadOnlyList<CsmOperationDescription> Value { get; }
        /// <summary> Link to next page of resources. </summary>
        public string NextLink { get; }
    }
}
