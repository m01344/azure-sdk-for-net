// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Gremlin database resource object. </summary>
    public partial class GremlinDatabaseResourceInfo
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GremlinDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB Gremlin database. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="databaseName"/> is null. </exception>
        public GremlinDatabaseResourceInfo(string databaseName)
        {
            Argument.AssertNotNull(databaseName, nameof(databaseName));

            DatabaseName = databaseName;
        }

        /// <summary> Initializes a new instance of <see cref="GremlinDatabaseResourceInfo"/>. </summary>
        /// <param name="databaseName"> Name of the Cosmos DB Gremlin database. </param>
        /// <param name="restoreParameters"> Parameters to indicate the information about the restore. </param>
        /// <param name="createMode"> Enum to indicate the mode of resource creation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GremlinDatabaseResourceInfo(string databaseName, ResourceRestoreParameters restoreParameters, CosmosDBAccountCreateMode? createMode, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DatabaseName = databaseName;
            RestoreParameters = restoreParameters;
            CreateMode = createMode;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="GremlinDatabaseResourceInfo"/> for deserialization. </summary>
        internal GremlinDatabaseResourceInfo()
        {
        }

        /// <summary> Name of the Cosmos DB Gremlin database. </summary>
        public string DatabaseName { get; set; }
        /// <summary> Parameters to indicate the information about the restore. </summary>
        public ResourceRestoreParameters RestoreParameters { get; set; }
        /// <summary> Enum to indicate the mode of resource creation. </summary>
        public CosmosDBAccountCreateMode? CreateMode { get; set; }
    }
}
