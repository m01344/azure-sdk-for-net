// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> Parameters for updating an Azure Dev Spaces Controller. </summary>
    public partial class ControllerPatch
    {
        /// <summary> Initializes a new instance of <see cref="ControllerPatch"/>. </summary>
        public ControllerPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Tags for the Azure Dev Spaces Controller. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Credentials of the target container host (base64). </summary>
        public string TargetContainerHostCredentialsBase64 { get; set; }
    }
}
