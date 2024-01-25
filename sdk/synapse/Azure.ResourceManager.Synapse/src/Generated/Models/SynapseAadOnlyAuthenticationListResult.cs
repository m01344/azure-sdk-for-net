// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of active directory only authentications. </summary>
    internal partial class SynapseAadOnlyAuthenticationListResult
    {
        /// <summary> Initializes a new instance of <see cref="SynapseAadOnlyAuthenticationListResult"/>. </summary>
        internal SynapseAadOnlyAuthenticationListResult()
        {
            Value = new ChangeTrackingList<SynapseAadOnlyAuthenticationData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseAadOnlyAuthenticationListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapseAadOnlyAuthenticationListResult(IReadOnlyList<SynapseAadOnlyAuthenticationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseAadOnlyAuthenticationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
