// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    /// <summary> The AzureDevOpsRepoListResponse. </summary>
    internal partial class AzureDevOpsRepoListResponse
    {
        /// <summary> Initializes a new instance of <see cref="AzureDevOpsRepoListResponse"/>. </summary>
        internal AzureDevOpsRepoListResponse()
        {
            Value = new ChangeTrackingList<AzureDevOpsRepoData>();
        }

        /// <summary> Initializes a new instance of <see cref="AzureDevOpsRepoListResponse"/>. </summary>
        /// <param name="value"> Gets or sets list of resources. </param>
        /// <param name="nextLink"> Gets or sets next link to scroll over the results. </param>
        internal AzureDevOpsRepoListResponse(IReadOnlyList<AzureDevOpsRepoData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets list of resources. </summary>
        public IReadOnlyList<AzureDevOpsRepoData> Value { get; }
        /// <summary> Gets or sets next link to scroll over the results. </summary>
        public string NextLink { get; }
    }
}
