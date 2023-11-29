// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> JPEG image encoding. </summary>
    public partial class ImageFormatJpeg : ImageFormatProperties
    {
        /// <summary> Initializes a new instance of <see cref="ImageFormatJpeg"/>. </summary>
        public ImageFormatJpeg()
        {
            Type = "#Microsoft.VideoAnalyzer.ImageFormatJpeg";
        }

        /// <summary> Initializes a new instance of <see cref="ImageFormatJpeg"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="quality"> Image quality value between 0 to 100 (best quality). </param>
        internal ImageFormatJpeg(string type, string quality) : base(type)
        {
            Quality = quality;
            Type = type ?? "#Microsoft.VideoAnalyzer.ImageFormatJpeg";
        }

        /// <summary> Image quality value between 0 to 100 (best quality). </summary>
        public string Quality { get; set; }
    }
}
