// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ControlPlaneNodePatchConfiguration represents the properties of the control plane that can be patched for this Kubernetes cluster. </summary>
    internal partial class ControlPlaneNodePatchConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ControlPlaneNodePatchConfiguration"/>. </summary>
        public ControlPlaneNodePatchConfiguration()
        {
        }

        /// <summary> The number of virtual machines that use this configuration. </summary>
        public long? Count { get; set; }
    }
}
