// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Collection of appliance details. </summary>
    internal partial class SiteRecoveryApplianceListResult
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplianceListResult"/>. </summary>
        internal SiteRecoveryApplianceListResult()
        {
            Value = new ChangeTrackingList<SiteRecoveryReplicationAppliance>();
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryApplianceListResult"/>. </summary>
        /// <param name="value"> The appliance details. </param>
        /// <param name="nextLink"> The value of next link. </param>
        internal SiteRecoveryApplianceListResult(IReadOnlyList<SiteRecoveryReplicationAppliance> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The appliance details. </summary>
        public IReadOnlyList<SiteRecoveryReplicationAppliance> Value { get; }
        /// <summary> The value of next link. </summary>
        public string NextLink { get; }
    }
}
