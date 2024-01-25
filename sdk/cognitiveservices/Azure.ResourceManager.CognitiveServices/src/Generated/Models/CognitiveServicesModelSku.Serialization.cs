// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    public partial class CognitiveServicesModelSku : IUtf8JsonSerializable, IJsonModel<CognitiveServicesModelSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CognitiveServicesModelSku>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CognitiveServicesModelSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesModelSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesModelSku)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(UsageName))
            {
                writer.WritePropertyName("usageName"u8);
                writer.WriteStringValue(UsageName);
            }
            if (Optional.IsDefined(DeprecationOn))
            {
                writer.WritePropertyName("deprecationDate"u8);
                writer.WriteStringValue(DeprecationOn.Value, "O");
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RateLimits))
            {
                writer.WritePropertyName("rateLimits"u8);
                writer.WriteStartArray();
                foreach (var item in RateLimits)
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

        CognitiveServicesModelSku IJsonModel<CognitiveServicesModelSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesModelSku>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CognitiveServicesModelSku)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCognitiveServicesModelSku(document.RootElement, options);
        }

        internal static CognitiveServicesModelSku DeserializeCognitiveServicesModelSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> usageName = default;
            Optional<DateTimeOffset> deprecationDate = default;
            Optional<CognitiveServicesCapacityConfig> capacity = default;
            Optional<IReadOnlyList<ServiceAccountCallRateLimit>> rateLimits = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("usageName"u8))
                {
                    usageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deprecationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deprecationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = CognitiveServicesCapacityConfig.DeserializeCognitiveServicesCapacityConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("rateLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAccountCallRateLimit> array = new List<ServiceAccountCallRateLimit>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAccountCallRateLimit.DeserializeServiceAccountCallRateLimit(item));
                    }
                    rateLimits = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CognitiveServicesModelSku(name.Value, usageName.Value, Optional.ToNullable(deprecationDate), capacity.Value, Optional.ToList(rateLimits), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CognitiveServicesModelSku>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesModelSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesModelSku)} does not support '{options.Format}' format.");
            }
        }

        CognitiveServicesModelSku IPersistableModel<CognitiveServicesModelSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CognitiveServicesModelSku>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCognitiveServicesModelSku(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CognitiveServicesModelSku)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CognitiveServicesModelSku>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
