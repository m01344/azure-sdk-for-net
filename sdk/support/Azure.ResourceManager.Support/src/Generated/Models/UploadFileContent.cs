// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> File content associated with the file under a workspace. </summary>
    public partial class UploadFileContent
    {
        /// <summary> Initializes a new instance of <see cref="UploadFileContent"/>. </summary>
        public UploadFileContent()
        {
        }

        /// <summary> File Content in base64 encoded format. </summary>
        public string Content { get; set; }
        /// <summary> Index of the uploaded chunk (Index starts at 0). </summary>
        public float? ChunkIndex { get; set; }
    }
}
