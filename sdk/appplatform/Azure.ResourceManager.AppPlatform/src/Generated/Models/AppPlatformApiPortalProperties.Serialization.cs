// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformApiPortalProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformApiPortalProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformApiPortalProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformApiPortalProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformApiPortalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformApiPortalProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (IsPublic.HasValue)
            {
                writer.WritePropertyName("public"u8);
                writer.WriteBooleanValue(IsPublic.Value);
            }
            if (options.Format != "W" && Uri != null)
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (IsHttpsOnly.HasValue)
            {
                writer.WritePropertyName("httpsOnly"u8);
                writer.WriteBooleanValue(IsHttpsOnly.Value);
            }
            if (!(GatewayIds is ChangeTrackingList<ResourceIdentifier> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("gatewayIds"u8);
                writer.WriteStartArray();
                foreach (var item in GatewayIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(SourceUris is ChangeTrackingList<Uri> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("sourceUrls"u8);
                writer.WriteStartArray();
                foreach (var item in SourceUris)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.AbsoluteUri);
                }
                writer.WriteEndArray();
            }
            if (SsoProperties != null)
            {
                writer.WritePropertyName("ssoProperties"u8);
                writer.WriteObjectValue(SsoProperties);
            }
            if (options.Format != "W" && ResourceRequests != null)
            {
                writer.WritePropertyName("resourceRequests"u8);
                writer.WriteObjectValue(ResourceRequests);
            }
            if (options.Format != "W" && !(Instances is ChangeTrackingList<AppPlatformApiPortalInstance> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("instances"u8);
                writer.WriteStartArray();
                foreach (var item in Instances)
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

        AppPlatformApiPortalProperties IJsonModel<AppPlatformApiPortalProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformApiPortalProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformApiPortalProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformApiPortalProperties(document.RootElement, options);
        }

        internal static AppPlatformApiPortalProperties DeserializeAppPlatformApiPortalProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformApiPortalProvisioningState> provisioningState = default;
            Optional<bool> @public = default;
            Optional<Uri> uri = default;
            Optional<bool> httpsOnly = default;
            IList<ResourceIdentifier> gatewayIds = default;
            IList<Uri> sourceUris = default;
            Optional<AppPlatformSsoProperties> ssoProperties = default;
            Optional<AppPlatformApiPortalResourceRequirements> resourceRequests = default;
            IReadOnlyList<AppPlatformApiPortalInstance> instances = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformApiPortalProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("public"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @public = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("httpsOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpsOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("gatewayIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    gatewayIds = array;
                    continue;
                }
                if (property.NameEquals("sourceUrls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Uri> array = new List<Uri>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new Uri(item.GetString()));
                        }
                    }
                    sourceUris = array;
                    continue;
                }
                if (property.NameEquals("ssoProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ssoProperties = AppPlatformSsoProperties.DeserializeAppPlatformSsoProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformApiPortalResourceRequirements.DeserializeAppPlatformApiPortalResourceRequirements(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformApiPortalInstance> array = new List<AppPlatformApiPortalInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformApiPortalInstance.DeserializeAppPlatformApiPortalInstance(item, options));
                    }
                    instances = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformApiPortalProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(@public), uri.Value, Optional.ToNullable(httpsOnly), gatewayIds ?? new ChangeTrackingList<ResourceIdentifier>(), sourceUris ?? new ChangeTrackingList<Uri>(), ssoProperties.Value, resourceRequests.Value, instances ?? new ChangeTrackingList<AppPlatformApiPortalInstance>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformApiPortalProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformApiPortalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformApiPortalProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformApiPortalProperties IPersistableModel<AppPlatformApiPortalProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformApiPortalProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformApiPortalProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformApiPortalProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformApiPortalProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
