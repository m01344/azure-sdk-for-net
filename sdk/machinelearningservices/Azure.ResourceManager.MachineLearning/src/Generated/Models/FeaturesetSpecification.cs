// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Dto object representing specification. </summary>
    internal partial class FeaturesetSpecification
    {
        /// <summary> Initializes a new instance of <see cref="FeaturesetSpecification"/>. </summary>
        public FeaturesetSpecification()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FeaturesetSpecification"/>. </summary>
        /// <param name="path"> Specifies the spec path. </param>
        internal FeaturesetSpecification(string path)
        {
            Path = path;
        }

        /// <summary> Specifies the spec path. </summary>
        public string Path { get; set; }
    }
}
