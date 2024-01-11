// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppPlatform.Models;

namespace Azure.ResourceManager.AppPlatform
{
    /// <summary>
    /// A Class representing an AppPlatformBuildService along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="AppPlatformBuildServiceResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetAppPlatformBuildServiceResource method.
    /// Otherwise you can get one from its parent resource <see cref="AppPlatformServiceResource"/> using the GetAppPlatformBuildService method.
    /// </summary>
    public partial class AppPlatformBuildServiceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="AppPlatformBuildServiceResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="serviceName"> The serviceName. </param>
        /// <param name="buildServiceName"> The buildServiceName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string buildServiceName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _appPlatformBuildServiceBuildServiceClientDiagnostics;
        private readonly BuildServiceRestOperations _appPlatformBuildServiceBuildServiceRestClient;
        private readonly AppPlatformBuildServiceData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppPlatform/Spring/buildServices";

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceResource"/> class for mocking. </summary>
        protected AppPlatformBuildServiceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal AppPlatformBuildServiceResource(ArmClient client, AppPlatformBuildServiceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="AppPlatformBuildServiceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AppPlatformBuildServiceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _appPlatformBuildServiceBuildServiceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppPlatform", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string appPlatformBuildServiceBuildServiceApiVersion);
            _appPlatformBuildServiceBuildServiceRestClient = new BuildServiceRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, appPlatformBuildServiceBuildServiceApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AppPlatformBuildServiceData Data
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

        /// <summary> Gets a collection of AppPlatformBuildResources in the AppPlatformBuildService. </summary>
        /// <returns> An object representing collection of AppPlatformBuildResources and their operations over a AppPlatformBuildResource. </returns>
        public virtual AppPlatformBuildCollection GetAppPlatformBuilds()
        {
            return GetCachedClient(client => new AppPlatformBuildCollection(client, Id));
        }

