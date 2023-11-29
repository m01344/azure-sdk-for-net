// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EnergyServices;

namespace Azure.ResourceManager.EnergyServices.Models
{
    /// <summary> The list of oep resources. </summary>
    internal partial class EnergyServiceList
    {
        /// <summary> Initializes a new instance of <see cref="EnergyServiceList"/>. </summary>
        internal EnergyServiceList()
        {
            Value = new ChangeTrackingList<EnergyServiceData>();
        }

        /// <summary> Initializes a new instance of <see cref="EnergyServiceList"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of oep resources list. </param>
        /// <param name="value"> The list of oep resources. </param>
        internal EnergyServiceList(string nextLink, IReadOnlyList<EnergyServiceData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of oep resources list. </summary>
        public string NextLink { get; }
        /// <summary> The list of oep resources. </summary>
        public IReadOnlyList<EnergyServiceData> Value { get; }
    }
}
