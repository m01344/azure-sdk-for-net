// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Planned failover model properties. </summary>
    public partial class PlannedFailoverModelProperties
    {
        /// <summary> Initializes a new instance of <see cref="PlannedFailoverModelProperties"/>. </summary>
        /// <param name="customProperties">
        /// Planned failover model custom properties.
        /// Please note <see cref="PlannedFailoverModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciPlannedFailoverModelCustomProperties"/>, <see cref="GeneralPlannedFailoverModelCustomProperties"/> and <see cref="VMwareToAzStackHciPlannedFailoverModelCustomProperties"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="customProperties"/> is null. </exception>
        public PlannedFailoverModelProperties(PlannedFailoverModelCustomProperties customProperties)
        {
            Argument.AssertNotNull(customProperties, nameof(customProperties));

            CustomProperties = customProperties;
        }

        /// <summary>
        /// Planned failover model custom properties.
        /// Please note <see cref="PlannedFailoverModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVToAzStackHciPlannedFailoverModelCustomProperties"/>, <see cref="GeneralPlannedFailoverModelCustomProperties"/> and <see cref="VMwareToAzStackHciPlannedFailoverModelCustomProperties"/>.
        /// </summary>
        public PlannedFailoverModelCustomProperties CustomProperties { get; set; }
    }
}