        /// <summary>
        /// Get a KPack build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildName"> The name of the build resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="buildName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="buildName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppPlatformBuildResource>> GetAppPlatformBuildAsync(string buildName, CancellationToken cancellationToken = default)
        {
            return await GetAppPlatformBuilds().GetAsync(buildName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a KPack build.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builds/{buildName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuild</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildName"> The name of the build resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="buildName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="buildName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppPlatformBuildResource> GetAppPlatformBuild(string buildName, CancellationToken cancellationToken = default)
        {
            return GetAppPlatformBuilds().Get(buildName, cancellationToken);
        }

        /// <summary> Gets a collection of AppPlatformSupportedBuildpackResources in the AppPlatformBuildService. </summary>
        /// <returns> An object representing collection of AppPlatformSupportedBuildpackResources and their operations over a AppPlatformSupportedBuildpackResource. </returns>
        public virtual AppPlatformSupportedBuildpackCollection GetAppPlatformSupportedBuildpacks()
        {
            return GetCachedClient(client => new AppPlatformSupportedBuildpackCollection(client, Id));
        }

        /// <summary>
        /// Get the supported buildpack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks/{buildpackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedBuildpack</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformSupportedBuildpackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackName"> The name of the buildpack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="buildpackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppPlatformSupportedBuildpackResource>> GetAppPlatformSupportedBuildpackAsync(string buildpackName, CancellationToken cancellationToken = default)
        {
            return await GetAppPlatformSupportedBuildpacks().GetAsync(buildpackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the supported buildpack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedBuildpacks/{buildpackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedBuildpack</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformSupportedBuildpackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="buildpackName"> The name of the buildpack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="buildpackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="buildpackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppPlatformSupportedBuildpackResource> GetAppPlatformSupportedBuildpack(string buildpackName, CancellationToken cancellationToken = default)
        {
            return GetAppPlatformSupportedBuildpacks().Get(buildpackName, cancellationToken);
        }

        /// <summary> Gets a collection of AppPlatformSupportedStackResources in the AppPlatformBuildService. </summary>
        /// <returns> An object representing collection of AppPlatformSupportedStackResources and their operations over a AppPlatformSupportedStackResource. </returns>
        public virtual AppPlatformSupportedStackCollection GetAppPlatformSupportedStacks()
        {
            return GetCachedClient(client => new AppPlatformSupportedStackCollection(client, Id));
        }

        /// <summary>
        /// Get the supported stack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformSupportedStackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppPlatformSupportedStackResource>> GetAppPlatformSupportedStackAsync(string stackName, CancellationToken cancellationToken = default)
        {
            return await GetAppPlatformSupportedStacks().GetAsync(stackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the supported stack resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/supportedStacks/{stackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetSupportedStack</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformSupportedStackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="stackName"> The name of the stack resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="stackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="stackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppPlatformSupportedStackResource> GetAppPlatformSupportedStack(string stackName, CancellationToken cancellationToken = default)
        {
            return GetAppPlatformSupportedStacks().Get(stackName, cancellationToken);
        }

        /// <summary> Gets a collection of AppPlatformBuilderResources in the AppPlatformBuildService. </summary>
        /// <returns> An object representing collection of AppPlatformBuilderResources and their operations over a AppPlatformBuilderResource. </returns>
        public virtual AppPlatformBuilderCollection GetAppPlatformBuilders()
        {
            return GetCachedClient(client => new AppPlatformBuilderCollection(client, Id));
        }

        /// <summary>
        /// Get a KPack builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuilderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppPlatformBuilderResource>> GetAppPlatformBuilderAsync(string builderName, CancellationToken cancellationToken = default)
        {
            return await GetAppPlatformBuilders().GetAsync(builderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a KPack builder.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/builders/{builderName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceBuilder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuilderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="builderName"> The name of the builder resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="builderName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="builderName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppPlatformBuilderResource> GetAppPlatformBuilder(string builderName, CancellationToken cancellationToken = default)
        {
            return GetAppPlatformBuilders().Get(builderName, cancellationToken);
        }

        /// <summary> Gets a collection of AppPlatformBuildServiceAgentPoolResources in the AppPlatformBuildService. </summary>
        /// <returns> An object representing collection of AppPlatformBuildServiceAgentPoolResources and their operations over a AppPlatformBuildServiceAgentPoolResource. </returns>
        public virtual AppPlatformBuildServiceAgentPoolCollection GetAppPlatformBuildServiceAgentPools()
        {
            return GetCachedClient(client => new AppPlatformBuildServiceAgentPoolCollection(client, Id));
        }

        /// <summary>
        /// Get build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AppPlatformBuildServiceAgentPoolResource>> GetAppPlatformBuildServiceAgentPoolAsync(string agentPoolName, CancellationToken cancellationToken = default)
        {
            return await GetAppPlatformBuildServiceAgentPools().GetAsync(agentPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get build service agent pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/agentPools/{agentPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildServiceAgentPool_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceAgentPoolResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="agentPoolName"> The name of the build service agent pool resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="agentPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="agentPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AppPlatformBuildServiceAgentPoolResource> GetAppPlatformBuildServiceAgentPool(string agentPoolName, CancellationToken cancellationToken = default)
        {
            return GetAppPlatformBuildServiceAgentPools().Get(agentPoolName, cancellationToken);
        }

        /// <summary>
        /// Get a build service resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformBuildServiceResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceResource.Get");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceBuildServiceRestClient.GetBuildServiceAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a build service resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetBuildService</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformBuildServiceResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceResource.Get");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceBuildServiceRestClient.GetBuildService(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppPlatformBuildServiceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an resource upload URL for build service, which may be artifacts or source archive.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/getResourceUploadUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetResourceUploadUrl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AppPlatformResourceUploadResult>> GetResourceUploadUriAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceResource.GetResourceUploadUri");
            scope.Start();
            try
            {
                var response = await _appPlatformBuildServiceBuildServiceRestClient.GetResourceUploadUriAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an resource upload URL for build service, which may be artifacts or source archive.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AppPlatform/Spring/{serviceName}/buildServices/{buildServiceName}/getResourceUploadUrl</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BuildService_GetResourceUploadUrl</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-12-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AppPlatformBuildServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AppPlatformResourceUploadResult> GetResourceUploadUri(CancellationToken cancellationToken = default)
        {
            using var scope = _appPlatformBuildServiceBuildServiceClientDiagnostics.CreateScope("AppPlatformBuildServiceResource.GetResourceUploadUri");
            scope.Start();
            try
            {
                var response = _appPlatformBuildServiceBuildServiceRestClient.GetResourceUploadUri(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
