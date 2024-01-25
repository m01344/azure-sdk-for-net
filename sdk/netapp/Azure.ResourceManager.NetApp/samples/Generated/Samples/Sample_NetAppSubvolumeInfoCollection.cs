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
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Samples
{
    public partial class Sample_NetAppSubvolumeInfoCollection
    {
        // Subvolumes_List
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_SubvolumesList()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2023-05-01/examples/Subvolumes_List.json
            // this example is just showing the usage of "Subvolumes_ListByVolume" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppSubvolumeInfoResource
            NetAppSubvolumeInfoCollection collection = netAppVolume.GetNetAppSubvolumeInfos();

            // invoke the operation and iterate over the result
            await foreach (NetAppSubvolumeInfoResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppSubvolumeInfoData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Subvolumes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SubvolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2023-05-01/examples/Subvolumes_Get.json
            // this example is just showing the usage of "Subvolumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppSubvolumeInfoResource
            NetAppSubvolumeInfoCollection collection = netAppVolume.GetNetAppSubvolumeInfos();

            // invoke the operation
            string subvolumeName = "subvolume1";
            NetAppSubvolumeInfoResource result = await collection.GetAsync(subvolumeName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppSubvolumeInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Subvolumes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_SubvolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2023-05-01/examples/Subvolumes_Get.json
            // this example is just showing the usage of "Subvolumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppSubvolumeInfoResource
            NetAppSubvolumeInfoCollection collection = netAppVolume.GetNetAppSubvolumeInfos();

            // invoke the operation
            string subvolumeName = "subvolume1";
            bool result = await collection.ExistsAsync(subvolumeName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Subvolumes_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_SubvolumesGet()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2023-05-01/examples/Subvolumes_Get.json
            // this example is just showing the usage of "Subvolumes_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppSubvolumeInfoResource
            NetAppSubvolumeInfoCollection collection = netAppVolume.GetNetAppSubvolumeInfos();

            // invoke the operation
            string subvolumeName = "subvolume1";
            NullableResponse<NetAppSubvolumeInfoResource> response = await collection.GetIfExistsAsync(subvolumeName);
            NetAppSubvolumeInfoResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetAppSubvolumeInfoData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Subvolumes_Create
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_SubvolumesCreate()
        {
            // Generated from example definition: specification/netapp/resource-manager/Microsoft.NetApp/stable/2023-05-01/examples/Subvolumes_Create.json
            // this example is just showing the usage of "Subvolumes_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetAppVolumeResource created on azure
            // for more information of creating NetAppVolumeResource, please refer to the document of NetAppVolumeResource
            string subscriptionId = "D633CC2E-722B-4AE1-B636-BBD9E4C60ED9";
            string resourceGroupName = "myRG";
            string accountName = "account1";
            string poolName = "pool1";
            string volumeName = "volume1";
            ResourceIdentifier netAppVolumeResourceId = NetAppVolumeResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, poolName, volumeName);
            NetAppVolumeResource netAppVolume = client.GetNetAppVolumeResource(netAppVolumeResourceId);

            // get the collection of this NetAppSubvolumeInfoResource
            NetAppSubvolumeInfoCollection collection = netAppVolume.GetNetAppSubvolumeInfos();

            // invoke the operation
            string subvolumeName = "subvolume1";
            NetAppSubvolumeInfoData info = new NetAppSubvolumeInfoData()
            {
                Path = "/subvolumePath",
            };
            ArmOperation<NetAppSubvolumeInfoResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, subvolumeName, info);
            NetAppSubvolumeInfoResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetAppSubvolumeInfoData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
