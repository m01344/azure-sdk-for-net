// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The azure monitor status response. </summary>
    public partial class HDInsightAzureMonitorExtensionStatus
    {
        /// <summary> Initializes a new instance of <see cref="HDInsightAzureMonitorExtensionStatus"/>. </summary>
        internal HDInsightAzureMonitorExtensionStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightAzureMonitorExtensionStatus"/>. </summary>
        /// <param name="isClusterMonitoringEnabled"> The status of the monitor on the HDInsight cluster. </param>
        /// <param name="workspaceId"> The workspace ID of the monitor on the HDInsight cluster. </param>
        /// <param name="selectedConfigurations"> The selected configurations. </param>
        internal HDInsightAzureMonitorExtensionStatus(bool? isClusterMonitoringEnabled, string workspaceId, HDInsightAzureMonitorSelectedConfigurations selectedConfigurations)
        {
            IsClusterMonitoringEnabled = isClusterMonitoringEnabled;
            WorkspaceId = workspaceId;
            SelectedConfigurations = selectedConfigurations;
        }

        /// <summary> The status of the monitor on the HDInsight cluster. </summary>
        public bool? IsClusterMonitoringEnabled { get; }
        /// <summary> The workspace ID of the monitor on the HDInsight cluster. </summary>
        public string WorkspaceId { get; }
        /// <summary> The selected configurations. </summary>
        public HDInsightAzureMonitorSelectedConfigurations SelectedConfigurations { get; }
    }
}
