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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryIntegrationRuntimeResource" /> and their operations.
    /// Each <see cref="DataFactoryIntegrationRuntimeResource" /> in the collection will belong to the same instance of <see cref="DataFactoryResource" />.
    /// To get a <see cref="DataFactoryIntegrationRuntimeCollection" /> instance call the GetDataFactoryIntegrationRuntimes method from an instance of <see cref="DataFactoryResource" />.
    /// </summary>
    public partial class DataFactoryIntegrationRuntimeCollection : ArmCollection, IEnumerable<DataFactoryIntegrationRuntimeResource>, IAsyncEnumerable<DataFactoryIntegrationRuntimeResource>
    {
        private readonly ClientDiagnostics _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics;
        private readonly IntegrationRuntimesRestOperations _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryIntegrationRuntimeCollection"/> class for mocking. </summary>
        protected DataFactoryIntegrationRuntimeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryIntegrationRuntimeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryIntegrationRuntimeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryIntegrationRuntimeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryIntegrationRuntimeResource.ResourceType, out string dataFactoryIntegrationRuntimeIntegrationRuntimesApiVersion);
            _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient = new IntegrationRuntimesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryIntegrationRuntimeIntegrationRuntimesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataFactoryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataFactoryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an integration runtime.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="data"> Integration runtime resource definition. </param>
        /// <param name="ifMatch"> ETag of the integration runtime entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryIntegrationRuntimeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string integrationRuntimeName, DataFactoryIntegrationRuntimeData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryIntegrationRuntimeResource>(Response.FromValue(new DataFactoryIntegrationRuntimeResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an integration runtime.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="data"> Integration runtime resource definition. </param>
        /// <param name="ifMatch"> ETag of the integration runtime entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryIntegrationRuntimeResource> CreateOrUpdate(WaitUntil waitUntil, string integrationRuntimeName, DataFactoryIntegrationRuntimeData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryIntegrationRuntimeResource>(Response.FromValue(new DataFactoryIntegrationRuntimeResource(Client, response), response.GetRawResponse()));
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
        /// Gets an integration runtime.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="ifNoneMatch"> ETag of the integration runtime entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryIntegrationRuntimeResource>> GetAsync(string integrationRuntimeName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryIntegrationRuntimeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an integration runtime.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="ifNoneMatch"> ETag of the integration runtime entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public virtual Response<DataFactoryIntegrationRuntimeResource> Get(string integrationRuntimeName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryIntegrationRuntimeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists integration runtimes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryIntegrationRuntimeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryIntegrationRuntimeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryIntegrationRuntimeResource(Client, DataFactoryIntegrationRuntimeData.DeserializeDataFactoryIntegrationRuntimeData(e)), _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics, Pipeline, "DataFactoryIntegrationRuntimeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists integration runtimes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryIntegrationRuntimeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryIntegrationRuntimeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryIntegrationRuntimeResource(Client, DataFactoryIntegrationRuntimeData.DeserializeDataFactoryIntegrationRuntimeData(e)), _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics, Pipeline, "DataFactoryIntegrationRuntimeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="ifNoneMatch"> ETag of the integration runtime entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string integrationRuntimeName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="ifNoneMatch"> ETag of the integration runtime entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public virtual Response<bool> Exists(string integrationRuntimeName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, ifNoneMatch, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="ifNoneMatch"> ETag of the integration runtime entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataFactoryIntegrationRuntimeResource>> GetIfExistsAsync(string integrationRuntimeName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryIntegrationRuntimeResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryIntegrationRuntimeResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/integrationRuntimes/{integrationRuntimeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationRuntimes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationRuntimeName"> The integration runtime name. </param>
        /// <param name="ifNoneMatch"> ETag of the integration runtime entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationRuntimeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationRuntimeName"/> is null. </exception>
        public virtual NullableResponse<DataFactoryIntegrationRuntimeResource> GetIfExists(string integrationRuntimeName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationRuntimeName, nameof(integrationRuntimeName));

            using var scope = _dataFactoryIntegrationRuntimeIntegrationRuntimesClientDiagnostics.CreateScope("DataFactoryIntegrationRuntimeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataFactoryIntegrationRuntimeIntegrationRuntimesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, integrationRuntimeName, ifNoneMatch, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryIntegrationRuntimeResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryIntegrationRuntimeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryIntegrationRuntimeResource> IEnumerable<DataFactoryIntegrationRuntimeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryIntegrationRuntimeResource> IAsyncEnumerable<DataFactoryIntegrationRuntimeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
