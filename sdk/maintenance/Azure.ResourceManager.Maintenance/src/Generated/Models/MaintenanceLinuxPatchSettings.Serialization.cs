// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    public partial class MaintenanceLinuxPatchSettings : IUtf8JsonSerializable, IJsonModel<MaintenanceLinuxPatchSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceLinuxPatchSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaintenanceLinuxPatchSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceLinuxPatchSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(PackageNameMasksToExclude is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("packageNameMasksToExclude"u8);
                writer.WriteStartArray();
                foreach (var item in PackageNameMasksToExclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PackageNameMasksToInclude is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("packageNameMasksToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in PackageNameMasksToInclude)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ClassificationsToInclude is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("classificationsToInclude"u8);
                writer.WriteStartArray();
                foreach (var item in ClassificationsToInclude)
                {
                    writer.WriteStringValue(item);
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

        MaintenanceLinuxPatchSettings IJsonModel<MaintenanceLinuxPatchSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceLinuxPatchSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceLinuxPatchSettings(document.RootElement, options);
        }

        internal static MaintenanceLinuxPatchSettings DeserializeMaintenanceLinuxPatchSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> packageNameMasksToExclude = default;
            IList<string> packageNameMasksToInclude = default;
            IList<string> classificationsToInclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packageNameMasksToExclude"u8))
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
                    packageNameMasksToExclude = array;
                    continue;
                }
                if (property.NameEquals("packageNameMasksToInclude"u8))
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
                    packageNameMasksToInclude = array;
                    continue;
                }
                if (property.NameEquals("classificationsToInclude"u8))
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
                    classificationsToInclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaintenanceLinuxPatchSettings(packageNameMasksToExclude ?? new ChangeTrackingList<string>(), packageNameMasksToInclude ?? new ChangeTrackingList<string>(), classificationsToInclude ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaintenanceLinuxPatchSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaintenanceLinuxPatchSettings)} does not support '{options.Format}' format.");
            }
        }

        MaintenanceLinuxPatchSettings IPersistableModel<MaintenanceLinuxPatchSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceLinuxPatchSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaintenanceLinuxPatchSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaintenanceLinuxPatchSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaintenanceLinuxPatchSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
