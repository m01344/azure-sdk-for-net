// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Instructions for labeling job. </summary>
    internal partial class LabelingJobInstructions
    {
        /// <summary> Initializes a new instance of <see cref="LabelingJobInstructions"/>. </summary>
        public LabelingJobInstructions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LabelingJobInstructions"/>. </summary>
        /// <param name="uri"> The link to a page with detailed labeling instructions for labelers. </param>
        internal LabelingJobInstructions(Uri uri)
        {
            Uri = uri;
        }

        /// <summary> The link to a page with detailed labeling instructions for labelers. </summary>
        public Uri Uri { get; set; }
    }
}
