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
using Azure.ResourceManager.Automanage;
using Azure.ResourceManager.Automanage.Models;

namespace Azure.ResourceManager.Automanage.Samples
{
    public partial class Sample_AutomanageVmConfigurationProfileAssignmentCollection
    {
        // Create or update configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateOrUpdateConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/createOrUpdateConfigurationProfileAssignment.json
            // this example is just showing the usage of "ConfigurationProfileAssignments_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            AutomanageVmConfigurationProfileAssignmentCollection collection = client.GetAutomanageVmConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            AutomanageConfigurationProfileAssignmentData data = new AutomanageConfigurationProfileAssignmentData()
            {
                Properties = new AutomanageConfigurationProfileAssignmentProperties()
                {
                    ConfigurationProfile = new ResourceIdentifier("/providers/Microsoft.Automanage/bestPractices/AzureBestPracticesProduction"),
                },
            };
            ArmOperation<AutomanageVmConfigurationProfileAssignmentResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, configurationProfileAssignmentName, data);
            AutomanageVmConfigurationProfileAssignmentResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileAssignment.json
            // this example is just showing the usage of "ConfigurationProfileAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            AutomanageVmConfigurationProfileAssignmentCollection collection = client.GetAutomanageVmConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            AutomanageVmConfigurationProfileAssignmentResource result = await collection.GetAsync(configurationProfileAssignmentName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileAssignment.json
            // this example is just showing the usage of "ConfigurationProfileAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            AutomanageVmConfigurationProfileAssignmentCollection collection = client.GetAutomanageVmConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            bool result = await collection.ExistsAsync(configurationProfileAssignmentName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a configuration profile assignment
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetAConfigurationProfileAssignment()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/getConfigurationProfileAssignment.json
            // this example is just showing the usage of "ConfigurationProfileAssignments_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            AutomanageVmConfigurationProfileAssignmentCollection collection = client.GetAutomanageVmConfigurationProfileAssignments(scopeId);

            // invoke the operation
            string configurationProfileAssignmentName = "default";
            NullableResponse<AutomanageVmConfigurationProfileAssignmentResource> response = await collection.GetIfExistsAsync(configurationProfileAssignmentName);
            AutomanageVmConfigurationProfileAssignmentResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomanageConfigurationProfileAssignmentData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // List configuration profile assignments by resourceGroup and virtual machine
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListConfigurationProfileAssignmentsByResourceGroupAndVirtualMachine()
        {
            // Generated from example definition: specification/automanage/resource-manager/Microsoft.Automanage/stable/2022-05-04/examples/listConfigurationProfileAssignmentsByVirtualMachines.json
            // this example is just showing the usage of "ConfigurationProfileAssignments_ListByVirtualMachines" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ArmResource created on azure
            // for more information of creating ArmResource, please refer to the document of ArmResource

            // get the collection of this AutomanageVmConfigurationProfileAssignmentResource
            string subscriptionId = "mySubscriptionId";
            string resourceGroupName = "myResourceGroupName";
            string vmName = "myVMName";
            ResourceIdentifier scopeId = new ResourceIdentifier(string.Format("/subscriptions/{0}/resourceGroups/{1}/providers/Microsoft.Compute/virtualMachines/{2}", subscriptionId, resourceGroupName, vmName));
            AutomanageVmConfigurationProfileAssignmentCollection collection = client.GetAutomanageVmConfigurationProfileAssignments(scopeId);

            // invoke the operation and iterate over the result
            await foreach (AutomanageVmConfigurationProfileAssignmentResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                AutomanageConfigurationProfileAssignmentData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
