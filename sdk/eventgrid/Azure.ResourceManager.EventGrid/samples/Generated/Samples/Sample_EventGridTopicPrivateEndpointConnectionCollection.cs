// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.EventGrid;
using Azure.ResourceManager.EventGrid.Models;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_EventGridTopicPrivateEndpointConnectionCollection
    {
        // PrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // get the collection of this EventGridTopicPrivateEndpointConnectionResource
            EventGridTopicPrivateEndpointConnectionCollection collection = eventGridTopic.GetEventGridTopicPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            EventGridTopicPrivateEndpointConnectionResource result = await collection.GetAsync(privateEndpointConnectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // get the collection of this EventGridTopicPrivateEndpointConnectionResource
            EventGridTopicPrivateEndpointConnectionCollection collection = eventGridTopic.GetEventGridTopicPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            bool result = await collection.ExistsAsync(privateEndpointConnectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // PrivateEndpointConnections_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_PrivateEndpointConnectionsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateEndpointConnections_Get.json
            // this example is just showing the usage of "PrivateEndpointConnections_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // get the collection of this EventGridTopicPrivateEndpointConnectionResource
            EventGridTopicPrivateEndpointConnectionCollection collection = eventGridTopic.GetEventGridTopicPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            NullableResponse<EventGridTopicPrivateEndpointConnectionResource> response = await collection.GetIfExistsAsync(privateEndpointConnectionName);
            EventGridTopicPrivateEndpointConnectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridPrivateEndpointConnectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // PrivateEndpointConnections_Update
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PrivateEndpointConnectionsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateEndpointConnections_Update.json
            // this example is just showing the usage of "PrivateEndpointConnections_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // get the collection of this EventGridTopicPrivateEndpointConnectionResource
            EventGridTopicPrivateEndpointConnectionCollection collection = eventGridTopic.GetEventGridTopicPrivateEndpointConnections();

            // invoke the operation
            string privateEndpointConnectionName = "BMTPE5.8A30D251-4C61-489D-A1AA-B37C4A329B8B";
            EventGridPrivateEndpointConnectionData data = new EventGridPrivateEndpointConnectionData()
            {
                ConnectionState = new EventGridPrivateEndpointConnectionState()
                {
                    Status = EventGridPrivateEndpointPersistedConnectionStatus.Approved,
                    Description = "approving connection",
                    ActionsRequired = "None",
                },
            };
            ArmOperation<EventGridTopicPrivateEndpointConnectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, privateEndpointConnectionName, data);
            EventGridTopicPrivateEndpointConnectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            EventGridPrivateEndpointConnectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateEndpointConnections_ListByResource
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_PrivateEndpointConnectionsListByResource()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2023-12-15-preview/examples/PrivateEndpointConnections_ListByResource.json
            // this example is just showing the usage of "PrivateEndpointConnections_ListByResource" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridTopicResource created on azure
            // for more information of creating EventGridTopicResource, please refer to the document of EventGridTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string parentName = "exampletopic1";
            ResourceIdentifier eventGridTopicResourceId = EventGridTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, parentName);
            EventGridTopicResource eventGridTopic = client.GetEventGridTopicResource(eventGridTopicResourceId);

            // get the collection of this EventGridTopicPrivateEndpointConnectionResource
            EventGridTopicPrivateEndpointConnectionCollection collection = eventGridTopic.GetEventGridTopicPrivateEndpointConnections();

            // invoke the operation and iterate over the result
            await foreach (EventGridTopicPrivateEndpointConnectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                EventGridPrivateEndpointConnectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
