// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineScaleSetExtensionPatch : IUtf8JsonSerializable, IJsonModel<VirtualMachineScaleSetExtensionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineScaleSetExtensionPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineScaleSetExtensionPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetExtensionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetExtensionPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ForceUpdateTag != null)
            {
                writer.WritePropertyName("forceUpdateTag"u8);
                writer.WriteStringValue(ForceUpdateTag);
            }
            if (Publisher != null)
            {
                writer.WritePropertyName("publisher"u8);
                writer.WriteStringValue(Publisher);
            }
            if (ExtensionType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ExtensionType);
            }
            if (TypeHandlerVersion != null)
            {
                writer.WritePropertyName("typeHandlerVersion"u8);
                writer.WriteStringValue(TypeHandlerVersion);
            }
            if (AutoUpgradeMinorVersion.HasValue)
            {
                writer.WritePropertyName("autoUpgradeMinorVersion"u8);
                writer.WriteBooleanValue(AutoUpgradeMinorVersion.Value);
            }
            if (EnableAutomaticUpgrade.HasValue)
            {
                writer.WritePropertyName("enableAutomaticUpgrade"u8);
                writer.WriteBooleanValue(EnableAutomaticUpgrade.Value);
            }
            if (Settings != null)
            {
                writer.WritePropertyName("settings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Settings);
#else
                using (JsonDocument document = JsonDocument.Parse(Settings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (ProtectedSettings != null)
            {
                writer.WritePropertyName("protectedSettings"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(ProtectedSettings);
#else
                using (JsonDocument document = JsonDocument.Parse(ProtectedSettings))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (!(ProvisionAfterExtensions is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("provisionAfterExtensions"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisionAfterExtensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SuppressFailures.HasValue)
            {
                writer.WritePropertyName("suppressFailures"u8);
                writer.WriteBooleanValue(SuppressFailures.Value);
            }
            if (KeyVaultProtectedSettings != null)
            {
                writer.WritePropertyName("protectedSettingsFromKeyVault"u8);
                writer.WriteObjectValue(KeyVaultProtectedSettings);
            }
            writer.WriteEndObject();
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

        VirtualMachineScaleSetExtensionPatch IJsonModel<VirtualMachineScaleSetExtensionPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetExtensionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineScaleSetExtensionPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineScaleSetExtensionPatch(document.RootElement, options);
        }

        internal static VirtualMachineScaleSetExtensionPatch DeserializeVirtualMachineScaleSetExtensionPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> forceUpdateTag = default;
            Optional<string> publisher = default;
            Optional<string> type0 = default;
            Optional<string> typeHandlerVersion = default;
            Optional<bool> autoUpgradeMinorVersion = default;
            Optional<bool> enableAutomaticUpgrade = default;
            Optional<BinaryData> settings = default;
            Optional<BinaryData> protectedSettings = default;
            Optional<string> provisioningState = default;
            IList<string> provisionAfterExtensions = default;
            Optional<bool> suppressFailures = default;
            Optional<KeyVaultSecretReference> protectedSettingsFromKeyVault = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("forceUpdateTag"u8))
                        {
                            forceUpdateTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typeHandlerVersion"u8))
                        {
                            typeHandlerVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("autoUpgradeMinorVersion"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoUpgradeMinorVersion = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableAutomaticUpgrade"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableAutomaticUpgrade = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("settings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            settings = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("protectedSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectedSettings = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisionAfterExtensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            provisionAfterExtensions = array;
                            continue;
                        }
                        if (property0.NameEquals("suppressFailures"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suppressFailures = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("protectedSettingsFromKeyVault"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protectedSettingsFromKeyVault = KeyVaultSecretReference.DeserializeKeyVaultSecretReference(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineScaleSetExtensionPatch(id, name, type, systemData.Value, forceUpdateTag.Value, publisher.Value, type0.Value, typeHandlerVersion.Value, Optional.ToNullable(autoUpgradeMinorVersion), Optional.ToNullable(enableAutomaticUpgrade), settings.Value, protectedSettings.Value, provisioningState.Value, provisionAfterExtensions ?? new ChangeTrackingList<string>(), Optional.ToNullable(suppressFailures), protectedSettingsFromKeyVault.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineScaleSetExtensionPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetExtensionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetExtensionPatch)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineScaleSetExtensionPatch IPersistableModel<VirtualMachineScaleSetExtensionPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineScaleSetExtensionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineScaleSetExtensionPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineScaleSetExtensionPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineScaleSetExtensionPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
