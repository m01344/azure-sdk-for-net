// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The properties of an Azure Cosmos DB PhysicalPartitionThroughputInfoProperties object. </summary>
    internal partial class PhysicalPartitionThroughputInfoProperties
    {
        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoProperties"/>. </summary>
        public PhysicalPartitionThroughputInfoProperties()
        {
            PhysicalPartitionThroughputInfo = new ChangeTrackingList<PhysicalPartitionThroughputInfoResource>();
        }

        /// <summary> Initializes a new instance of <see cref="PhysicalPartitionThroughputInfoProperties"/>. </summary>
        /// <param name="physicalPartitionThroughputInfo"> Array of physical partition throughput info objects. </param>
        internal PhysicalPartitionThroughputInfoProperties(IList<PhysicalPartitionThroughputInfoResource> physicalPartitionThroughputInfo)
        {
            PhysicalPartitionThroughputInfo = physicalPartitionThroughputInfo;
        }

        /// <summary> Array of physical partition throughput info objects. </summary>
        public IList<PhysicalPartitionThroughputInfoResource> PhysicalPartitionThroughputInfo { get; }
    }
}
