// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The policy used for monitoring the application upgrade. </summary>
    public partial class RollingUpgradeMonitoringPolicy
    {
        /// <summary> Initializes a new instance of <see cref="RollingUpgradeMonitoringPolicy"/>. </summary>
        /// <param name="failureAction"> The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode. </param>
        /// <param name="healthCheckWaitDuration"> The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="healthCheckStableDuration"> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="healthCheckRetryTimeout"> The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="upgradeTimeout"> The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        /// <param name="upgradeDomainTimeout"> The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </param>
        public RollingUpgradeMonitoringPolicy(PolicyViolationCompensationAction failureAction, TimeSpan healthCheckWaitDuration, TimeSpan healthCheckStableDuration, TimeSpan healthCheckRetryTimeout, TimeSpan upgradeTimeout, TimeSpan upgradeDomainTimeout)
        {
            FailureAction = failureAction;
            HealthCheckWaitDuration = healthCheckWaitDuration;
            HealthCheckStableDuration = healthCheckStableDuration;
            HealthCheckRetryTimeout = healthCheckRetryTimeout;
            UpgradeTimeout = upgradeTimeout;
            UpgradeDomainTimeout = upgradeDomainTimeout;
        }

        /// <summary> The compensating action to perform when a Monitored upgrade encounters monitoring policy or health policy violations. Invalid indicates the failure action is invalid. Rollback specifies that the upgrade will start rolling back automatically. Manual indicates that the upgrade will switch to UnmonitoredManual upgrade mode. </summary>
        public PolicyViolationCompensationAction FailureAction { get; set; }
        /// <summary> The amount of time to wait after completing an upgrade domain before applying health policies. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan HealthCheckWaitDuration { get; set; }
        /// <summary> The amount of time that the application or cluster must remain healthy before the upgrade proceeds to the next upgrade domain. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan HealthCheckStableDuration { get; set; }
        /// <summary> The amount of time to retry health evaluation when the application or cluster is unhealthy before FailureAction is executed. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan HealthCheckRetryTimeout { get; set; }
        /// <summary> The amount of time the overall upgrade has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan UpgradeTimeout { get; set; }
        /// <summary> The amount of time each upgrade domain has to complete before FailureAction is executed. Cannot be larger than 12 hours. It is interpreted as a string representing an ISO 8601 duration with following format "hh:mm:ss.fff". </summary>
        public TimeSpan UpgradeDomainTimeout { get; set; }
    }
}
