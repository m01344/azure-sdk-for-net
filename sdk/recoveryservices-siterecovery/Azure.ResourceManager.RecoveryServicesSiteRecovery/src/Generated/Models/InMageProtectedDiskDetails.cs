// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMage protected disk details. </summary>
    public partial class InMageProtectedDiskDetails
    {
        /// <summary> Initializes a new instance of <see cref="InMageProtectedDiskDetails"/>. </summary>
        internal InMageProtectedDiskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageProtectedDiskDetails"/>. </summary>
        /// <param name="diskId"> The disk id. </param>
        /// <param name="diskName"> The disk name. </param>
        /// <param name="protectionStage"> The protection stage. </param>
        /// <param name="healthErrorCode"> The health error code for the disk. </param>
        /// <param name="rpoInSeconds"> The RPO in seconds. </param>
        /// <param name="resyncRequired"> A value indicating whether resync is required for this disk. </param>
        /// <param name="resyncProgressPercentage"> The resync progress percentage. </param>
        /// <param name="resyncDurationInSeconds"> The resync duration in seconds. </param>
        /// <param name="diskCapacityInBytes"> The disk capacity in bytes. </param>
        /// <param name="fileSystemCapacityInBytes"> The file system capacity in bytes. </param>
        /// <param name="sourceDataInMB"> The source data transit in MB. </param>
        /// <param name="psDataInMB"> The PS data transit in MB. </param>
        /// <param name="targetDataInMB"> The target data transit in MB. </param>
        /// <param name="diskResized"> A value indicating whether disk is resized. </param>
        /// <param name="lastRpoCalculatedOn"> The last RPO calculated time. </param>
        /// <param name="resyncProcessedBytes"> The resync processed bytes. </param>
        /// <param name="resyncTotalTransferredBytes"> The resync total transferred bytes. </param>
        /// <param name="resyncLast15MinutesTransferredBytes"> The resync last 15 minutes transferred bytes. </param>
        /// <param name="resyncLastDataTransferTimeUTC"> The last data transfer time in UTC. </param>
        /// <param name="resyncStartOn"> The resync start time. </param>
        /// <param name="progressHealth"> The Progress Health. </param>
        /// <param name="progressStatus"> The Progress Status. </param>
        internal InMageProtectedDiskDetails(string diskId, string diskName, string protectionStage, string healthErrorCode, long? rpoInSeconds, string resyncRequired, int? resyncProgressPercentage, long? resyncDurationInSeconds, long? diskCapacityInBytes, long? fileSystemCapacityInBytes, double? sourceDataInMB, double? psDataInMB, double? targetDataInMB, string diskResized, DateTimeOffset? lastRpoCalculatedOn, long? resyncProcessedBytes, long? resyncTotalTransferredBytes, long? resyncLast15MinutesTransferredBytes, DateTimeOffset? resyncLastDataTransferTimeUTC, DateTimeOffset? resyncStartOn, string progressHealth, string progressStatus)
        {
            DiskId = diskId;
            DiskName = diskName;
            ProtectionStage = protectionStage;
            HealthErrorCode = healthErrorCode;
            RpoInSeconds = rpoInSeconds;
            ResyncRequired = resyncRequired;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncDurationInSeconds = resyncDurationInSeconds;
            DiskCapacityInBytes = diskCapacityInBytes;
            FileSystemCapacityInBytes = fileSystemCapacityInBytes;
            SourceDataInMB = sourceDataInMB;
            PSDataInMB = psDataInMB;
            TargetDataInMB = targetDataInMB;
            DiskResized = diskResized;
            LastRpoCalculatedOn = lastRpoCalculatedOn;
            ResyncProcessedBytes = resyncProcessedBytes;
            ResyncTotalTransferredBytes = resyncTotalTransferredBytes;
            ResyncLast15MinutesTransferredBytes = resyncLast15MinutesTransferredBytes;
            ResyncLastDataTransferTimeUTC = resyncLastDataTransferTimeUTC;
            ResyncStartOn = resyncStartOn;
            ProgressHealth = progressHealth;
            ProgressStatus = progressStatus;
        }

        /// <summary> The disk id. </summary>
        public string DiskId { get; }
        /// <summary> The disk name. </summary>
        public string DiskName { get; }
        /// <summary> The protection stage. </summary>
        public string ProtectionStage { get; }
        /// <summary> The health error code for the disk. </summary>
        public string HealthErrorCode { get; }
        /// <summary> The RPO in seconds. </summary>
        public long? RpoInSeconds { get; }
        /// <summary> A value indicating whether resync is required for this disk. </summary>
        public string ResyncRequired { get; }
        /// <summary> The resync progress percentage. </summary>
        public int? ResyncProgressPercentage { get; }
        /// <summary> The resync duration in seconds. </summary>
        public long? ResyncDurationInSeconds { get; }
        /// <summary> The disk capacity in bytes. </summary>
        public long? DiskCapacityInBytes { get; }
        /// <summary> The file system capacity in bytes. </summary>
        public long? FileSystemCapacityInBytes { get; }
        /// <summary> The source data transit in MB. </summary>
        public double? SourceDataInMB { get; }
        /// <summary> The PS data transit in MB. </summary>
        public double? PSDataInMB { get; }
        /// <summary> The target data transit in MB. </summary>
        public double? TargetDataInMB { get; }
        /// <summary> A value indicating whether disk is resized. </summary>
        public string DiskResized { get; }
        /// <summary> The last RPO calculated time. </summary>
        public DateTimeOffset? LastRpoCalculatedOn { get; }
        /// <summary> The resync processed bytes. </summary>
        public long? ResyncProcessedBytes { get; }
        /// <summary> The resync total transferred bytes. </summary>
        public long? ResyncTotalTransferredBytes { get; }
        /// <summary> The resync last 15 minutes transferred bytes. </summary>
        public long? ResyncLast15MinutesTransferredBytes { get; }
        /// <summary> The last data transfer time in UTC. </summary>
        public DateTimeOffset? ResyncLastDataTransferTimeUTC { get; }
        /// <summary> The resync start time. </summary>
        public DateTimeOffset? ResyncStartOn { get; }
        /// <summary> The Progress Health. </summary>
        public string ProgressHealth { get; }
        /// <summary> The Progress Status. </summary>
        public string ProgressStatus { get; }
    }
}
