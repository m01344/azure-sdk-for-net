// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The private IP addresses/IP ranges to which traffic will not be SNAT. </summary>
    internal partial class FirewallPolicySnat
    {
        /// <summary> Initializes a new instance of FirewallPolicySnat. </summary>
        public FirewallPolicySnat()
        {
            PrivateRanges = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of FirewallPolicySnat. </summary>
        /// <param name="privateRanges"> List of private IP addresses/IP address ranges to not be SNAT. </param>
        internal FirewallPolicySnat(IList<string> privateRanges)
        {
            PrivateRanges = privateRanges;
        }

        /// <summary> List of private IP addresses/IP address ranges to not be SNAT. </summary>
        public IList<string> PrivateRanges { get; }
    }
}
