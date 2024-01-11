// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.HealthBot;

namespace Azure.ResourceManager.HealthBot.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableHealthBotSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _healthBotBotsClientDiagnostics;
        private BotsRestOperations _healthBotBotsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableHealthBotSubscriptionResource"/> class for mocking. </summary>
        protected MockableHealthBotSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableHealthBotSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableHealthBotSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics HealthBotBotsClientDiagnostics => _healthBotBotsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HealthBot", HealthBotResource.ResourceType.Namespace, Diagnostics);
        private BotsRestOperations HealthBotBotsRestClient => _healthBotBotsRestClient ??= new BotsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HealthBotResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-24</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthBotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HealthBotResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HealthBotResource> GetHealthBotsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HealthBotBotsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HealthBotBotsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HealthBotResource(Client, HealthBotData.DeserializeHealthBotData(e)), HealthBotBotsClientDiagnostics, Pipeline, "MockableHealthBotSubscriptionResource.GetHealthBots", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HealthBot/healthBots</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-08-24</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="HealthBotResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HealthBotResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HealthBotResource> GetHealthBots(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HealthBotBotsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HealthBotBotsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HealthBotResource(Client, HealthBotData.DeserializeHealthBotData(e)), HealthBotBotsClientDiagnostics, Pipeline, "MockableHealthBotSubscriptionResource.GetHealthBots", "value", "nextLink", cancellationToken);
        }
    }
}
