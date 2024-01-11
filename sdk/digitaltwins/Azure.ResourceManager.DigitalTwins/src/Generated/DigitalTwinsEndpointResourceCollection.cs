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

namespace Azure.ResourceManager.DigitalTwins
{
    /// <summary>
    /// A class representing a collection of <see cref="DigitalTwinsEndpointResource"/> and their operations.
    /// Each <see cref="DigitalTwinsEndpointResource"/> in the collection will belong to the same instance of <see cref="DigitalTwinsDescriptionResource"/>.
    /// To get a <see cref="DigitalTwinsEndpointResourceCollection"/> instance call the GetDigitalTwinsEndpointResources method from an instance of <see cref="DigitalTwinsDescriptionResource"/>.
    /// </summary>
    public partial class DigitalTwinsEndpointResourceCollection : ArmCollection, IEnumerable<DigitalTwinsEndpointResource>, IAsyncEnumerable<DigitalTwinsEndpointResource>
    {
        private readonly ClientDiagnostics _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics;
        private readonly DigitalTwinsEndpointRestOperations _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsEndpointResourceCollection"/> class for mocking. </summary>
        protected DigitalTwinsEndpointResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DigitalTwinsEndpointResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DigitalTwinsEndpointResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DigitalTwins", DigitalTwinsEndpointResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DigitalTwinsEndpointResource.ResourceType, out string digitalTwinsEndpointResourceDigitalTwinsEndpointApiVersion);
            _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient = new DigitalTwinsEndpointRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, digitalTwinsEndpointResourceDigitalTwinsEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DigitalTwinsDescriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DigitalTwinsDescriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update DigitalTwinsInstance endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="data"> The DigitalTwinsInstance endpoint metadata and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DigitalTwinsEndpointResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string endpointName, DigitalTwinsEndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DigitalTwinsArmOperation<DigitalTwinsEndpointResource>(new DigitalTwinsEndpointResourceOperationSource(Client), _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics, Pipeline, _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update DigitalTwinsInstance endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="data"> The DigitalTwinsInstance endpoint metadata and security metadata. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DigitalTwinsEndpointResource> CreateOrUpdate(WaitUntil waitUntil, string endpointName, DigitalTwinsEndpointResourceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data, cancellationToken);
                var operation = new DigitalTwinsArmOperation<DigitalTwinsEndpointResource>(new DigitalTwinsEndpointResourceOperationSource(Client), _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics, Pipeline, _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get DigitalTwinsInstances Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<DigitalTwinsEndpointResource>> GetAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get DigitalTwinsInstances Endpoint.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<DigitalTwinsEndpointResource> Get(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get DigitalTwinsInstance Endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DigitalTwinsEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DigitalTwinsEndpointResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DigitalTwinsEndpointResource(Client, DigitalTwinsEndpointResourceData.DeserializeDigitalTwinsEndpointResourceData(e)), _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics, Pipeline, "DigitalTwinsEndpointResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get DigitalTwinsInstance Endpoints.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DigitalTwinsEndpointResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DigitalTwinsEndpointResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DigitalTwinsEndpointResource(Client, DigitalTwinsEndpointResourceData.DeserializeDigitalTwinsEndpointResourceData(e)), _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics, Pipeline, "DigitalTwinsEndpointResourceCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual async Task<NullableResponse<DigitalTwinsEndpointResource>> GetIfExistsAsync(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DigitalTwinsEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsEndpointResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DigitalTwins/digitalTwinsInstances/{resourceName}/endpoints/{endpointName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DigitalTwinsEndpoint_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-01-31</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DigitalTwinsEndpointResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="endpointName"> Name of Endpoint Resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="endpointName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="endpointName"/> is null. </exception>
        public virtual NullableResponse<DigitalTwinsEndpointResource> GetIfExists(string endpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(endpointName, nameof(endpointName));

            using var scope = _digitalTwinsEndpointResourceDigitalTwinsEndpointClientDiagnostics.CreateScope("DigitalTwinsEndpointResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _digitalTwinsEndpointResourceDigitalTwinsEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, endpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DigitalTwinsEndpointResource>(response.GetRawResponse());
                return Response.FromValue(new DigitalTwinsEndpointResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DigitalTwinsEndpointResource> IEnumerable<DigitalTwinsEndpointResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DigitalTwinsEndpointResource> IAsyncEnumerable<DigitalTwinsEndpointResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
