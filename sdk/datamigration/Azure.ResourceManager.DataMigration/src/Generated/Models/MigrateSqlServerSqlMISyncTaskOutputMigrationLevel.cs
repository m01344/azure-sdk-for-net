// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlMISyncTaskOutputMigrationLevel. </summary>
    public partial class MigrateSqlServerSqlMISyncTaskOutputMigrationLevel : MigrateSqlServerSqlMISyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMISyncTaskOutputMigrationLevel"/>. </summary>
        internal MigrateSqlServerSqlMISyncTaskOutputMigrationLevel()
        {
            ResultType = "MigrationLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSqlServerSqlMISyncTaskOutputMigrationLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="databaseCount"> Count of databases. </param>
        /// <param name="state"> Current state of migration. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="sourceServerName"> Source server name. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServerBrandVersion"> Source server brand version. </param>
        /// <param name="targetServerName"> Target server name. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="databaseErrorCount"> Number of database level errors. </param>
        internal MigrateSqlServerSqlMISyncTaskOutputMigrationLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, int? databaseCount, MigrationState? state, DateTimeOffset? startedOn, DateTimeOffset? endedOn, string sourceServerName, string sourceServerVersion, string sourceServerBrandVersion, string targetServerName, string targetServerVersion, string targetServerBrandVersion, int? databaseErrorCount) : base(id, resultType, serializedAdditionalRawData)
        {
            DatabaseCount = databaseCount;
            State = state;
            StartedOn = startedOn;
            EndedOn = endedOn;
            SourceServerName = sourceServerName;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            TargetServerName = targetServerName;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            DatabaseErrorCount = databaseErrorCount;
            ResultType = resultType ?? "MigrationLevelOutput";
        }

        /// <summary> Count of databases. </summary>
        public int? DatabaseCount { get; }
        /// <summary> Current state of migration. </summary>
        public MigrationState? State { get; }
        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Source server name. </summary>
        public string SourceServerName { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server brand version. </summary>
        public string SourceServerBrandVersion { get; }
        /// <summary> Target server name. </summary>
        public string TargetServerName { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Number of database level errors. </summary>
        public int? DatabaseErrorCount { get; }
    }
}
