// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Contains lab configuration and default settings. This variant is used for PATCH. </summary>
    public partial class LabPlanPatch : LabServicesPatchBaseInfo
    {
        /// <summary> Initializes a new instance of <see cref="LabPlanPatch"/>. </summary>
        public LabPlanPatch()
        {
            AllowedRegions = new ChangeTrackingList<AzureLocation>();
        }

        /// <summary> Initializes a new instance of <see cref="LabPlanPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="identity"> Managed Identity Information. Current supported identity types: SystemAssigned. </param>
        /// <param name="defaultConnectionProfile"> The default lab connection profile. This can be changed on a lab resource and only provides a default profile. </param>
        /// <param name="defaultAutoShutdownProfile"> The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile. </param>
        /// <param name="defaultNetworkProfile"> The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there are existing labs associated with this lab plan. </param>
        /// <param name="allowedRegions"> The allowed regions for the lab creator to use when creating labs using this lab plan. </param>
        /// <param name="sharedGalleryId"> Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs. </param>
        /// <param name="supportInfo"> Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and virtual machine users for all labs in the lab plan. </param>
        /// <param name="linkedLmsInstance"> Base Url of the lms instance this lab plan can link lab rosters against. </param>
        internal LabPlanPatch(IList<string> tags, ManagedServiceIdentity identity, LabConnectionProfile defaultConnectionProfile, LabAutoShutdownProfile defaultAutoShutdownProfile, LabPlanNetworkProfile defaultNetworkProfile, IList<AzureLocation> allowedRegions, ResourceIdentifier sharedGalleryId, LabPlanSupportInfo supportInfo, Uri linkedLmsInstance) : base(tags)
        {
            Identity = identity;
            DefaultConnectionProfile = defaultConnectionProfile;
            DefaultAutoShutdownProfile = defaultAutoShutdownProfile;
            DefaultNetworkProfile = defaultNetworkProfile;
            AllowedRegions = allowedRegions;
            SharedGalleryId = sharedGalleryId;
            SupportInfo = supportInfo;
            LinkedLmsInstance = linkedLmsInstance;
        }

        /// <summary> Managed Identity Information. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The default lab connection profile. This can be changed on a lab resource and only provides a default profile. </summary>
        public LabConnectionProfile DefaultConnectionProfile { get; set; }
        /// <summary> The default lab shutdown profile. This can be changed on a lab resource and only provides a default profile. </summary>
        public LabAutoShutdownProfile DefaultAutoShutdownProfile { get; set; }
        /// <summary> The lab plan network profile. To enforce lab network policies they must be defined here and cannot be changed when there are existing labs associated with this lab plan. </summary>
        internal LabPlanNetworkProfile DefaultNetworkProfile { get; set; }
        /// <summary> The external subnet resource id. </summary>
        public ResourceIdentifier DefaultNetworkSubnetId
        {
            get => DefaultNetworkProfile is null ? default : DefaultNetworkProfile.SubnetId;
            set
            {
                if (DefaultNetworkProfile is null)
                    DefaultNetworkProfile = new LabPlanNetworkProfile();
                DefaultNetworkProfile.SubnetId = value;
            }
        }

        /// <summary> The allowed regions for the lab creator to use when creating labs using this lab plan. </summary>
        public IList<AzureLocation> AllowedRegions { get; }
        /// <summary> Resource ID of the Shared Image Gallery attached to this lab plan. When saving a lab template virtual machine image it will be persisted in this gallery. Shared images from the gallery can be made available to use when creating new labs. </summary>
        public ResourceIdentifier SharedGalleryId { get; set; }
        /// <summary> Support contact information and instructions for users of the lab plan. This information is displayed to lab owners and virtual machine users for all labs in the lab plan. </summary>
        public LabPlanSupportInfo SupportInfo { get; set; }
        /// <summary> Base Url of the lms instance this lab plan can link lab rosters against. </summary>
        public Uri LinkedLmsInstance { get; set; }
    }
}
