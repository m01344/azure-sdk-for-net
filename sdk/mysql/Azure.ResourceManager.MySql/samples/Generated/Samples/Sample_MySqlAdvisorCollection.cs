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
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Samples
{
    public partial class Sample_MySqlAdvisorCollection
    {
        // AdvisorsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_AdvisorsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/AdvisorsGet.json
            // this example is just showing the usage of "Advisors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlAdvisorResource
            MySqlAdvisorCollection collection = mySqlServer.GetMySqlAdvisors();

            // invoke the operation
            string advisorName = "Index";
            MySqlAdvisorResource result = await collection.GetAsync(advisorName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MySqlAdvisorData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // AdvisorsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_AdvisorsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/AdvisorsGet.json
            // this example is just showing the usage of "Advisors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlAdvisorResource
            MySqlAdvisorCollection collection = mySqlServer.GetMySqlAdvisors();

            // invoke the operation
            string advisorName = "Index";
            bool result = await collection.ExistsAsync(advisorName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // AdvisorsGet
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_AdvisorsGet()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/AdvisorsGet.json
            // this example is just showing the usage of "Advisors_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlAdvisorResource
            MySqlAdvisorCollection collection = mySqlServer.GetMySqlAdvisors();

            // invoke the operation
            string advisorName = "Index";
            NullableResponse<MySqlAdvisorResource> response = await collection.GetIfExistsAsync(advisorName);
            MySqlAdvisorResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlAdvisorData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // AdvisorsListByServer
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_AdvisorsListByServer()
        {
            // Generated from example definition: specification/mysql/resource-manager/Microsoft.DBforMySQL/legacy/stable/2018-06-01/examples/AdvisorsListByServer.json
            // this example is just showing the usage of "Advisors_ListByServer" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MySqlServerResource created on azure
            // for more information of creating MySqlServerResource, please refer to the document of MySqlServerResource
            string subscriptionId = "ffffffff-ffff-ffff-ffff-ffffffffffff";
            string resourceGroupName = "testResourceGroupName";
            string serverName = "testServerName";
            ResourceIdentifier mySqlServerResourceId = MySqlServerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName);
            MySqlServerResource mySqlServer = client.GetMySqlServerResource(mySqlServerResourceId);

            // get the collection of this MySqlAdvisorResource
            MySqlAdvisorCollection collection = mySqlServer.GetMySqlAdvisors();

            // invoke the operation and iterate over the result
            await foreach (MySqlAdvisorResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MySqlAdvisorData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
