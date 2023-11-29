// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure storage workload specific job task details. </summary>
    public partial class StorageBackupJobTaskDetails
    {
        /// <summary> Initializes a new instance of <see cref="StorageBackupJobTaskDetails"/>. </summary>
        public StorageBackupJobTaskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageBackupJobTaskDetails"/>. </summary>
        /// <param name="taskId"> The task display name. </param>
        /// <param name="status"> The status. </param>
        internal StorageBackupJobTaskDetails(string taskId, string status)
        {
            TaskId = taskId;
            Status = status;
        }

        /// <summary> The task display name. </summary>
        public string TaskId { get; set; }
        /// <summary> The status. </summary>
        public string Status { get; set; }
    }
}
