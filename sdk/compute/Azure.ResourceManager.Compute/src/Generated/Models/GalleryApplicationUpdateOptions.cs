// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Specifies information about the gallery Application Definition that you want to update. </summary>
    public partial class GalleryApplicationUpdateOptions : UpdateResourceDefinition
    {
        /// <summary> Initializes a new instance of GalleryApplicationUpdateOptions. </summary>
        public GalleryApplicationUpdateOptions()
        {
        }

        /// <summary> The description of this gallery Application Definition resource. This property is updatable. </summary>
        public string Description { get; set; }
        /// <summary> The Eula agreement for the gallery Application Definition. </summary>
        public string Eula { get; set; }
        /// <summary> The privacy statement uri. </summary>
        public Uri PrivacyStatementUri { get; set; }
        /// <summary> The release note uri. </summary>
        public Uri ReleaseNoteUri { get; set; }
        /// <summary> The end of life date of the gallery Application Definition. This property can be used for decommissioning purposes. This property is updatable. </summary>
        public DateTimeOffset? EndOfLifeDate { get; set; }
        /// <summary> This property allows you to specify the supported type of the OS that application is built for. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt; **Linux**. </summary>
        public OperatingSystemTypes? SupportedOSType { get; set; }
    }
}
