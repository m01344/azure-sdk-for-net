// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> The vm resource properties that is currently being monitored by the Elastic monitor resource. </summary>
    public partial class VmResources
    {
        /// <summary> Initializes a new instance of <see cref="VmResources"/>. </summary>
        internal VmResources()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VmResources"/>. </summary>
        /// <param name="vmResourceId"> The ARM id of the VM resource. </param>
        internal VmResources(string vmResourceId)
        {
            VmResourceId = vmResourceId;
        }

        /// <summary> The ARM id of the VM resource. </summary>
        public string VmResourceId { get; }
    }
}
