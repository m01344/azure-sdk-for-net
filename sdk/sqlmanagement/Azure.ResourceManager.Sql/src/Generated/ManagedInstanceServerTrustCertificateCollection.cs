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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="ManagedInstanceServerTrustCertificateResource"/> and their operations.
    /// Each <see cref="ManagedInstanceServerTrustCertificateResource"/> in the collection will belong to the same instance of <see cref="ManagedInstanceResource"/>.
    /// To get a <see cref="ManagedInstanceServerTrustCertificateCollection"/> instance call the GetManagedInstanceServerTrustCertificates method from an instance of <see cref="ManagedInstanceResource"/>.
    /// </summary>
    public partial class ManagedInstanceServerTrustCertificateCollection : ArmCollection, IEnumerable<ManagedInstanceServerTrustCertificateResource>, IAsyncEnumerable<ManagedInstanceServerTrustCertificateResource>
    {
        private readonly ClientDiagnostics _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics;
        private readonly ServerTrustCertificatesRestOperations _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceServerTrustCertificateCollection"/> class for mocking. </summary>
        protected ManagedInstanceServerTrustCertificateCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceServerTrustCertificateCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ManagedInstanceServerTrustCertificateCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ManagedInstanceServerTrustCertificateResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ManagedInstanceServerTrustCertificateResource.ResourceType, out string managedInstanceServerTrustCertificateServerTrustCertificatesApiVersion);
            _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient = new ServerTrustCertificatesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, managedInstanceServerTrustCertificateServerTrustCertificatesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagedInstanceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagedInstanceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Uploads a server trust certificate from box to Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Name of of the certificate to upload. </param>
        /// <param name="data"> The server trust certificate info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ManagedInstanceServerTrustCertificateResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string certificateName, ServerTrustCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<ManagedInstanceServerTrustCertificateResource>(new ManagedInstanceServerTrustCertificateOperationSource(Client), _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics, Pipeline, _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Uploads a server trust certificate from box to Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="certificateName"> Name of of the certificate to upload. </param>
        /// <param name="data"> The server trust certificate info. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ManagedInstanceServerTrustCertificateResource> CreateOrUpdate(WaitUntil waitUntil, string certificateName, ServerTrustCertificateData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data, cancellationToken);
                var operation = new SqlArmOperation<ManagedInstanceServerTrustCertificateResource>(new ManagedInstanceServerTrustCertificateOperationSource(Client), _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics, Pipeline, _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a server trust certificate that was uploaded from box to Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of of the certificate to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<ManagedInstanceServerTrustCertificateResource>> GetAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerTrustCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server trust certificate that was uploaded from box to Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of of the certificate to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<ManagedInstanceServerTrustCertificateResource> Get(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.Get");
            scope.Start();
            try
            {
                var response = _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerTrustCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of server trust certificates that were uploaded from box to the given Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_ListByInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceServerTrustCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceServerTrustCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedInstanceServerTrustCertificateResource(Client, ServerTrustCertificateData.DeserializeServerTrustCertificateData(e)), _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics, Pipeline, "ManagedInstanceServerTrustCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of server trust certificates that were uploaded from box to the given Sql Managed Instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_ListByInstance</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceServerTrustCertificateResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceServerTrustCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateListByInstanceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.CreateListByInstanceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedInstanceServerTrustCertificateResource(Client, ServerTrustCertificateData.DeserializeServerTrustCertificateData(e)), _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics, Pipeline, "ManagedInstanceServerTrustCertificateCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of of the certificate to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of of the certificate to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual Response<bool> Exists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.Exists");
            scope.Start();
            try
            {
                var response = _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of of the certificate to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual async Task<NullableResponse<ManagedInstanceServerTrustCertificateResource>> GetIfExistsAsync(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ManagedInstanceServerTrustCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerTrustCertificateResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/serverTrustCertificates/{certificateName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ServerTrustCertificates_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-11-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ManagedInstanceServerTrustCertificateResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="certificateName"> Name of of the certificate to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="certificateName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateName"/> is null. </exception>
        public virtual NullableResponse<ManagedInstanceServerTrustCertificateResource> GetIfExists(string certificateName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(certificateName, nameof(certificateName));

            using var scope = _managedInstanceServerTrustCertificateServerTrustCertificatesClientDiagnostics.CreateScope("ManagedInstanceServerTrustCertificateCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedInstanceServerTrustCertificateServerTrustCertificatesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, certificateName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ManagedInstanceServerTrustCertificateResource>(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceServerTrustCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ManagedInstanceServerTrustCertificateResource> IEnumerable<ManagedInstanceServerTrustCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceServerTrustCertificateResource> IAsyncEnumerable<ManagedInstanceServerTrustCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
