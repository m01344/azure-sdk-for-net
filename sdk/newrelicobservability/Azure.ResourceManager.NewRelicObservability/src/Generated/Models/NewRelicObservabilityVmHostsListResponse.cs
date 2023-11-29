// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of a list VM Host Operation. </summary>
    internal partial class NewRelicObservabilityVmHostsListResponse
    {
        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityVmHostsListResponse"/>. </summary>
        /// <param name="value"> The VMInfo items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal NewRelicObservabilityVmHostsListResponse(IEnumerable<NewRelicObservabilityVmInfo> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityVmHostsListResponse"/>. </summary>
        /// <param name="value"> The VMInfo items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal NewRelicObservabilityVmHostsListResponse(IReadOnlyList<NewRelicObservabilityVmInfo> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The VMInfo items on this page. </summary>
        public IReadOnlyList<NewRelicObservabilityVmInfo> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
