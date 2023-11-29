// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Provider specific input for InMageRcmFailback failover. </summary>
    public partial class InMageRcmFailbackPlannedFailoverProviderContent : PlannedFailoverProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackPlannedFailoverProviderContent"/>. </summary>
        /// <param name="recoveryPointType"> The recovery point type. </param>
        public InMageRcmFailbackPlannedFailoverProviderContent(InMageRcmFailbackRecoveryPointType recoveryPointType)
        {
            RecoveryPointType = recoveryPointType;
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> The recovery point type. </summary>
        public InMageRcmFailbackRecoveryPointType RecoveryPointType { get; }
    }
}
