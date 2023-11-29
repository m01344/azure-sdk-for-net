// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Tag filter information for the VM. </summary>
    public partial class VmTagSettings
    {
        /// <summary> Initializes a new instance of <see cref="VmTagSettings"/>. </summary>
        public VmTagSettings()
        {
            Tags = new ChangeTrackingDictionary<string, IList<string>>();
        }

        /// <summary> Initializes a new instance of <see cref="VmTagSettings"/>. </summary>
        /// <param name="tags"> Dictionary of tags with its list of values. </param>
        /// <param name="filterOperator"> Filter VMs by Any or All specified tags. </param>
        internal VmTagSettings(IDictionary<string, IList<string>> tags, VmTagOperator? filterOperator)
        {
            Tags = tags;
            FilterOperator = filterOperator;
        }

        /// <summary> Dictionary of tags with its list of values. </summary>
        public IDictionary<string, IList<string>> Tags { get; }
        /// <summary> Filter VMs by Any or All specified tags. </summary>
        public VmTagOperator? FilterOperator { get; set; }
    }
}
