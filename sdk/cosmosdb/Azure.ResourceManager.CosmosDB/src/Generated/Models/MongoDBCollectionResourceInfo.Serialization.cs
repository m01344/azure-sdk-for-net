// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class MongoDBCollectionResourceInfo : IUtf8JsonSerializable, IJsonModel<MongoDBCollectionResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoDBCollectionResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MongoDBCollectionResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCollectionResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(CollectionName);
            if (!(ShardKey is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("shardKey"u8);
                writer.WriteStartObject();
                foreach (var item in ShardKey)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Indexes is ChangeTrackingList<MongoDBIndex> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("indexes"u8);
                writer.WriteStartArray();
                foreach (var item in Indexes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AnalyticalStorageTtl.HasValue)
            {
                writer.WritePropertyName("analyticalStorageTtl"u8);
                writer.WriteNumberValue(AnalyticalStorageTtl.Value);
            }
            if (RestoreParameters != null)
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (CreateMode.HasValue)
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
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

        MongoDBCollectionResourceInfo IJsonModel<MongoDBCollectionResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoDBCollectionResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoDBCollectionResourceInfo(document.RootElement, options);
        }

        internal static MongoDBCollectionResourceInfo DeserializeMongoDBCollectionResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IDictionary<string, string> shardKey = default;
            IList<MongoDBIndex> indexes = default;
            Optional<int> analyticalStorageTtl = default;
            Optional<ResourceRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardKey"u8))
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
                    shardKey = dictionary;
                    continue;
                }
                if (property.NameEquals("indexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MongoDBIndex> array = new List<MongoDBIndex>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoDBIndex.DeserializeMongoDBIndex(item, options));
                    }
                    indexes = array;
                    continue;
                }
                if (property.NameEquals("analyticalStorageTtl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyticalStorageTtl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MongoDBCollectionResourceInfo(id, shardKey ?? new ChangeTrackingDictionary<string, string>(), indexes ?? new ChangeTrackingList<MongoDBIndex>(), Optional.ToNullable(analyticalStorageTtl), restoreParameters.Value, Optional.ToNullable(createMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoDBCollectionResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoDBCollectionResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        MongoDBCollectionResourceInfo IPersistableModel<MongoDBCollectionResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoDBCollectionResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoDBCollectionResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoDBCollectionResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoDBCollectionResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
