// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotChannelSettings : IUtf8JsonSerializable, IJsonModel<BotChannelSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotChannelSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BotChannelSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (ExtensionKey1 != null)
            {
                writer.WritePropertyName("extensionKey1"u8);
                writer.WriteStringValue(ExtensionKey1);
            }
            if (ExtensionKey2 != null)
            {
                writer.WritePropertyName("extensionKey2"u8);
                writer.WriteStringValue(ExtensionKey2);
            }
            if (!(Sites is ChangeTrackingList<BotChannelSite> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sites"u8);
                writer.WriteStartArray();
                foreach (var item in Sites)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ChannelId != null)
            {
                writer.WritePropertyName("channelId"u8);
                writer.WriteStringValue(ChannelId);
            }
            if (ChannelDisplayName != null)
            {
                writer.WritePropertyName("channelDisplayName"u8);
                writer.WriteStringValue(ChannelDisplayName);
            }
            if (BotId != null)
            {
                writer.WritePropertyName("botId"u8);
                writer.WriteStringValue(BotId);
            }
            if (BotIconUri != null)
            {
                writer.WritePropertyName("botIconUrl"u8);
                writer.WriteStringValue(BotIconUri.AbsoluteUri);
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("isEnabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (DisableLocalAuth.HasValue)
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(DisableLocalAuth.Value);
            }
            if (RequireTermsAgreement.HasValue)
            {
                writer.WritePropertyName("requireTermsAgreement"u8);
                writer.WriteBooleanValue(RequireTermsAgreement.Value);
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

        BotChannelSettings IJsonModel<BotChannelSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BotChannelSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotChannelSettings(document.RootElement, options);
        }

        internal static BotChannelSettings DeserializeBotChannelSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> extensionKey1 = default;
            Optional<string> extensionKey2 = default;
            IList<BotChannelSite> sites = default;
            Optional<string> channelId = default;
            Optional<string> channelDisplayName = default;
            Optional<string> botId = default;
            Optional<Uri> botIconUrl = default;
            Optional<bool> isEnabled = default;
            Optional<bool> disableLocalAuth = default;
            Optional<bool> requireTermsAgreement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extensionKey1"u8))
                {
                    extensionKey1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extensionKey2"u8))
                {
                    extensionKey2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sites"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BotChannelSite> array = new List<BotChannelSite>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BotChannelSite.DeserializeBotChannelSite(item, options));
                    }
                    sites = array;
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelDisplayName"u8))
                {
                    channelDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("botId"u8))
                {
                    botId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("botIconUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    botIconUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableLocalAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableLocalAuth = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("requireTermsAgreement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireTermsAgreement = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BotChannelSettings(extensionKey1.Value, extensionKey2.Value, sites ?? new ChangeTrackingList<BotChannelSite>(), channelId.Value, channelDisplayName.Value, botId.Value, botIconUrl.Value, Optional.ToNullable(isEnabled), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(requireTermsAgreement), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotChannelSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BotChannelSettings)} does not support '{options.Format}' format.");
            }
        }

        BotChannelSettings IPersistableModel<BotChannelSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BotChannelSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBotChannelSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BotChannelSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BotChannelSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
