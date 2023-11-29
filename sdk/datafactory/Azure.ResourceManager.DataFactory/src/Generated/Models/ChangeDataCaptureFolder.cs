// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The folder that this CDC is in. If not specified, CDC will appear at the root level. </summary>
    internal partial class ChangeDataCaptureFolder
    {
        /// <summary> Initializes a new instance of <see cref="ChangeDataCaptureFolder"/>. </summary>
        public ChangeDataCaptureFolder()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChangeDataCaptureFolder"/>. </summary>
        /// <param name="name"> The name of the folder that this CDC is in. </param>
        internal ChangeDataCaptureFolder(string name)
        {
            Name = name;
        }

        /// <summary> The name of the folder that this CDC is in. </summary>
        public string Name { get; set; }
    }
}
