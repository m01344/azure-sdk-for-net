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

namespace Azure.ResourceManager.Cdn
{
    /// <summary>
    /// A class representing a collection of <see cref="FrontDoorSecretResource" /> and their operations.
    /// Each <see cref="FrontDoorSecretResource" /> in the collection will belong to the same instance of <see cref="ProfileResource" />.
    /// To get a <see cref="FrontDoorSecretCollection" /> instance call the GetFrontDoorSecrets method from an instance of <see cref="ProfileResource" />.
    /// </summary>
    public partial class FrontDoorSecretCollection : ArmCollection, IEnumerable<FrontDoorSecretResource>, IAsyncEnumerable<FrontDoorSecretResource>
    {
        private readonly ClientDiagnostics _frontDoorSecretClientDiagnostics;
        private readonly FrontDoorSecretsRestOperations _frontDoorSecretRestClient;

        /// <summary> Initializes a new instance of the <see cref="FrontDoorSecretCollection"/> class for mocking. </summary>
        protected FrontDoorSecretCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FrontDoorSecretCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FrontDoorSecretCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _frontDoorSecretClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Cdn", FrontDoorSecretResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(FrontDoorSecretResource.ResourceType, out string frontDoorSecretApiVersion);
            _frontDoorSecretRestClient = new FrontDoorSecretsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, frontDoorSecretApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ProfileResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ProfileResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a new Secret within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="data"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<FrontDoorSecretResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string secretName, FrontDoorSecretData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _frontDoorSecretRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CdnArmOperation<FrontDoorSecretResource>(new FrontDoorSecretOperationSource(Client), _frontDoorSecretClientDiagnostics, Pipeline, _frontDoorSecretRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a new Secret within the specified profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="data"> The Secret properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<FrontDoorSecretResource> CreateOrUpdate(WaitUntil waitUntil, string secretName, FrontDoorSecretData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _frontDoorSecretRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, data, cancellationToken);
                var operation = new CdnArmOperation<FrontDoorSecretResource>(new FrontDoorSecretOperationSource(Client), _frontDoorSecretClientDiagnostics, Pipeline, _frontDoorSecretRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets an existing Secret within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<FrontDoorSecretResource>> GetAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.Get");
            scope.Start();
            try
            {
                var response = await _frontDoorSecretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecretResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an existing Secret within a profile.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<FrontDoorSecretResource> Get(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.Get");
            scope.Start();
            try
            {
                var response = _frontDoorSecretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecretResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists existing AzureFrontDoor secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_ListByProfile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FrontDoorSecretResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FrontDoorSecretResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorSecretRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorSecretRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new FrontDoorSecretResource(Client, FrontDoorSecretData.DeserializeFrontDoorSecretData(e)), _frontDoorSecretClientDiagnostics, Pipeline, "FrontDoorSecretCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists existing AzureFrontDoor secrets.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_ListByProfile</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FrontDoorSecretResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FrontDoorSecretResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _frontDoorSecretRestClient.CreateListByProfileRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _frontDoorSecretRestClient.CreateListByProfileNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new FrontDoorSecretResource(Client, FrontDoorSecretData.DeserializeFrontDoorSecretData(e)), _frontDoorSecretClientDiagnostics, Pipeline, "FrontDoorSecretCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.Exists");
            scope.Start();
            try
            {
                var response = await _frontDoorSecretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual Response<bool> Exists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.Exists");
            scope.Start();
            try
            {
                var response = _frontDoorSecretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual async Task<NullableResponse<FrontDoorSecretResource>> GetIfExistsAsync(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _frontDoorSecretRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorSecretResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecretResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cdn/profiles/{profileName}/secrets/{secretName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FrontDoorSecrets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="secretName"> Name of the Secret under the profile. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="secretName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="secretName"/> is null. </exception>
        public virtual NullableResponse<FrontDoorSecretResource> GetIfExists(string secretName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(secretName, nameof(secretName));

            using var scope = _frontDoorSecretClientDiagnostics.CreateScope("FrontDoorSecretCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _frontDoorSecretRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, secretName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<FrontDoorSecretResource>(response.GetRawResponse());
                return Response.FromValue(new FrontDoorSecretResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FrontDoorSecretResource> IEnumerable<FrontDoorSecretResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FrontDoorSecretResource> IAsyncEnumerable<FrontDoorSecretResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
