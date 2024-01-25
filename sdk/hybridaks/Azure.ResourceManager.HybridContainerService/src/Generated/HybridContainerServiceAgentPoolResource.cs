// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.HybridContainerService
{
    /// <summary>
    /// A Class representing a HybridContainerServiceAgentPool along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="HybridContainerServiceAgentPoolResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetHybridContainerServiceAgentPoolResource method.
    /// Otherwise you can get one from its parent resource <see cref="ProvisionedClusterResource"/> using the GetHybridContainerServiceAgentPool method.
    /// </summary>
    public partial class HybridContainerServiceAgentPoolResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="HybridContainerServiceAgentPoolResource"/> instance. </summary>
        /// <param name="connectedClusterResourceUri"> The connectedClusterResourceUri. </param>
        /// <param name="agentPoolName"> The agentPoolName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string connectedClusterResourceUri, string agentPoolName)
        {
            var resourceId = $"{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _hybridContainerServiceAgentPoolagentPoolClientDiagnostics;
        private readonly AgentPoolRestOperations _hybridContainerServiceAgentPoolagentPoolRestClient;
        private readonly HybridContainerServiceAgentPoolData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.HybridContainerService/provisionedClusterInstances/agentPools";

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceAgentPoolResource"/> class for mocking. </summary>
        protected HybridContainerServiceAgentPoolResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceAgentPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal HybridContainerServiceAgentPoolResource(ArmClient client, HybridContainerServiceAgentPoolData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="HybridContainerServiceAgentPoolResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HybridContainerServiceAgentPoolResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridContainerServiceAgentPoolagentPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridContainerService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string hybridContainerServiceAgentPoolagentPoolApiVersion);
            _hybridContainerServiceAgentPoolagentPoolRestClient = new AgentPoolRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridContainerServiceAgentPoolagentPoolApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual HybridContainerServiceAgentPoolData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the specified agent pool in the provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HybridContainerServiceAgentPoolResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.Get");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.Parent.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified agent pool in the provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HybridContainerServiceAgentPoolResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.Get");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.Parent.Parent, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified agent pool in the provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.Delete");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.DeleteAsync(Id.Parent.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation(_hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, _hybridContainerServiceAgentPoolagentPoolRestClient.CreateDeleteRequest(Id.Parent.Parent, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes the specified agent pool in the provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.Delete");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.Delete(Id.Parent.Parent, Id.Name, cancellationToken);
                var operation = new HybridContainerServiceArmOperation(_hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, _hybridContainerServiceAgentPoolagentPoolRestClient.CreateDeleteRequest(Id.Parent.Parent, Id.Name).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the agent pool in the provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Agent Pool resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridContainerServiceAgentPoolResource>> UpdateAsync(WaitUntil waitUntil, HybridContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.Update");
            scope.Start();
            try
            {
                var response = await _hybridContainerServiceAgentPoolagentPoolRestClient.CreateOrUpdateAsync(Id.Parent.Parent, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceAgentPoolResource>(new HybridContainerServiceAgentPoolOperationSource(Client), _hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, _hybridContainerServiceAgentPoolagentPoolRestClient.CreateCreateOrUpdateRequest(Id.Parent.Parent, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the agent pool in the provisioned cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Agent Pool resource definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridContainerServiceAgentPoolResource> Update(WaitUntil waitUntil, HybridContainerServiceAgentPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.Update");
            scope.Start();
            try
            {
                var response = _hybridContainerServiceAgentPoolagentPoolRestClient.CreateOrUpdate(Id.Parent.Parent, Id.Name, data, cancellationToken);
                var operation = new HybridContainerServiceArmOperation<HybridContainerServiceAgentPoolResource>(new HybridContainerServiceAgentPoolOperationSource(Client), _hybridContainerServiceAgentPoolagentPoolClientDiagnostics, Pipeline, _hybridContainerServiceAgentPoolagentPoolRestClient.CreateCreateOrUpdateRequest(Id.Parent.Parent, Id.Name, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<HybridContainerServiceAgentPoolResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.AddTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues[key] = value;
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.Parent.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags[key] = value;
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<HybridContainerServiceAgentPoolResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.AddTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues[key] = value;
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.Parent.Parent, Id.Name, cancellationToken);
                    return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags[key] = value;
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<HybridContainerServiceAgentPoolResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.SetTags");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    await GetTagResource().DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.Parent.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<HybridContainerServiceAgentPoolResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.SetTags");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    GetTagResource().Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.ReplaceWith(tags);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.Parent.Parent, Id.Name, cancellationToken);
                    return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.ReplaceWith(tags);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<HybridContainerServiceAgentPoolResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.RemoveTag");
            scope.Start();
            try
            {
                if (await CanUseTagResourceAsync(cancellationToken: cancellationToken).ConfigureAwait(false))
                {
                    var originalTags = await GetTagResource().GetAsync(cancellationToken).ConfigureAwait(false);
                    originalTags.Value.Data.TagValues.Remove(key);
                    await GetTagResource().CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                    var originalResponse = await _hybridContainerServiceAgentPoolagentPoolRestClient.GetAsync(Id.Parent.Parent, Id.Name, cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = (await GetAsync(cancellationToken: cancellationToken).ConfigureAwait(false)).Value.Data;
                    current.Tags.Remove(key);
                    var result = await UpdateAsync(WaitUntil.Completed, current, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{connectedClusterResourceUri}/providers/Microsoft.HybridContainerService/provisionedClusterInstances/default/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>agentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HybridContainerServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<HybridContainerServiceAgentPoolResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _hybridContainerServiceAgentPoolagentPoolClientDiagnostics.CreateScope("HybridContainerServiceAgentPoolResource.RemoveTag");
            scope.Start();
            try
            {
                if (CanUseTagResource(cancellationToken: cancellationToken))
                {
                    var originalTags = GetTagResource().Get(cancellationToken);
                    originalTags.Value.Data.TagValues.Remove(key);
                    GetTagResource().CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                    var originalResponse = _hybridContainerServiceAgentPoolagentPoolRestClient.Get(Id.Parent.Parent, Id.Name, cancellationToken);
                    return Response.FromValue(new HybridContainerServiceAgentPoolResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
                }
                else
                {
                    var current = Get(cancellationToken: cancellationToken).Value.Data;
                    current.Tags.Remove(key);
                    var result = Update(WaitUntil.Completed, current, cancellationToken: cancellationToken);
                    return Response.FromValue(result.Value, result.GetRawResponse());
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
