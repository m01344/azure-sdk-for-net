// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Authorization
{
    /// <summary>
    /// A class representing a collection of <see cref="RoleEligibilityScheduleRequestResource" /> and their operations.
    /// Each <see cref="RoleEligibilityScheduleRequestResource" /> in the collection will belong to the same instance of <see cref="ArmResource" />.
    /// To get a <see cref="RoleEligibilityScheduleRequestCollection" /> instance call the GetRoleEligibilityScheduleRequests method from an instance of <see cref="ArmResource" />.
    /// </summary>
    public partial class RoleEligibilityScheduleRequestCollection : ArmCollection, IEnumerable<RoleEligibilityScheduleRequestResource>, IAsyncEnumerable<RoleEligibilityScheduleRequestResource>
    {
        private readonly ClientDiagnostics _roleEligibilityScheduleRequestClientDiagnostics;
        private readonly RoleEligibilityScheduleRequestsRestOperations _roleEligibilityScheduleRequestRestClient;

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleRequestCollection"/> class for mocking. </summary>
        protected RoleEligibilityScheduleRequestCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RoleEligibilityScheduleRequestCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RoleEligibilityScheduleRequestCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _roleEligibilityScheduleRequestClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Authorization", RoleEligibilityScheduleRequestResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RoleEligibilityScheduleRequestResource.ResourceType, out string roleEligibilityScheduleRequestApiVersion);
            _roleEligibilityScheduleRequestRestClient = new RoleEligibilityScheduleRequestsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, roleEligibilityScheduleRequestApiVersion);
        }

        /// <summary>
        /// Creates a role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleEligibilityScheduleRequestName"> The name of the role eligibility to create. It can be any valid GUID. </param>
        /// <param name="data"> Parameters for the role eligibility schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RoleEligibilityScheduleRequestResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string roleEligibilityScheduleRequestName, RoleEligibilityScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.CreateAsync(Id, roleEligibilityScheduleRequestName, data, cancellationToken).ConfigureAwait(false);
                var operation = new AuthorizationArmOperation<RoleEligibilityScheduleRequestResource>(Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response), response.GetRawResponse()));
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
        /// Creates a role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="roleEligibilityScheduleRequestName"> The name of the role eligibility to create. It can be any valid GUID. </param>
        /// <param name="data"> Parameters for the role eligibility schedule request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RoleEligibilityScheduleRequestResource> CreateOrUpdate(WaitUntil waitUntil, string roleEligibilityScheduleRequestName, RoleEligibilityScheduleRequestData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Create(Id, roleEligibilityScheduleRequestName, data, cancellationToken);
                var operation = new AuthorizationArmOperation<RoleEligibilityScheduleRequestResource>(Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response), response.GetRawResponse()));
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
        /// Get the specified role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        public virtual async Task<Response<RoleEligibilityScheduleRequestResource>> GetAsync(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.Get");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.GetAsync(Id, roleEligibilityScheduleRequestName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the specified role eligibility schedule request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        public virtual Response<RoleEligibilityScheduleRequestResource> Get(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.Get");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Get(Id, roleEligibilityScheduleRequestName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets role eligibility schedule requests for a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role eligibility schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role eligibility schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role eligibility schedule requests requested by the current user. Use $filter=asTarget() to return all role eligibility schedule requests created for the current user. Use $filter=asApprover() to return all role eligibility schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RoleEligibilityScheduleRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RoleEligibilityScheduleRequestResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleEligibilityScheduleRequestRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleEligibilityScheduleRequestRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RoleEligibilityScheduleRequestResource(Client, RoleEligibilityScheduleRequestData.DeserializeRoleEligibilityScheduleRequestData(e)), _roleEligibilityScheduleRequestClientDiagnostics, Pipeline, "RoleEligibilityScheduleRequestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets role eligibility schedule requests for a scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_ListForScope</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. Use $filter=atScope() to return all role eligibility schedule requests at or above the scope. Use $filter=principalId eq {id} to return all role eligibility schedule requests at, above or below the scope for the specified principal. Use $filter=asRequestor() to return all role eligibility schedule requests requested by the current user. Use $filter=asTarget() to return all role eligibility schedule requests created for the current user. Use $filter=asApprover() to return all role eligibility schedule requests where the current user is an approver. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RoleEligibilityScheduleRequestResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RoleEligibilityScheduleRequestResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _roleEligibilityScheduleRequestRestClient.CreateListForScopeRequest(Id, filter);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _roleEligibilityScheduleRequestRestClient.CreateListForScopeNextPageRequest(nextLink, Id, filter);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RoleEligibilityScheduleRequestResource(Client, RoleEligibilityScheduleRequestData.DeserializeRoleEligibilityScheduleRequestData(e)), _roleEligibilityScheduleRequestClientDiagnostics, Pipeline, "RoleEligibilityScheduleRequestCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.GetAsync(Id, roleEligibilityScheduleRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        public virtual Response<bool> Exists(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.Exists");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Get(Id, roleEligibilityScheduleRequestName, cancellationToken: cancellationToken);
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        public virtual async Task<NullableResponse<RoleEligibilityScheduleRequestResource>> GetIfExistsAsync(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _roleEligibilityScheduleRequestRestClient.GetAsync(Id, roleEligibilityScheduleRequestName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RoleEligibilityScheduleRequestResource>(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/{scope}/providers/Microsoft.Authorization/roleEligibilityScheduleRequests/{roleEligibilityScheduleRequestName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RoleEligibilityScheduleRequests_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="roleEligibilityScheduleRequestName"> The name (guid) of the role eligibility schedule request to get. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="roleEligibilityScheduleRequestName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="roleEligibilityScheduleRequestName"/> is null. </exception>
        public virtual NullableResponse<RoleEligibilityScheduleRequestResource> GetIfExists(string roleEligibilityScheduleRequestName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(roleEligibilityScheduleRequestName, nameof(roleEligibilityScheduleRequestName));

            using var scope = _roleEligibilityScheduleRequestClientDiagnostics.CreateScope("RoleEligibilityScheduleRequestCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _roleEligibilityScheduleRequestRestClient.Get(Id, roleEligibilityScheduleRequestName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RoleEligibilityScheduleRequestResource>(response.GetRawResponse());
                return Response.FromValue(new RoleEligibilityScheduleRequestResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RoleEligibilityScheduleRequestResource> IEnumerable<RoleEligibilityScheduleRequestResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RoleEligibilityScheduleRequestResource> IAsyncEnumerable<RoleEligibilityScheduleRequestResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
