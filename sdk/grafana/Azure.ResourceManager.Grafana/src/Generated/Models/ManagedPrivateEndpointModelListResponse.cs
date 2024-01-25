// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Models
{
    /// <summary> The list of managed private endpoints of a grafana resource. </summary>
    internal partial class ManagedPrivateEndpointModelListResponse
    {
        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointModelListResponse"/>. </summary>
        internal ManagedPrivateEndpointModelListResponse()
        {
            Value = new ChangeTrackingList<ManagedPrivateEndpointModelData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedPrivateEndpointModelListResponse"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal ManagedPrivateEndpointModelListResponse(IReadOnlyList<ManagedPrivateEndpointModelData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ManagedPrivateEndpointModelData> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
