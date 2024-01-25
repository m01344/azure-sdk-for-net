// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense;
using Azure.ResourceManager.IotFirmwareDefense.Models;

namespace Azure.ResourceManager.IotFirmwareDefense.Samples
{
    public partial class Sample_FirmwareCollection
    {
        // Firmware_ListByWorkspace_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FirmwareListByWorkspaceMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_ListByWorkspace_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmware_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation and iterate over the result
            await foreach (FirmwareResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Firmware_ListByWorkspace_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_FirmwareListByWorkspaceMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_ListByWorkspace_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmware_ListByWorkspace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation and iterate over the result
            await foreach (FirmwareResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Firmware_Create_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FirmwareCreateMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Create_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmware_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            FirmwareData data = new FirmwareData()
            {
                FileName = "wresexxulcdsdd",
                Vendor = "vycmdhgtmepcptyoubztiuudpkcpd",
                Model = "f",
                Version = "s",
                Description = "uz",
                FileSize = 17,
                Status = Status.Pending,
                StatusMessages =
{
BinaryData.FromObjectAsJson(new Dictionary<string, object>()
{
["message"] = "ulvhmhokezathzzauiitu"})
},
            };
            ArmOperation<FirmwareResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firmwareName, data);
            FirmwareResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Firmware_Create_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_FirmwareCreateMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Create_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmware_Create" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            FirmwareData data = new FirmwareData();
            ArmOperation<FirmwareResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, firmwareName, data);
            FirmwareResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Firmware_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FirmwareGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmware_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            FirmwareResource result = await collection.GetAsync(firmwareName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Firmware_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FirmwareGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmware_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            bool result = await collection.ExistsAsync(firmwareName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Firmware_Get_MaximumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FirmwareGetMaximumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmware_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            NullableResponse<FirmwareResource> response = await collection.GetIfExistsAsync(firmwareName);
            FirmwareResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Firmware_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_FirmwareGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmware_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            FirmwareResource result = await collection.GetAsync(firmwareName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Firmware_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_FirmwareGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmware_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            bool result = await collection.ExistsAsync(firmwareName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Firmware_Get_MinimumSet_Gen
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_FirmwareGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2023-02-08-preview/examples/Firmware_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmware_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this FirmwareWorkspaceResource created on azure
            // for more information of creating FirmwareWorkspaceResource, please refer to the document of FirmwareWorkspaceResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            ResourceIdentifier firmwareWorkspaceResourceId = FirmwareWorkspaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName);
            FirmwareWorkspaceResource firmwareWorkspace = client.GetFirmwareWorkspaceResource(firmwareWorkspaceResourceId);

            // get the collection of this FirmwareResource
            FirmwareCollection collection = firmwareWorkspace.GetFirmwares();

            // invoke the operation
            string firmwareName = "umrkdttp";
            NullableResponse<FirmwareResource> response = await collection.GetIfExistsAsync(firmwareName);
            FirmwareResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirmwareData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
