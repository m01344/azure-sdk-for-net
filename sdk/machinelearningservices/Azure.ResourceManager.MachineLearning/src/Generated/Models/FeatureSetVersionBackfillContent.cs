// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Request payload for creating a backfill request for a given feature set version. </summary>
    public partial class FeatureSetVersionBackfillContent
    {
        /// <summary> Initializes a new instance of <see cref="FeatureSetVersionBackfillContent"/>. </summary>
        public FeatureSetVersionBackfillContent()
        {
            SparkConfiguration = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Specifies description. </summary>
        public string Description { get; set; }
        /// <summary> Specifies description. </summary>
        public string DisplayName { get; set; }
        /// <summary> Specifies the backfill feature window to be materialized. </summary>
        public FeatureWindow FeatureWindow { get; set; }
        /// <summary> Specifies the compute resource settings. </summary>
        internal MaterializationComputeResource Resource { get; set; }
        /// <summary> Specifies the instance type. </summary>
        public string ResourceInstanceType
        {
            get => Resource is null ? default : Resource.InstanceType;
            set
            {
                if (Resource is null)
                    Resource = new MaterializationComputeResource();
                Resource.InstanceType = value;
            }
        }

        /// <summary> Specifies the spark compute settings. </summary>
        public IDictionary<string, string> SparkConfiguration { get; }
        /// <summary> Specifies the tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
