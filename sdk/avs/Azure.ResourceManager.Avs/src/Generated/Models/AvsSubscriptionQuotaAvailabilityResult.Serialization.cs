// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsSubscriptionQuotaAvailabilityResult : IUtf8JsonSerializable, IJsonModel<AvsSubscriptionQuotaAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsSubscriptionQuotaAvailabilityResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvsSubscriptionQuotaAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(HostsRemaining is ChangeTrackingDictionary<string, int> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("hostsRemaining"u8);
                writer.WriteStartObject();
                foreach (var item in HostsRemaining)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && QuotaEnabled.HasValue)
            {
                writer.WritePropertyName("quotaEnabled"u8);
                writer.WriteStringValue(QuotaEnabled.Value.ToString());
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

        AvsSubscriptionQuotaAvailabilityResult IJsonModel<AvsSubscriptionQuotaAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsSubscriptionQuotaAvailabilityResult(document.RootElement, options);
        }

        internal static AvsSubscriptionQuotaAvailabilityResult DeserializeAvsSubscriptionQuotaAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, int> hostsRemaining = default;
            Optional<AvsSubscriptionQuotaEnabled> quotaEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostsRemaining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    hostsRemaining = dictionary;
                    continue;
                }
                if (property.NameEquals("quotaEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaEnabled = new AvsSubscriptionQuotaEnabled(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvsSubscriptionQuotaAvailabilityResult(hostsRemaining ?? new ChangeTrackingDictionary<string, int>(), Optional.ToNullable(quotaEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        AvsSubscriptionQuotaAvailabilityResult IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvsSubscriptionQuotaAvailabilityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
