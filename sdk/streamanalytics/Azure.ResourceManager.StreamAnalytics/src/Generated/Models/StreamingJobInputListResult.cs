// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> Object containing a list of inputs under a streaming job. </summary>
    internal partial class StreamingJobInputListResult
    {
        /// <summary> Initializes a new instance of <see cref="StreamingJobInputListResult"/>. </summary>
        internal StreamingJobInputListResult()
        {
            Value = new ChangeTrackingList<StreamingJobInputData>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobInputListResult"/>. </summary>
        /// <param name="value"> A list of inputs under a streaming job. Populated by a 'List' operation. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        internal StreamingJobInputListResult(IReadOnlyList<StreamingJobInputData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of inputs under a streaming job. Populated by a 'List' operation. </summary>
        public IReadOnlyList<StreamingJobInputData> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
    }
}
