// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    internal partial class DiskEncryptionConfiguration : IUtf8JsonSerializable, IJsonModel<DiskEncryptionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiskEncryptionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DiskEncryptionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskEncryptionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Targets is ChangeTrackingList<BatchDiskEncryptionTarget> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("targets"u8);
                writer.WriteStartArray();
                foreach (var item in Targets)
                {
                    writer.WriteStringValue(item.ToSerialString());
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

        DiskEncryptionConfiguration IJsonModel<DiskEncryptionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DiskEncryptionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiskEncryptionConfiguration(document.RootElement, options);
        }

        internal static DiskEncryptionConfiguration DeserializeDiskEncryptionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<BatchDiskEncryptionTarget> targets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchDiskEncryptionTarget> array = new List<BatchDiskEncryptionTarget>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBatchDiskEncryptionTarget());
                    }
                    targets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiskEncryptionConfiguration(targets ?? new ChangeTrackingList<BatchDiskEncryptionTarget>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiskEncryptionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DiskEncryptionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        DiskEncryptionConfiguration IPersistableModel<DiskEncryptionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DiskEncryptionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDiskEncryptionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DiskEncryptionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DiskEncryptionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
