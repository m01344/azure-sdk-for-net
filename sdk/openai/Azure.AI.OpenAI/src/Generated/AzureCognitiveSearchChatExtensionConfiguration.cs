// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// A specific representation of configurable options for Azure Cognitive Search when using it as an Azure OpenAI chat
    /// extension.
    /// </summary>
    public partial class AzureCognitiveSearchChatExtensionConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="AzureCognitiveSearchChatExtensionConfiguration"/>. </summary>
        /// <param name="type">
        /// The type label to use when configuring Azure OpenAI chat extensions. This should typically not be changed from its
        /// default value for Azure Cognitive Search.
        /// </param>
        /// <param name="searchEndpoint"> The absolute endpoint path for the Azure Cognitive Search resource to use. </param>
        /// <param name="searchKey"> The API admin key to use with the specified Azure Cognitive Search endpoint. </param>
        /// <param name="indexName"> The name of the index to use as available in the referenced Azure Cognitive Search resource. </param>
        /// <param name="fieldMappingOptions"> Customized field mapping behavior to use when interacting with the search index. </param>
        /// <param name="documentCount"> The configured top number of documents to feature for the configured query. </param>
        /// <param name="queryType"> The query type to use with Azure Cognitive Search. </param>
        /// <param name="shouldRestrictResultScope"> Whether queries should be restricted to use of indexed data. </param>
        /// <param name="semanticConfiguration"> The additional semantic configuration for the query. </param>
        /// <param name="embeddingEndpoint"> When using embeddings for search, specifies the resource URL from which embeddings should be retrieved. </param>
        /// <param name="embeddingKey"> When using embeddings, specifies the API key to use with the provided embeddings endpoint. </param>
        internal AzureCognitiveSearchChatExtensionConfiguration(AzureChatExtensionType type, Uri searchEndpoint, string searchKey, string indexName, AzureCognitiveSearchIndexFieldMappingOptions fieldMappingOptions, int? documentCount, AzureCognitiveSearchQueryType? queryType, bool? shouldRestrictResultScope, string semanticConfiguration, Uri embeddingEndpoint, string embeddingKey)
        {
            Type = type;
            SearchEndpoint = searchEndpoint;
            SearchKey = searchKey;
            IndexName = indexName;
            FieldMappingOptions = fieldMappingOptions;
            DocumentCount = documentCount;
            QueryType = queryType;
            ShouldRestrictResultScope = shouldRestrictResultScope;
            SemanticConfiguration = semanticConfiguration;
            EmbeddingEndpoint = embeddingEndpoint;
            EmbeddingKey = embeddingKey;
        }
        /// <summary> Customized field mapping behavior to use when interacting with the search index. </summary>
        public AzureCognitiveSearchIndexFieldMappingOptions FieldMappingOptions { get; set; }
        /// <summary> The configured top number of documents to feature for the configured query. </summary>
        public int? DocumentCount { get; set; }
        /// <summary> The query type to use with Azure Cognitive Search. </summary>
        public AzureCognitiveSearchQueryType? QueryType { get; set; }
        /// <summary> Whether queries should be restricted to use of indexed data. </summary>
        public bool? ShouldRestrictResultScope { get; set; }
        /// <summary> The additional semantic configuration for the query. </summary>
        public string SemanticConfiguration { get; set; }
        /// <summary> When using embeddings for search, specifies the resource URL from which embeddings should be retrieved. </summary>
        public Uri EmbeddingEndpoint { get; set; }
    }
}
