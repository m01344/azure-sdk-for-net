// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StackMajorVersion : IUtf8JsonSerializable, IJsonModel<StackMajorVersion>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StackMajorVersion>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StackMajorVersion>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackMajorVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StackMajorVersion)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DisplayVersion != null)
            {
                writer.WritePropertyName("displayVersion"u8);
                writer.WriteStringValue(DisplayVersion);
            }
            if (RuntimeVersion != null)
            {
                writer.WritePropertyName("runtimeVersion"u8);
                writer.WriteStringValue(RuntimeVersion);
            }
            if (IsDefault.HasValue)
            {
                writer.WritePropertyName("isDefault"u8);
                writer.WriteBooleanValue(IsDefault.Value);
            }
            if (!(MinorVersions is ChangeTrackingList<StackMinorVersion> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("minorVersions"u8);
                writer.WriteStartArray();
                foreach (var item in MinorVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsApplicationInsights.HasValue)
            {
                writer.WritePropertyName("applicationInsights"u8);
                writer.WriteBooleanValue(IsApplicationInsights.Value);
            }
            if (IsPreview.HasValue)
            {
                writer.WritePropertyName("isPreview"u8);
                writer.WriteBooleanValue(IsPreview.Value);
            }
            if (IsDeprecated.HasValue)
            {
                writer.WritePropertyName("isDeprecated"u8);
                writer.WriteBooleanValue(IsDeprecated.Value);
            }
            if (IsHidden.HasValue)
            {
                writer.WritePropertyName("isHidden"u8);
                writer.WriteBooleanValue(IsHidden.Value);
            }
            if (!(AppSettingsDictionary is ChangeTrackingDictionary<string, BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("appSettingsDictionary"u8);
                writer.WriteStartObject();
                foreach (var item in AppSettingsDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (!(SiteConfigPropertiesDictionary is ChangeTrackingDictionary<string, BinaryData> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("siteConfigPropertiesDictionary"u8);
                writer.WriteStartObject();
                foreach (var item in SiteConfigPropertiesDictionary)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
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

        StackMajorVersion IJsonModel<StackMajorVersion>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackMajorVersion>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StackMajorVersion)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStackMajorVersion(document.RootElement, options);
        }

        internal static StackMajorVersion DeserializeStackMajorVersion(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayVersion = default;
            Optional<string> runtimeVersion = default;
            Optional<bool> isDefault = default;
            IList<StackMinorVersion> minorVersions = default;
            Optional<bool> applicationInsights = default;
            Optional<bool> isPreview = default;
            Optional<bool> isDeprecated = default;
            Optional<bool> isHidden = default;
            IDictionary<string, BinaryData> appSettingsDictionary = default;
            IDictionary<string, BinaryData> siteConfigPropertiesDictionary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayVersion"u8))
                {
                    displayVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeVersion"u8))
                {
                    runtimeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isDefault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDefault = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("minorVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StackMinorVersion> array = new List<StackMinorVersion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StackMinorVersion.DeserializeStackMinorVersion(item, options));
                    }
                    minorVersions = array;
                    continue;
                }
                if (property.NameEquals("applicationInsights"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationInsights = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isPreview"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPreview = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isDeprecated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDeprecated = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isHidden"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isHidden = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appSettingsDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    appSettingsDictionary = dictionary;
                    continue;
                }
                if (property.NameEquals("siteConfigPropertiesDictionary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    siteConfigPropertiesDictionary = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StackMajorVersion(displayVersion.Value, runtimeVersion.Value, Optional.ToNullable(isDefault), minorVersions ?? new ChangeTrackingList<StackMinorVersion>(), Optional.ToNullable(applicationInsights), Optional.ToNullable(isPreview), Optional.ToNullable(isDeprecated), Optional.ToNullable(isHidden), appSettingsDictionary ?? new ChangeTrackingDictionary<string, BinaryData>(), siteConfigPropertiesDictionary ?? new ChangeTrackingDictionary<string, BinaryData>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StackMajorVersion>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackMajorVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StackMajorVersion)} does not support '{options.Format}' format.");
            }
        }

        StackMajorVersion IPersistableModel<StackMajorVersion>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StackMajorVersion>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStackMajorVersion(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StackMajorVersion)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<StackMajorVersion>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
