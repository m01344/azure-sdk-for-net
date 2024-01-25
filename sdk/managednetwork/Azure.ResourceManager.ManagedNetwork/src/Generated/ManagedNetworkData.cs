// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.ManagedNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetwork
{
    /// <summary>
    /// A class representing the ManagedNetwork data model.
    /// The Managed Network resource
    /// </summary>
    public partial class ManagedNetworkData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ManagedNetworkData"/>. </summary>
        /// <param name="location"> The location. </param>
        public ManagedNetworkData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the ManagedNetwork resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="scope"> The collection of management groups, subscriptions, virtual networks, and subnets by the Managed Network. This is a read-only property that is reflective of all ScopeAssignments for this Managed Network. </param>
        /// <param name="connectivity"> The collection of groups and policies concerned with connectivity. </param>
        internal ManagedNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, ETag? etag, Scope scope, ConnectivityCollection connectivity) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            ETag = etag;
            Scope = scope;
            Connectivity = connectivity;
        }

        /// <summary> Provisioning state of the ManagedNetwork resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The collection of management groups, subscriptions, virtual networks, and subnets by the Managed Network. This is a read-only property that is reflective of all ScopeAssignments for this Managed Network. </summary>
        public Scope Scope { get; set; }
        /// <summary> The collection of groups and policies concerned with connectivity. </summary>
        public ConnectivityCollection Connectivity { get; }
    }
}
