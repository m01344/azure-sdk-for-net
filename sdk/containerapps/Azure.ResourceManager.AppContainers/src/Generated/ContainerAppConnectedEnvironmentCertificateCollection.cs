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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> and their operations.
    /// Each <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> in the collection will belong to the same instance of <see cref="ContainerAppConnectedEnvironmentResource"/>.
    /// To get a <see cref="ContainerAppConnectedEnvironmentCertificateCollection"/> instance call the GetContainerAppConnectedEnvironmentCertificates method from an instance of <see cref="ContainerAppConnectedEnvironmentResource"/>.
    /// </summary>
    public partial class ContainerAppConnectedEnvironmentCertificateCollection : ArmCollection, IEnumerable<ContainerAppConnectedEnvironmentCertificateResource>, IAsyncEnumerable<ContainerAppConnectedEnvironmentCertificateResource>
    {
        private readonly ClientDiagnostics _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics;
        private readonly ConnectedEnvironmentsCertificatesRestOperations _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentCertificateCollection"/> class for mocking. </summary>
        protected ContainerAppConnectedEnvironmentCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppConnectedEnvironmentCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppConnectedEnvironmentCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppConnectedEnvironmentCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppConnectedEnvironmentCertificateResource.ResourceType, out string containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesApiVersion);
            _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient = new ConnectedEnvironmentsCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppConnectedEnvironmentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppConnectedEnvironmentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or Update a Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="data"> Certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContainerAppConnectedEnvironmentCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, ContainerAppCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentCertificateResource>(Response.FromValue(new ContainerAppConnectedEnvironmentCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Create or Update a Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="data"> Certificate to be created or updated. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContainerAppConnectedEnvironmentCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, ContainerAppCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken);
                var operation = new AppContainersArmOperation<ContainerAppConnectedEnvironmentCertificateResource>(Response.FromValue(new ContainerAppConnectedEnvironmentCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Get the specified Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppConnectedEnvironmentCertificateResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified Certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<ContainerAppConnectedEnvironmentCertificateResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the Certificates in a given connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppConnectedEnvironmentCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentCertificateResource(Client, ContainerAppCertificateData.DeserializeContainerAppCertificateData(e)), _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get the Certificates in a given connected environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppConnectedEnvironmentCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppConnectedEnvironmentCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerAppConnectedEnvironmentCertificateResource(Client, ContainerAppCertificateData.DeserializeContainerAppCertificateData(e)), _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics, Pipeline, "ContainerAppConnectedEnvironmentCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<NullableResponse<ContainerAppConnectedEnvironmentCertificateResource>> GetIfExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppConnectedEnvironmentCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentCertificateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/connectedEnvironments/{connectedEnvironmentName}/certificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConnectedEnvironmentsCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ContainerAppConnectedEnvironmentCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of the Certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual NullableResponse<ContainerAppConnectedEnvironmentCertificateResource> GetIfExists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesClientDiagnostics.CreateScope("ContainerAppConnectedEnvironmentCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _containerAppConnectedEnvironmentCertificateConnectedEnvironmentsCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ContainerAppConnectedEnvironmentCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new ContainerAppConnectedEnvironmentCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppConnectedEnvironmentCertificateResource> IEnumerable<ContainerAppConnectedEnvironmentCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppConnectedEnvironmentCertificateResource> IAsyncEnumerable<ContainerAppConnectedEnvironmentCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
