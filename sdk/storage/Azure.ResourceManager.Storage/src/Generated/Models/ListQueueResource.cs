// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Storage;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Response schema. Contains list of queues returned. </summary>
    internal partial class ListQueueResource
    {
        /// <summary> Initializes a new instance of <see cref="ListQueueResource"/>. </summary>
        internal ListQueueResource()
        {
            Value = new ChangeTrackingList<StorageQueueData>();
        }

        /// <summary> Initializes a new instance of <see cref="ListQueueResource"/>. </summary>
        /// <param name="value"> List of queues returned. </param>
        /// <param name="nextLink"> Request URL that can be used to list next page of queues. </param>
        internal ListQueueResource(IReadOnlyList<StorageQueueData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of queues returned. </summary>
        public IReadOnlyList<StorageQueueData> Value { get; }
        /// <summary> Request URL that can be used to list next page of queues. </summary>
        public string NextLink { get; }
    }
}
