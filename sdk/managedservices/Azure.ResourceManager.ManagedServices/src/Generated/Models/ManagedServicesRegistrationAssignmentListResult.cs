// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The list of registration assignments. </summary>
    internal partial class ManagedServicesRegistrationAssignmentListResult
    {
        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationAssignmentListResult"/>. </summary>
        internal ManagedServicesRegistrationAssignmentListResult()
        {
            Value = new ChangeTrackingList<ManagedServicesRegistrationAssignmentData>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServicesRegistrationAssignmentListResult"/>. </summary>
        /// <param name="value"> The list of registration assignments. </param>
        /// <param name="nextLink"> The link to the next page of registration assignments. </param>
        internal ManagedServicesRegistrationAssignmentListResult(IReadOnlyList<ManagedServicesRegistrationAssignmentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of registration assignments. </summary>
        public IReadOnlyList<ManagedServicesRegistrationAssignmentData> Value { get; }
        /// <summary> The link to the next page of registration assignments. </summary>
        public string NextLink { get; }
    }
}
