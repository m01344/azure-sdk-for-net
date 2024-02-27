// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Search.Models;

namespace Azure.ResourceManager.Search
{
    public partial class SearchServiceData : IUtf8JsonSerializable, IJsonModel<SearchServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SearchServiceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SearchServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ReplicaCount.HasValue)
            {
                writer.WritePropertyName("replicaCount"u8);
                writer.WriteNumberValue(ReplicaCount.Value);
            }
            if (PartitionCount.HasValue)
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (HostingMode.HasValue)
            {
                writer.WritePropertyName("hostingMode"u8);
                writer.WriteStringValue(HostingMode.Value.ToSerialString());
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToSerialString());
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (options.Format != "W" && StatusDetails != null)
            {
                writer.WritePropertyName("statusDetails"u8);
                writer.WriteStringValue(StatusDetails);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToSerialString());
            }
            if (NetworkRuleSet != null)
            {
                writer.WritePropertyName("networkRuleSet"u8);
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (EncryptionWithCmk != null)
            {
                writer.WritePropertyName("encryptionWithCmk"u8);
                writer.WriteObjectValue(EncryptionWithCmk);
            }
            if (IsLocalAuthDisabled.HasValue)
            {
                if (IsLocalAuthDisabled != null)
                {
                    writer.WritePropertyName("disableLocalAuth"u8);
                    writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
                }
                else
                {
                    writer.WriteNull("disableLocalAuth");
                }
            }
            if (AuthOptions != null)
            {
                writer.WritePropertyName("authOptions"u8);
                writer.WriteObjectValue(AuthOptions);
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<SearchPrivateEndpointConnectionData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (SemanticSearch.HasValue)
            {
                if (SemanticSearch != null)
                {
                    writer.WritePropertyName("semanticSearch"u8);
                    writer.WriteStringValue(SemanticSearch.Value.ToString());
                }
                else
                {
                    writer.WriteNull("semanticSearch");
                }
            }
            if (options.Format != "W" && !(SharedPrivateLinkResources is ChangeTrackingList<SharedSearchServicePrivateLinkResourceData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("sharedPrivateLinkResources"u8);
                writer.WriteStartArray();
                foreach (var item in SharedPrivateLinkResources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SearchServiceData IJsonModel<SearchServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchServiceData(document.RootElement, options);
        }

        internal static SearchServiceData DeserializeSearchServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SearchSku> sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> replicaCount = default;
            Optional<int> partitionCount = default;
            Optional<SearchServiceHostingMode> hostingMode = default;
            Optional<SearchServicePublicNetworkAccess> publicNetworkAccess = default;
            Optional<SearchServiceStatus> status = default;
            Optional<string> statusDetails = default;
            Optional<SearchServiceProvisioningState> provisioningState = default;
            Optional<NetworkRuleSet> networkRuleSet = default;
            Optional<SearchEncryptionWithCmk> encryptionWithCmk = default;
            Optional<bool?> disableLocalAuth = default;
            Optional<SearchAadAuthDataPlaneAuthOptions> authOptions = default;
            IReadOnlyList<SearchPrivateEndpointConnectionData> privateEndpointConnections = default;
            Optional<SearchSemanticSearch?> semanticSearch = default;
            IReadOnlyList<SharedSearchServicePrivateLinkResourceData> sharedPrivateLinkResources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SearchSku.DeserializeSearchSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("replicaCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicaCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("hostingMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hostingMode = property0.Value.GetString().ToSearchServiceHostingMode();
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = property0.Value.GetString().ToSearchServicePublicNetworkAccess();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToSearchServiceStatus();
                            continue;
                        }
                        if (property0.NameEquals("statusDetails"u8))
                        {
                            statusDetails = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = property0.Value.GetString().ToSearchServiceProvisioningState();
                            continue;
                        }
                        if (property0.NameEquals("networkRuleSet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkRuleSet = NetworkRuleSet.DeserializeNetworkRuleSet(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("encryptionWithCmk"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptionWithCmk = SearchEncryptionWithCmk.DeserializeSearchEncryptionWithCmk(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                disableLocalAuth = null;
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("authOptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authOptions = SearchAadAuthDataPlaneAuthOptions.DeserializeSearchAadAuthDataPlaneAuthOptions(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SearchPrivateEndpointConnectionData> array = new List<SearchPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SearchPrivateEndpointConnectionData.DeserializeSearchPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("semanticSearch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                semanticSearch = null;
                                continue;
                            }
                            semanticSearch = new SearchSemanticSearch(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sharedPrivateLinkResources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SharedSearchServicePrivateLinkResourceData> array = new List<SharedSearchServicePrivateLinkResourceData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SharedSearchServicePrivateLinkResourceData.DeserializeSharedSearchServicePrivateLinkResourceData(item, options));
                            }
                            sharedPrivateLinkResources = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SearchServiceData(id, name, type, systemData.Value, tags ?? new ChangeTrackingDictionary<string, string>(), location, sku.Value, identity, Optional.ToNullable(replicaCount), Optional.ToNullable(partitionCount), Optional.ToNullable(hostingMode), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(status), statusDetails.Value, Optional.ToNullable(provisioningState), networkRuleSet.Value, encryptionWithCmk.Value, Optional.ToNullable(disableLocalAuth), authOptions.Value, privateEndpointConnections ?? new ChangeTrackingList<SearchPrivateEndpointConnectionData>(), Optional.ToNullable(semanticSearch), sharedPrivateLinkResources ?? new ChangeTrackingList<SharedSearchServicePrivateLinkResourceData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SearchServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{options.Format}' format.");
            }
        }

        SearchServiceData IPersistableModel<SearchServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SearchServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSearchServiceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SearchServiceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SearchServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
