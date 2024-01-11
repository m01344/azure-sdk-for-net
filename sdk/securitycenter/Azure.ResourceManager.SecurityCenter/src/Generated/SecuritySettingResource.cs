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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A Class representing a SecuritySetting along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SecuritySettingResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSecuritySettingResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetSecuritySetting method.
    /// </summary>
    public partial class SecuritySettingResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SecuritySettingResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="settingName"> The settingName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, SecuritySettingName settingName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _securitySettingSettingsClientDiagnostics;
        private readonly SettingsRestOperations _securitySettingSettingsRestClient;
        private readonly SecuritySettingData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Security/settings";

        /// <summary> Initializes a new instance of the <see cref="SecuritySettingResource"/> class for mocking. </summary>
        protected SecuritySettingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecuritySettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SecuritySettingResource(ArmClient client, SecuritySettingData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SecuritySettingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SecuritySettingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securitySettingSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string securitySettingSettingsApiVersion);
            _securitySettingSettingsRestClient = new SettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securitySettingSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SecuritySettingData Data
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
        /// Settings of different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecuritySettingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingResource.Get");
            scope.Start();
            try
            {
                var response = await _securitySettingSettingsRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings of different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecuritySettingResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingResource.Get");
            scope.Start();
            try
            {
                var response = _securitySettingSettingsRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// updating settings about different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecuritySettingResource>> UpdateAsync(WaitUntil waitUntil, SecuritySettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingResource.Update");
            scope.Start();
            try
            {
                var response = await _securitySettingSettingsRestClient.UpdateAsync(Id.SubscriptionId, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecuritySettingResource>(Response.FromValue(new SecuritySettingResource(Client, response), response.GetRawResponse()));
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
        /// updating settings about different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Update</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-05-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SecuritySettingResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecuritySettingResource> Update(WaitUntil waitUntil, SecuritySettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingResource.Update");
            scope.Start();
            try
            {
                var response = _securitySettingSettingsRestClient.Update(Id.SubscriptionId, Id.Name, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecuritySettingResource>(Response.FromValue(new SecuritySettingResource(Client, response), response.GetRawResponse()));
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
    }
}
