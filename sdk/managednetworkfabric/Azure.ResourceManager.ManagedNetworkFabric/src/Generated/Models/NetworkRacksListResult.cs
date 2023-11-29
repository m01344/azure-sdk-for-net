// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> List of Network Racks. </summary>
    internal partial class NetworkRacksListResult
    {
        /// <summary> Initializes a new instance of <see cref="NetworkRacksListResult"/>. </summary>
        internal NetworkRacksListResult()
        {
            Value = new ChangeTrackingList<NetworkRackData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkRacksListResult"/>. </summary>
        /// <param name="value"> List of Network Rack resources. </param>
        /// <param name="nextLink"> Url to follow for getting next page of resources. </param>
        internal NetworkRacksListResult(IReadOnlyList<NetworkRackData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Network Rack resources. </summary>
        public IReadOnlyList<NetworkRackData> Value { get; }
        /// <summary> Url to follow for getting next page of resources. </summary>
        public string NextLink { get; }
    }
}
