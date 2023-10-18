// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A class representing a collection of <see cref="DynatraceMonitorResource" /> and their operations.
    /// Each <see cref="DynatraceMonitorResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="DynatraceMonitorCollection" /> instance call the GetDynatraceMonitors method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class DynatraceMonitorCollection : ArmCollection, IEnumerable<DynatraceMonitorResource>, IAsyncEnumerable<DynatraceMonitorResource>
    {
        private readonly ClientDiagnostics _dynatraceMonitorMonitorsClientDiagnostics;
        private readonly MonitorsRestOperations _dynatraceMonitorMonitorsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DynatraceMonitorCollection"/> class for mocking. </summary>
        protected DynatraceMonitorCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DynatraceMonitorCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DynatraceMonitorCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dynatraceMonitorMonitorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Dynatrace", DynatraceMonitorResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DynatraceMonitorResource.ResourceType, out string dynatraceMonitorMonitorsApiVersion);
            _dynatraceMonitorMonitorsRestClient = new MonitorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dynatraceMonitorMonitorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a MonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DynatraceMonitorResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string monitorName, DynatraceMonitorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dynatraceMonitorMonitorsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DynatraceArmOperation<DynatraceMonitorResource>(new DynatraceMonitorOperationSource(Client), _dynatraceMonitorMonitorsClientDiagnostics, Pipeline, _dynatraceMonitorMonitorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a MonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="data"> Resource create parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DynatraceMonitorResource> CreateOrUpdate(WaitUntil waitUntil, string monitorName, DynatraceMonitorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dynatraceMonitorMonitorsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data, cancellationToken);
                var operation = new DynatraceArmOperation<DynatraceMonitorResource>(new DynatraceMonitorOperationSource(Client), _dynatraceMonitorMonitorsClientDiagnostics, Pipeline, _dynatraceMonitorMonitorsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, monitorName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a MonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual async Task<Response<DynatraceMonitorResource>> GetAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.Get");
            scope.Start();
            try
            {
                var response = await _dynatraceMonitorMonitorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a MonitorResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual Response<DynatraceMonitorResource> Get(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.Get");
            scope.Start();
            try
            {
                var response = _dynatraceMonitorMonitorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DynatraceMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List MonitorResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DynatraceMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DynatraceMonitorResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dynatraceMonitorMonitorsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dynatraceMonitorMonitorsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DynatraceMonitorResource(Client, DynatraceMonitorData.DeserializeDynatraceMonitorData(e)), _dynatraceMonitorMonitorsClientDiagnostics, Pipeline, "DynatraceMonitorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List MonitorResource resources by resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DynatraceMonitorResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DynatraceMonitorResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dynatraceMonitorMonitorsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dynatraceMonitorMonitorsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DynatraceMonitorResource(Client, DynatraceMonitorData.DeserializeDynatraceMonitorData(e)), _dynatraceMonitorMonitorsClientDiagnostics, Pipeline, "DynatraceMonitorCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dynatraceMonitorMonitorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual Response<bool> Exists(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.Exists");
            scope.Start();
            try
            {
                var response = _dynatraceMonitorMonitorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual async Task<NullableResponse<DynatraceMonitorResource>> GetIfExistsAsync(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dynatraceMonitorMonitorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DynatraceMonitorResource>(response.GetRawResponse());
                return Response.FromValue(new DynatraceMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Dynatrace.Observability/monitors/{monitorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Monitors_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="monitorName"> Monitor resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="monitorName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="monitorName"/> is null. </exception>
        public virtual NullableResponse<DynatraceMonitorResource> GetIfExists(string monitorName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(monitorName, nameof(monitorName));

            using var scope = _dynatraceMonitorMonitorsClientDiagnostics.CreateScope("DynatraceMonitorCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dynatraceMonitorMonitorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, monitorName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DynatraceMonitorResource>(response.GetRawResponse());
                return Response.FromValue(new DynatraceMonitorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DynatraceMonitorResource> IEnumerable<DynatraceMonitorResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DynatraceMonitorResource> IAsyncEnumerable<DynatraceMonitorResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
