// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> A2A Policy creation input. </summary>
    public partial class A2APolicyCreationContent : PolicyProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="A2APolicyCreationContent"/>. </summary>
        /// <param name="multiVmSyncStatus"> A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'. </param>
        public A2APolicyCreationContent(SetMultiVmSyncStatus multiVmSyncStatus)
        {
            MultiVmSyncStatus = multiVmSyncStatus;
            InstanceType = "A2A";
        }

        /// <summary> The duration in minutes until which the recovery points need to be stored. </summary>
        public int? RecoveryPointHistory { get; set; }
        /// <summary> The crash consistent snapshot frequency (in minutes). </summary>
        public int? CrashConsistentFrequencyInMinutes { get; set; }
        /// <summary> The app consistent snapshot frequency (in minutes). </summary>
        public int? AppConsistentFrequencyInMinutes { get; set; }
        /// <summary> A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'. </summary>
        public SetMultiVmSyncStatus MultiVmSyncStatus { get; }
    }
}
