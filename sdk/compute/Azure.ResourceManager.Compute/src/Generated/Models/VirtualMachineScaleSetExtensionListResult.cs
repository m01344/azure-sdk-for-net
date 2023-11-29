// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Compute;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The List VM scale set extension operation response. </summary>
    internal partial class VirtualMachineScaleSetExtensionListResult
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionListResult"/>. </summary>
        /// <param name="value"> The list of VM scale set extensions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal VirtualMachineScaleSetExtensionListResult(IEnumerable<VirtualMachineScaleSetExtensionData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetExtensionListResult"/>. </summary>
        /// <param name="value"> The list of VM scale set extensions. </param>
        /// <param name="nextLink"> The uri to fetch the next page of VM scale set extensions. Call ListNext() with this to fetch the next page of VM scale set extensions. </param>
        internal VirtualMachineScaleSetExtensionListResult(IReadOnlyList<VirtualMachineScaleSetExtensionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of VM scale set extensions. </summary>
        public IReadOnlyList<VirtualMachineScaleSetExtensionData> Value { get; }
        /// <summary> The uri to fetch the next page of VM scale set extensions. Call ListNext() with this to fetch the next page of VM scale set extensions. </summary>
        public string NextLink { get; }
    }
}
