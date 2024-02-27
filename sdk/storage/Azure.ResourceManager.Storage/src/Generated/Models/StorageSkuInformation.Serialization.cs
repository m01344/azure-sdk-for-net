// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageSkuInformation : IUtf8JsonSerializable, IJsonModel<StorageSkuInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageSkuInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageSkuInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSkuInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSkuInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToString());
            if (options.Format != "W" && Tier.HasValue)
            {
                writer.WritePropertyName("tier"u8);
                writer.WriteStringValue(Tier.Value.ToSerialString());
            }
            if (options.Format != "W" && ResourceType != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Kind.HasValue)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (options.Format != "W" && !(Locations is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(Capabilities is ChangeTrackingList<StorageSkuCapability> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartArray();
                foreach (var item in Capabilities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Restrictions is ChangeTrackingList<StorageSkuRestriction> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("restrictions"u8);
                writer.WriteStartArray();
                foreach (var item in Restrictions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        StorageSkuInformation IJsonModel<StorageSkuInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSkuInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StorageSkuInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageSkuInformation(document.RootElement, options);
        }

        internal static StorageSkuInformation DeserializeStorageSkuInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            StorageSkuName name = default;
            Optional<StorageSkuTier> tier = default;
            Optional<string> resourceType = default;
            Optional<StorageKind> kind = default;
            IReadOnlyList<string> locations = default;
            IReadOnlyList<StorageSkuCapability> capabilities = default;
            IReadOnlyList<StorageSkuRestriction> restrictions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = new StorageSkuName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tier = property.Value.GetString().ToStorageSkuTier();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new StorageKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageSkuCapability> array = new List<StorageSkuCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageSkuCapability.DeserializeStorageSkuCapability(item, options));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageSkuRestriction> array = new List<StorageSkuRestriction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageSkuRestriction.DeserializeStorageSkuRestriction(item, options));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageSkuInformation(name, Optional.ToNullable(tier), resourceType.Value, Optional.ToNullable(kind), locations ?? new ChangeTrackingList<string>(), capabilities ?? new ChangeTrackingList<StorageSkuCapability>(), restrictions ?? new ChangeTrackingList<StorageSkuRestriction>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageSkuInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSkuInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StorageSkuInformation)} does not support '{options.Format}' format.");
            }
        }

        StorageSkuInformation IPersistableModel<StorageSkuInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StorageSkuInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStorageSkuInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StorageSkuInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StorageSkuInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
