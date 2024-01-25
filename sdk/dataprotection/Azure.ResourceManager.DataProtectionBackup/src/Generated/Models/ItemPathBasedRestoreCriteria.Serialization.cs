// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class ItemPathBasedRestoreCriteria : IUtf8JsonSerializable, IJsonModel<ItemPathBasedRestoreCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ItemPathBasedRestoreCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ItemPathBasedRestoreCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ItemPathBasedRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ItemPathBasedRestoreCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("itemPath"u8);
            writer.WriteStringValue(ItemPath);
            writer.WritePropertyName("isPathRelativeToBackupItem"u8);
            writer.WriteBooleanValue(IsPathRelativeToBackupItem);
            if (Optional.IsCollectionDefined(SubItemPathPrefix))
            {
                writer.WritePropertyName("subItemPathPrefix"u8);
                writer.WriteStartArray();
                foreach (var item in SubItemPathPrefix)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        ItemPathBasedRestoreCriteria IJsonModel<ItemPathBasedRestoreCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ItemPathBasedRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ItemPathBasedRestoreCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeItemPathBasedRestoreCriteria(document.RootElement, options);
        }

        internal static ItemPathBasedRestoreCriteria DeserializeItemPathBasedRestoreCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string itemPath = default;
            bool isPathRelativeToBackupItem = default;
            Optional<IList<string>> subItemPathPrefix = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("itemPath"u8))
                {
                    itemPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPathRelativeToBackupItem"u8))
                {
                    isPathRelativeToBackupItem = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subItemPathPrefix"u8))
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
                    subItemPathPrefix = array;
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ItemPathBasedRestoreCriteria(objectType, serializedAdditionalRawData, itemPath, isPathRelativeToBackupItem, Optional.ToList(subItemPathPrefix));
        }

        BinaryData IPersistableModel<ItemPathBasedRestoreCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ItemPathBasedRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ItemPathBasedRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        ItemPathBasedRestoreCriteria IPersistableModel<ItemPathBasedRestoreCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ItemPathBasedRestoreCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeItemPathBasedRestoreCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ItemPathBasedRestoreCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ItemPathBasedRestoreCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
