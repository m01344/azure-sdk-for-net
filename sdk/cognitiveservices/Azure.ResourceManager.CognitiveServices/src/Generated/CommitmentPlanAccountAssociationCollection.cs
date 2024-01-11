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

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A class representing a collection of <see cref="CommitmentPlanAccountAssociationResource"/> and their operations.
    /// Each <see cref="CommitmentPlanAccountAssociationResource"/> in the collection will belong to the same instance of <see cref="CognitiveServicesCommitmentPlanResource"/>.
    /// To get a <see cref="CommitmentPlanAccountAssociationCollection"/> instance call the GetCommitmentPlanAccountAssociations method from an instance of <see cref="CognitiveServicesCommitmentPlanResource"/>.
    /// </summary>
    public partial class CommitmentPlanAccountAssociationCollection : ArmCollection, IEnumerable<CommitmentPlanAccountAssociationResource>, IAsyncEnumerable<CommitmentPlanAccountAssociationResource>
    {
        private readonly ClientDiagnostics _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics;
        private readonly CommitmentPlansRestOperations _commitmentPlanAccountAssociationCommitmentPlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="CommitmentPlanAccountAssociationCollection"/> class for mocking. </summary>
        protected CommitmentPlanAccountAssociationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CommitmentPlanAccountAssociationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CommitmentPlanAccountAssociationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", CommitmentPlanAccountAssociationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CommitmentPlanAccountAssociationResource.ResourceType, out string commitmentPlanAccountAssociationCommitmentPlansApiVersion);
            _commitmentPlanAccountAssociationCommitmentPlansRestClient = new CommitmentPlansRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, commitmentPlanAccountAssociationCommitmentPlansApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CognitiveServicesCommitmentPlanResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CognitiveServicesCommitmentPlanResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the association of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_CreateOrUpdateAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="data"> The commitmentPlan properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CommitmentPlanAccountAssociationResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string commitmentPlanAssociationName, CommitmentPlanAccountAssociationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateOrUpdateAssociationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, data, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation<CommitmentPlanAccountAssociationResource>(new CommitmentPlanAccountAssociationOperationSource(Client), _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics, Pipeline, _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateCreateOrUpdateAssociationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create or update the association of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_CreateOrUpdateAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="data"> The commitmentPlan properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CommitmentPlanAccountAssociationResource> CreateOrUpdate(WaitUntil waitUntil, string commitmentPlanAssociationName, CommitmentPlanAccountAssociationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateOrUpdateAssociation(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, data, cancellationToken);
                var operation = new CognitiveServicesArmOperation<CommitmentPlanAccountAssociationResource>(new CommitmentPlanAccountAssociationOperationSource(Client), _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics, Pipeline, _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateCreateOrUpdateAssociationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the association of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        public virtual async Task<Response<CommitmentPlanAccountAssociationResource>> GetAsync(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.Get");
            scope.Start();
            try
            {
                var response = await _commitmentPlanAccountAssociationCommitmentPlansRestClient.GetAssociationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommitmentPlanAccountAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the association of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        public virtual Response<CommitmentPlanAccountAssociationResource> Get(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.Get");
            scope.Start();
            try
            {
                var response = _commitmentPlanAccountAssociationCommitmentPlansRestClient.GetAssociation(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CommitmentPlanAccountAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the associations of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_ListAssociations</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CommitmentPlanAccountAssociationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CommitmentPlanAccountAssociationResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateListAssociationsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateListAssociationsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new CommitmentPlanAccountAssociationResource(Client, CommitmentPlanAccountAssociationData.DeserializeCommitmentPlanAccountAssociationData(e)), _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics, Pipeline, "CommitmentPlanAccountAssociationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the associations of the Cognitive Services commitment plan.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_ListAssociations</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CommitmentPlanAccountAssociationResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CommitmentPlanAccountAssociationResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateListAssociationsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _commitmentPlanAccountAssociationCommitmentPlansRestClient.CreateListAssociationsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new CommitmentPlanAccountAssociationResource(Client, CommitmentPlanAccountAssociationData.DeserializeCommitmentPlanAccountAssociationData(e)), _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics, Pipeline, "CommitmentPlanAccountAssociationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _commitmentPlanAccountAssociationCommitmentPlansRestClient.GetAssociationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        public virtual Response<bool> Exists(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.Exists");
            scope.Start();
            try
            {
                var response = _commitmentPlanAccountAssociationCommitmentPlansRestClient.GetAssociation(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        public virtual async Task<NullableResponse<CommitmentPlanAccountAssociationResource>> GetIfExistsAsync(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _commitmentPlanAccountAssociationCommitmentPlansRestClient.GetAssociationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<CommitmentPlanAccountAssociationResource>(response.GetRawResponse());
                return Response.FromValue(new CommitmentPlanAccountAssociationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/commitmentPlans/{commitmentPlanName}/accountAssociations/{commitmentPlanAssociationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CommitmentPlans_GetAssociation</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CommitmentPlanAccountAssociationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="commitmentPlanAssociationName"> The name of the commitment plan association with the Cognitive Services Account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="commitmentPlanAssociationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="commitmentPlanAssociationName"/> is null. </exception>
        public virtual NullableResponse<CommitmentPlanAccountAssociationResource> GetIfExists(string commitmentPlanAssociationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(commitmentPlanAssociationName, nameof(commitmentPlanAssociationName));

            using var scope = _commitmentPlanAccountAssociationCommitmentPlansClientDiagnostics.CreateScope("CommitmentPlanAccountAssociationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _commitmentPlanAccountAssociationCommitmentPlansRestClient.GetAssociation(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, commitmentPlanAssociationName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<CommitmentPlanAccountAssociationResource>(response.GetRawResponse());
                return Response.FromValue(new CommitmentPlanAccountAssociationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CommitmentPlanAccountAssociationResource> IEnumerable<CommitmentPlanAccountAssociationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CommitmentPlanAccountAssociationResource> IAsyncEnumerable<CommitmentPlanAccountAssociationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
