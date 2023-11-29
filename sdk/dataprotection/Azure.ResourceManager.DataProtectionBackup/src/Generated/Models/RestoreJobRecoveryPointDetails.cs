// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The RestoreJobRecoveryPointDetails. </summary>
    public partial class RestoreJobRecoveryPointDetails
    {
        /// <summary> Initializes a new instance of <see cref="RestoreJobRecoveryPointDetails"/>. </summary>
        internal RestoreJobRecoveryPointDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestoreJobRecoveryPointDetails"/>. </summary>
        /// <param name="recoveryPointId"></param>
        /// <param name="recoverOn"></param>
        internal RestoreJobRecoveryPointDetails(string recoveryPointId, DateTimeOffset? recoverOn)
        {
            RecoveryPointId = recoveryPointId;
            RecoverOn = recoverOn;
        }

        /// <summary> Gets the recovery point id. </summary>
        public string RecoveryPointId { get; }
        /// <summary> Gets the recover on. </summary>
        public DateTimeOffset? RecoverOn { get; }
    }
}
