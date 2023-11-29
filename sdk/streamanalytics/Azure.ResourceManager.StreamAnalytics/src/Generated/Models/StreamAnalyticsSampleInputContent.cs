// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The stream analytics input to sample. </summary>
    public partial class StreamAnalyticsSampleInputContent
    {
        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsSampleInputContent"/>. </summary>
        public StreamAnalyticsSampleInputContent()
        {
        }

        /// <summary> The stream analytics input to sample. </summary>
        public StreamingJobInputData Input { get; set; }
        /// <summary> Defaults to the default ASA job compatibility level. Today it is 1.2. </summary>
        public string CompatibilityLevel { get; set; }
        /// <summary> The SAS URI of the storage blob for service to write the sampled events to. If this parameter is not provided, service will write events to he system account and share a temporary SAS URI to it. </summary>
        public Uri EventsUri { get; set; }
        /// <summary> Defaults to en-US. </summary>
        public AzureLocation? DataLocalion { get; set; }
    }
}
