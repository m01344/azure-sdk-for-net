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
using Azure.ResourceManager.Synapse;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse.Samples
{
    public partial class Sample_SynapseDataWarehouseUserActivityCollection
    {
        // Get a SQL Analytics pool user activity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetASQLAnalyticsPoolUserActivity()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolUserActivity.json
            // this example is just showing the usage of "SqlPoolDataWarehouseUserActivities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string workspaceName = "testsvr";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseDataWarehouseUserActivityResource
            SynapseDataWarehouseUserActivityCollection collection = synapseSqlPool.GetSynapseDataWarehouseUserActivities();

            // invoke the operation
            SynapseDataWarehouseUserActivityName dataWarehouseUserActivityName = SynapseDataWarehouseUserActivityName.Current;
            SynapseDataWarehouseUserActivityResource result = await collection.GetAsync(dataWarehouseUserActivityName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SynapseDataWarehouseUserActivityData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a SQL Analytics pool user activity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetASQLAnalyticsPoolUserActivity()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolUserActivity.json
            // this example is just showing the usage of "SqlPoolDataWarehouseUserActivities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string workspaceName = "testsvr";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseDataWarehouseUserActivityResource
            SynapseDataWarehouseUserActivityCollection collection = synapseSqlPool.GetSynapseDataWarehouseUserActivities();

            // invoke the operation
            SynapseDataWarehouseUserActivityName dataWarehouseUserActivityName = SynapseDataWarehouseUserActivityName.Current;
            bool result = await collection.ExistsAsync(dataWarehouseUserActivityName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a SQL Analytics pool user activity
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetASQLAnalyticsPoolUserActivity()
        {
            // Generated from example definition: specification/synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/examples/GetSqlPoolUserActivity.json
            // this example is just showing the usage of "SqlPoolDataWarehouseUserActivities_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SynapseSqlPoolResource created on azure
            // for more information of creating SynapseSqlPoolResource, please refer to the document of SynapseSqlPoolResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "Default-SQL-SouthEastAsia";
            string workspaceName = "testsvr";
            string sqlPoolName = "testdb";
            ResourceIdentifier synapseSqlPoolResourceId = SynapseSqlPoolResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, sqlPoolName);
            SynapseSqlPoolResource synapseSqlPool = client.GetSynapseSqlPoolResource(synapseSqlPoolResourceId);

            // get the collection of this SynapseDataWarehouseUserActivityResource
            SynapseDataWarehouseUserActivityCollection collection = synapseSqlPool.GetSynapseDataWarehouseUserActivities();

            // invoke the operation
            SynapseDataWarehouseUserActivityName dataWarehouseUserActivityName = SynapseDataWarehouseUserActivityName.Current;
            NullableResponse<SynapseDataWarehouseUserActivityResource> response = await collection.GetIfExistsAsync(dataWarehouseUserActivityName);
            SynapseDataWarehouseUserActivityResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                SynapseDataWarehouseUserActivityData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
