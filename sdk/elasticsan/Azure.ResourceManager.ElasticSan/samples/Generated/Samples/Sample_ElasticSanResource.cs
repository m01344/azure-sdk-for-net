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
using Azure.ResourceManager.ElasticSan;
using Azure.ResourceManager.ElasticSan.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ElasticSan.Samples
{
    public partial class Sample_ElasticSanResource
    {
        // ElasticSans_ListBySubscription_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetElasticSans_ElasticSansListBySubscriptionMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_ListBySubscription_MaximumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subscriptionid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ElasticSanResource item in subscriptionResource.GetElasticSansAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ElasticSans_ListBySubscription_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetElasticSans_ElasticSansListBySubscriptionMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_ListBySubscription_MinimumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_ListBySubscription" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subscriptionid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (ElasticSanResource item in subscriptionResource.GetElasticSansAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                ElasticSanData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // ElasticSans_Update_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ElasticSansUpdateMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation
            ElasticSanPatch patch = new ElasticSanPatch()
            {
                Tags =
{
["key1931"] = "yhjwkgmrrwrcoxblgwgzjqusch",
},
                BaseSizeTiB = 13,
                ExtendedCapacitySizeTiB = 29,
                PublicNetworkAccess = ElasticSanPublicNetworkAccess.Enabled,
            };
            ArmOperation<ElasticSanResource> lro = await elasticSan.UpdateAsync(WaitUntil.Completed, patch);
            ElasticSanResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ElasticSans_Update_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ElasticSansUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation
            ElasticSanPatch patch = new ElasticSanPatch();
            ArmOperation<ElasticSanResource> lro = await elasticSan.UpdateAsync(WaitUntil.Completed, patch);
            ElasticSanResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ElasticSans_Delete_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ElasticSansDeleteMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation
            await elasticSan.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ElasticSans_Delete_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ElasticSansDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation
            await elasticSan.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // ElasticSans_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ElasticSansGetMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation
            ElasticSanResource result = await elasticSan.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ElasticSans_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ElasticSansGetMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/ElasticSans_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "ElasticSans_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation
            ElasticSanResource result = await elasticSan.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ElasticSanData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // PrivateLinkResources_ListByElasticSan_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkResources_PrivateLinkResourcesListByElasticSanMaximumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/PrivateLinkResources_ListByElasticSan_MaximumSet_Gen.json
            // this example is just showing the usage of "PrivateLinkResources_ListByElasticSan" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation and iterate over the result
            await foreach (ElasticSanPrivateLinkResource item in elasticSan.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }

        // PrivateLinkResources_ListByElasticSan_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetPrivateLinkResources_PrivateLinkResourcesListByElasticSanMinimumSetGen()
        {
            // Generated from example definition: specification/elasticsan/resource-manager/Microsoft.ElasticSan/stable/2023-01-01/examples/PrivateLinkResources_ListByElasticSan_MinimumSet_Gen.json
            // this example is just showing the usage of "PrivateLinkResources_ListByElasticSan" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ElasticSanResource created on azure
            // for more information of creating ElasticSanResource, please refer to the document of ElasticSanResource
            string subscriptionId = "subscriptionid";
            string resourceGroupName = "resourcegroupname";
            string elasticSanName = "elasticsanname";
            ResourceIdentifier elasticSanResourceId = ElasticSanResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, elasticSanName);
            ElasticSanResource elasticSan = client.GetElasticSanResource(elasticSanResourceId);

            // invoke the operation and iterate over the result
            await foreach (ElasticSanPrivateLinkResource item in elasticSan.GetPrivateLinkResourcesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
