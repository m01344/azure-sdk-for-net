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
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Samples
{
    public partial class Sample_DigitalTwinsPrivateLinkResourceCollection
    {
        // List private link resources for given Digital Twin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListPrivateLinkResourcesForGivenDigitalTwin()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateLinkResourcesList_example.json
            // this example is just showing the usage of "PrivateLinkResources_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateLinkResource
            DigitalTwinsPrivateLinkResourceCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateLinkResources();

            // invoke the operation and iterate over the result
            await foreach (DigitalTwinsPrivateLinkResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DigitalTwinsPrivateLinkResourceData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get the specified private link resource for the given Digital Twin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetTheSpecifiedPrivateLinkResourceForTheGivenDigitalTwin()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateLinkResourcesByGroupId_example.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateLinkResource
            DigitalTwinsPrivateLinkResourceCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateLinkResources();

            // invoke the operation
            string resourceId = "subResource";
            DigitalTwinsPrivateLinkResource result = await collection.GetAsync(resourceId);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DigitalTwinsPrivateLinkResourceData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get the specified private link resource for the given Digital Twin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetTheSpecifiedPrivateLinkResourceForTheGivenDigitalTwin()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateLinkResourcesByGroupId_example.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateLinkResource
            DigitalTwinsPrivateLinkResourceCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateLinkResources();

            // invoke the operation
            string resourceId = "subResource";
            bool result = await collection.ExistsAsync(resourceId);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get the specified private link resource for the given Digital Twin
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetTheSpecifiedPrivateLinkResourceForTheGivenDigitalTwin()
        {
            // Generated from example definition: specification/digitaltwins/resource-manager/Microsoft.DigitalTwins/stable/2023-01-31/examples/PrivateLinkResourcesByGroupId_example.json
            // this example is just showing the usage of "PrivateLinkResources_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this DigitalTwinsDescriptionResource created on azure
            // for more information of creating DigitalTwinsDescriptionResource, please refer to the document of DigitalTwinsDescriptionResource
            string subscriptionId = "50016170-c839-41ba-a724-51e9df440b9e";
            string resourceGroupName = "resRg";
            string resourceName = "myDigitalTwinsService";
            ResourceIdentifier digitalTwinsDescriptionResourceId = DigitalTwinsDescriptionResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, resourceName);
            DigitalTwinsDescriptionResource digitalTwinsDescription = client.GetDigitalTwinsDescriptionResource(digitalTwinsDescriptionResourceId);

            // get the collection of this DigitalTwinsPrivateLinkResource
            DigitalTwinsPrivateLinkResourceCollection collection = digitalTwinsDescription.GetDigitalTwinsPrivateLinkResources();

            // invoke the operation
            string resourceId = "subResource";
            NullableResponse<DigitalTwinsPrivateLinkResource> response = await collection.GetIfExistsAsync(resourceId);
            DigitalTwinsPrivateLinkResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DigitalTwinsPrivateLinkResourceData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
