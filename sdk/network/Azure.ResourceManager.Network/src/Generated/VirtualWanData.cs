// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the VirtualWan data model.
    /// VirtualWAN Resource.
    /// </summary>
    public partial class VirtualWanData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="VirtualWanData"/>. </summary>
        public VirtualWanData()
        {
            VirtualHubs = new ChangeTrackingList<WritableSubResource>();
            VpnSites = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualWanData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="disableVpnEncryption"> Vpn encryption to be disabled or not. </param>
        /// <param name="virtualHubs"> List of VirtualHubs in the VirtualWAN. </param>
        /// <param name="vpnSites"> List of VpnSites in the VirtualWAN. </param>
        /// <param name="allowBranchToBranchTraffic"> True if branch to branch traffic is allowed. </param>
        /// <param name="allowVnetToVnetTraffic"> True if Vnet to Vnet traffic is allowed. </param>
        /// <param name="office365LocalBreakoutCategory"> The office local breakout category. </param>
        /// <param name="provisioningState"> The provisioning state of the virtual WAN resource. </param>
        /// <param name="virtualWanType"> The type of the VirtualWAN. </param>
        internal VirtualWanData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, bool? disableVpnEncryption, IReadOnlyList<WritableSubResource> virtualHubs, IReadOnlyList<WritableSubResource> vpnSites, bool? allowBranchToBranchTraffic, bool? allowVnetToVnetTraffic, OfficeTrafficCategory? office365LocalBreakoutCategory, NetworkProvisioningState? provisioningState, string virtualWanType) : base(id, name, resourceType, location, tags)
        {
            ETag = etag;
            DisableVpnEncryption = disableVpnEncryption;
            VirtualHubs = virtualHubs;
            VpnSites = vpnSites;
            AllowBranchToBranchTraffic = allowBranchToBranchTraffic;
            AllowVnetToVnetTraffic = allowVnetToVnetTraffic;
            Office365LocalBreakoutCategory = office365LocalBreakoutCategory;
            ProvisioningState = provisioningState;
            VirtualWanType = virtualWanType;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> Vpn encryption to be disabled or not. </summary>
        public bool? DisableVpnEncryption { get; set; }
        /// <summary> List of VirtualHubs in the VirtualWAN. </summary>
        public IReadOnlyList<WritableSubResource> VirtualHubs { get; }
        /// <summary> List of VpnSites in the VirtualWAN. </summary>
        public IReadOnlyList<WritableSubResource> VpnSites { get; }
        /// <summary> True if branch to branch traffic is allowed. </summary>
        public bool? AllowBranchToBranchTraffic { get; set; }
        /// <summary> True if Vnet to Vnet traffic is allowed. </summary>
        public bool? AllowVnetToVnetTraffic { get; set; }
        /// <summary> The office local breakout category. </summary>
        public OfficeTrafficCategory? Office365LocalBreakoutCategory { get; }
        /// <summary> The provisioning state of the virtual WAN resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The type of the VirtualWAN. </summary>
        public string VirtualWanType { get; set; }
    }
}
