// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automanage;

namespace Azure.ResourceManager.Automanage.Models
{
    /// <summary> The response of the list best practice operation. </summary>
    internal partial class BestPracticeList
    {
        /// <summary> Initializes a new instance of <see cref="BestPracticeList"/>. </summary>
        internal BestPracticeList()
        {
            Value = new ChangeTrackingList<AutomanageBestPracticeData>();
        }

        /// <summary> Initializes a new instance of <see cref="BestPracticeList"/>. </summary>
        /// <param name="value"> Result of the list best practice operation. </param>
        internal BestPracticeList(IReadOnlyList<AutomanageBestPracticeData> value)
        {
            Value = value;
        }

        /// <summary> Result of the list best practice operation. </summary>
        public IReadOnlyList<AutomanageBestPracticeData> Value { get; }
    }
}
