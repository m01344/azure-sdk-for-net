// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Logic;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> A collection of batch configurations. </summary>
    internal partial class BatchConfigurationCollection
    {
        /// <summary> Initializes a new instance of <see cref="BatchConfigurationCollection"/>. </summary>
        internal BatchConfigurationCollection()
        {
            Value = new ChangeTrackingList<IntegrationAccountBatchConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="BatchConfigurationCollection"/>. </summary>
        /// <param name="value"></param>
        internal BatchConfigurationCollection(IReadOnlyList<IntegrationAccountBatchConfigurationData> value)
        {
            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<IntegrationAccountBatchConfigurationData> Value { get; }
    }
}
