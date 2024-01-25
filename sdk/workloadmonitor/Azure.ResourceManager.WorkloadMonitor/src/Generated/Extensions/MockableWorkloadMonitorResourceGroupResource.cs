// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.WorkloadMonitor;

namespace Azure.ResourceManager.WorkloadMonitor.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableWorkloadMonitorResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableWorkloadMonitorResourceGroupResource"/> class for mocking. </summary>
        protected MockableWorkloadMonitorResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableWorkloadMonitorResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableWorkloadMonitorResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of HealthMonitorResources in the ResourceGroupResource. </summary>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of HealthMonitorResources and their operations over a HealthMonitorResource. </returns>
        public virtual HealthMonitorCollection GetHealthMonitors(string providerName, string resourceCollectionName, string resourceName)
        {
            return new HealthMonitorCollection(Client, Id, providerName, resourceCollectionName, resourceName);
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HealthMonitorResource>> GetHealthMonitorAsync(string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetHealthMonitors(providerName, resourceCollectionName, resourceName).GetAsync(monitorId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-01-13-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthMonitorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<HealthMonitorResource> GetHealthMonitor(string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetHealthMonitors(providerName, resourceCollectionName, resourceName).Get(monitorId, expand, cancellationToken);
        }
    }
}
