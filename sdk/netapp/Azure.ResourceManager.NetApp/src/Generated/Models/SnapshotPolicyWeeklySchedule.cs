// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Weekly Schedule properties, make a snapshot every week at a specific day or days. </summary>
    public partial class SnapshotPolicyWeeklySchedule
    {
        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyWeeklySchedule"/>. </summary>
        public SnapshotPolicyWeeklySchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SnapshotPolicyWeeklySchedule"/>. </summary>
        /// <param name="snapshotsToKeep"> Weekly snapshot count to keep. </param>
        /// <param name="day"> Indicates which weekdays snapshot should be taken, accepts a comma separated list of week day names in english. </param>
        /// <param name="hour"> Indicates which hour in UTC timezone a snapshot should be taken. </param>
        /// <param name="minute"> Indicates which minute snapshot should be taken. </param>
        /// <param name="usedBytes"> Resource size in bytes, current storage usage for the volume in bytes. </param>
        internal SnapshotPolicyWeeklySchedule(int? snapshotsToKeep, string day, int? hour, int? minute, long? usedBytes)
        {
            SnapshotsToKeep = snapshotsToKeep;
            Day = day;
            Hour = hour;
            Minute = minute;
            UsedBytes = usedBytes;
        }

        /// <summary> Weekly snapshot count to keep. </summary>
        public int? SnapshotsToKeep { get; set; }
        /// <summary> Indicates which weekdays snapshot should be taken, accepts a comma separated list of week day names in english. </summary>
        public string Day { get; set; }
        /// <summary> Indicates which hour in UTC timezone a snapshot should be taken. </summary>
        public int? Hour { get; set; }
        /// <summary> Indicates which minute snapshot should be taken. </summary>
        public int? Minute { get; set; }
        /// <summary> Resource size in bytes, current storage usage for the volume in bytes. </summary>
        public long? UsedBytes { get; set; }
    }
}
