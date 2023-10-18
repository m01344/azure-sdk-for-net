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
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Samples
{
    public partial class Sample_SiteDetectorCollection
    {
        // Get App Detector Responses
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAppDetectorResponses()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_ListSiteDetectorResponses.json
            // this example is just showing the usage of "Diagnostics_ListSiteDetectorResponses" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation and iterate over the result
            await foreach (SiteDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get App Slot Detector Responses
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_GetAppSlotDetectorResponses()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_ListSiteDetectorResponsesSlot.json
            // this example is just showing the usage of "Diagnostics_ListSiteDetectorResponses" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation and iterate over the result
            await foreach (SiteDetectorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get App Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            SiteDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get App Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAppDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDetectorResponse.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            NullableResponse<SiteDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            SiteDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Get App Slot Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            SiteDetectorResource result = await collection.GetAsync(detectorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AppServiceDetectorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get App Slot Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            bool result = await collection.ExistsAsync(detectorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get App Slot Detector Response
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAppSlotDetectorResponse()
        {
            // Generated from example definition: specification/web/resource-manager/Microsoft.Web/stable/2021-02-01/examples/Diagnostics_GetSiteDetectorResponseSlot.json
            // this example is just showing the usage of "Diagnostics_GetSiteDetectorResponse" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this WebSiteResource created on azure
            // for more information of creating WebSiteResource, please refer to the document of WebSiteResource
            string subscriptionId = "34adfa4f-cedf-4dc0-ba29-b6d1a69ab345";
            string resourceGroupName = "Sample-WestUSResourceGroup";
            string siteName = "SampleApp";
            ResourceIdentifier webSiteResourceId = WebSiteResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, siteName);
            WebSiteResource webSite = client.GetWebSiteResource(webSiteResourceId);

            // get the collection of this SiteDetectorResource
            SiteDetectorCollection collection = webSite.GetSiteDetectors();

            // invoke the operation
            string detectorName = "runtimeavailability";
            NullableResponse<SiteDetectorResource> response = await collection.GetIfExistsAsync(detectorName);
            SiteDetectorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AppServiceDetectorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
