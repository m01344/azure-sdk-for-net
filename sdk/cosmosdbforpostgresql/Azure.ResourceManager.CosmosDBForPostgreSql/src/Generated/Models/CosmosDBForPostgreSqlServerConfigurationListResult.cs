// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDBForPostgreSql;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> A list of server configurations. </summary>
    internal partial class CosmosDBForPostgreSqlServerConfigurationListResult
    {
        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlServerConfigurationListResult"/>. </summary>
        internal CosmosDBForPostgreSqlServerConfigurationListResult()
        {
            Value = new ChangeTrackingList<CosmosDBForPostgreSqlServerConfigurationData>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlServerConfigurationListResult"/>. </summary>
        /// <param name="value"> The list of server configurations. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal CosmosDBForPostgreSqlServerConfigurationListResult(IReadOnlyList<CosmosDBForPostgreSqlServerConfigurationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of server configurations. </summary>
        public IReadOnlyList<CosmosDBForPostgreSqlServerConfigurationData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
