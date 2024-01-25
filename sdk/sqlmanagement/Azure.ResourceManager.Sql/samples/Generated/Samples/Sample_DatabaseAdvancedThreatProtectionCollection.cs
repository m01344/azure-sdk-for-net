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
using Azure.ResourceManager.Sql;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql.Samples
{
    public partial class Sample_DatabaseAdvancedThreatProtectionCollection
    {
        // Lists the database's Advanced Threat Protection settings.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListsTheDatabaseSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsListByDatabase.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_ListByDatabase" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this DatabaseAdvancedThreatProtectionResource
            DatabaseAdvancedThreatProtectionCollection collection = sqlDatabase.GetDatabaseAdvancedThreatProtections();

            // invoke the operation and iterate over the result
            await foreach (DatabaseAdvancedThreatProtectionResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DatabaseAdvancedThreatProtectionData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get a database's Advanced Threat Protection settings.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetADatabaseSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this DatabaseAdvancedThreatProtectionResource
            DatabaseAdvancedThreatProtectionCollection collection = sqlDatabase.GetDatabaseAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            DatabaseAdvancedThreatProtectionResource result = await collection.GetAsync(advancedThreatProtectionName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get a database's Advanced Threat Protection settings.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetADatabaseSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this DatabaseAdvancedThreatProtectionResource
            DatabaseAdvancedThreatProtectionCollection collection = sqlDatabase.GetDatabaseAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            bool result = await collection.ExistsAsync(advancedThreatProtectionName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Get a database's Advanced Threat Protection settings.
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_GetADatabaseSAdvancedThreatProtectionSettings()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsGet.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-6852";
            string serverName = "threatprotection-2080";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this DatabaseAdvancedThreatProtectionResource
            DatabaseAdvancedThreatProtectionCollection collection = sqlDatabase.GetDatabaseAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            NullableResponse<DatabaseAdvancedThreatProtectionResource> response = await collection.GetIfExistsAsync(advancedThreatProtectionName);
            DatabaseAdvancedThreatProtectionResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DatabaseAdvancedThreatProtectionData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // Update a database's Advanced Threat Protection settings with all parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateADatabaseSAdvancedThreatProtectionSettingsWithAllParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsCreateMax.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this DatabaseAdvancedThreatProtectionResource
            DatabaseAdvancedThreatProtectionCollection collection = sqlDatabase.GetDatabaseAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            DatabaseAdvancedThreatProtectionData data = new DatabaseAdvancedThreatProtectionData()
            {
                State = AdvancedThreatProtectionState.Enabled,
            };
            ArmOperation<DatabaseAdvancedThreatProtectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, advancedThreatProtectionName, data);
            DatabaseAdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Update a database's Advanced Threat Protection settings with minimal parameters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_UpdateADatabaseSAdvancedThreatProtectionSettingsWithMinimalParameters()
        {
            // Generated from example definition: specification/sql/resource-manager/Microsoft.Sql/preview/2021-11-01-preview/examples/DatabaseAdvancedThreatProtectionSettingsCreateMin.json
            // this example is just showing the usage of "DatabaseAdvancedThreatProtectionSettings_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SqlDatabaseResource created on azure
            // for more information of creating SqlDatabaseResource, please refer to the document of SqlDatabaseResource
            string subscriptionId = "00000000-1111-2222-3333-444444444444";
            string resourceGroupName = "threatprotection-4799";
            string serverName = "threatprotection-6440";
            string databaseName = "testdb";
            ResourceIdentifier sqlDatabaseResourceId = SqlDatabaseResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serverName, databaseName);
            SqlDatabaseResource sqlDatabase = client.GetSqlDatabaseResource(sqlDatabaseResourceId);

            // get the collection of this DatabaseAdvancedThreatProtectionResource
            DatabaseAdvancedThreatProtectionCollection collection = sqlDatabase.GetDatabaseAdvancedThreatProtections();

            // invoke the operation
            AdvancedThreatProtectionName advancedThreatProtectionName = AdvancedThreatProtectionName.Default;
            DatabaseAdvancedThreatProtectionData data = new DatabaseAdvancedThreatProtectionData()
            {
                State = AdvancedThreatProtectionState.Disabled,
            };
            ArmOperation<DatabaseAdvancedThreatProtectionResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, advancedThreatProtectionName, data);
            DatabaseAdvancedThreatProtectionResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DatabaseAdvancedThreatProtectionData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
