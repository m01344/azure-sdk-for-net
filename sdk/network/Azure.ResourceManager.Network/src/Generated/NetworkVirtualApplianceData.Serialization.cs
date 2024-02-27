// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class NetworkVirtualApplianceData : IUtf8JsonSerializable, IJsonModel<NetworkVirtualApplianceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkVirtualApplianceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkVirtualApplianceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (NvaSku != null)
            {
                writer.WritePropertyName("nvaSku"u8);
                writer.WriteObjectValue(NvaSku);
            }
            if (options.Format != "W" && AddressPrefix != null)
            {
                writer.WritePropertyName("addressPrefix"u8);
                writer.WriteStringValue(AddressPrefix);
            }
            if (!(BootStrapConfigurationBlobs is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("bootStrapConfigurationBlobs"u8);
                writer.WriteStartArray();
                foreach (var item in BootStrapConfigurationBlobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (VirtualHub != null)
            {
                writer.WritePropertyName("virtualHub"u8);
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (!(CloudInitConfigurationBlobs is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("cloudInitConfigurationBlobs"u8);
                writer.WriteStartArray();
                foreach (var item in CloudInitConfigurationBlobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (CloudInitConfiguration != null)
            {
                writer.WritePropertyName("cloudInitConfiguration"u8);
                writer.WriteStringValue(CloudInitConfiguration);
            }
            if (VirtualApplianceAsn.HasValue)
            {
                writer.WritePropertyName("virtualApplianceAsn"u8);
                writer.WriteNumberValue(VirtualApplianceAsn.Value);
            }
            if (SshPublicKey != null)
            {
                writer.WritePropertyName("sshPublicKey"u8);
                writer.WriteStringValue(SshPublicKey);
            }
            if (options.Format != "W" && !(VirtualApplianceNics is ChangeTrackingList<VirtualApplianceNicProperties> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("virtualApplianceNics"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(AdditionalNics is ChangeTrackingList<VirtualApplianceAdditionalNicProperties> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("additionalNics"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(InternetIngressPublicIPs is ChangeTrackingList<WritableSubResource> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("internetIngressPublicIps"u8);
                writer.WriteStartArray();
                foreach (var item in InternetIngressPublicIPs)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(VirtualApplianceSites is ChangeTrackingList<WritableSubResource> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("virtualApplianceSites"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceSites)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(VirtualApplianceConnections is ChangeTrackingList<WritableSubResource> collection6 && collection6.IsUndefined))
            {
                writer.WritePropertyName("virtualApplianceConnections"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualApplianceConnections)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(InboundSecurityRules is ChangeTrackingList<WritableSubResource> collection7 && collection7.IsUndefined))
            {
                writer.WritePropertyName("inboundSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundSecurityRules)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && DeploymentType != null)
            {
                writer.WritePropertyName("deploymentType"u8);
                writer.WriteStringValue(DeploymentType);
            }
            if (Delegation != null)
            {
                writer.WritePropertyName("delegation"u8);
                writer.WriteObjectValue(Delegation);
            }
            if (PartnerManagedResource != null)
            {
                writer.WritePropertyName("partnerManagedResource"u8);
                writer.WriteObjectValue(PartnerManagedResource);
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

        NetworkVirtualApplianceData IJsonModel<NetworkVirtualApplianceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkVirtualApplianceData(document.RootElement, options);
        }

        internal static NetworkVirtualApplianceData DeserializeNetworkVirtualApplianceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            IDictionary<string, string> tags = default;
            Optional<VirtualApplianceSkuProperties> nvaSku = default;
            Optional<string> addressPrefix = default;
            IList<string> bootStrapConfigurationBlobs = default;
            Optional<WritableSubResource> virtualHub = default;
            IList<string> cloudInitConfigurationBlobs = default;
            Optional<string> cloudInitConfiguration = default;
            Optional<long> virtualApplianceAsn = default;
            Optional<string> sshPublicKey = default;
            IReadOnlyList<VirtualApplianceNicProperties> virtualApplianceNics = default;
            IList<VirtualApplianceAdditionalNicProperties> additionalNics = default;
            IList<WritableSubResource> internetIngressPublicIPs = default;
            IReadOnlyList<WritableSubResource> virtualApplianceSites = default;
            IReadOnlyList<WritableSubResource> virtualApplianceConnections = default;
            IReadOnlyList<WritableSubResource> inboundSecurityRules = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<string> deploymentType = default;
            Optional<VirtualApplianceDelegationProperties> delegation = default;
            Optional<PartnerManagedResourceProperties> partnerManagedResource = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("nvaSku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nvaSku = VirtualApplianceSkuProperties.DeserializeVirtualApplianceSkuProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"u8))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bootStrapConfigurationBlobs"u8))
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
                            bootStrapConfigurationBlobs = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfigurationBlobs"u8))
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
                            cloudInitConfigurationBlobs = array;
                            continue;
                        }
                        if (property0.NameEquals("cloudInitConfiguration"u8))
                        {
                            cloudInitConfiguration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceAsn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualApplianceAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("sshPublicKey"u8))
                        {
                            sshPublicKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceNics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualApplianceNicProperties> array = new List<VirtualApplianceNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualApplianceNicProperties.DeserializeVirtualApplianceNicProperties(item, options));
                            }
                            virtualApplianceNics = array;
                            continue;
                        }
                        if (property0.NameEquals("additionalNics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<VirtualApplianceAdditionalNicProperties> array = new List<VirtualApplianceAdditionalNicProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualApplianceAdditionalNicProperties.DeserializeVirtualApplianceAdditionalNicProperties(item, options));
                            }
                            additionalNics = array;
                            continue;
                        }
                        if (property0.NameEquals("internetIngressPublicIps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            internetIngressPublicIPs = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceSites"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            virtualApplianceSites = array;
                            continue;
                        }
                        if (property0.NameEquals("virtualApplianceConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            virtualApplianceConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("inboundSecurityRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<WritableSubResource> array = new List<WritableSubResource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JsonSerializer.Deserialize<WritableSubResource>(item.GetRawText()));
                            }
                            inboundSecurityRules = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentType"u8))
                        {
                            deploymentType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("delegation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delegation = VirtualApplianceDelegationProperties.DeserializeVirtualApplianceDelegationProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("partnerManagedResource"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerManagedResource = PartnerManagedResourceProperties.DeserializePartnerManagedResourceProperties(property0.Value, options);
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
            return new NetworkVirtualApplianceData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), tags ?? new ChangeTrackingDictionary<string, string>(), serializedAdditionalRawData, identity, Optional.ToNullable(etag), nvaSku.Value, addressPrefix.Value, bootStrapConfigurationBlobs ?? new ChangeTrackingList<string>(), virtualHub, cloudInitConfigurationBlobs ?? new ChangeTrackingList<string>(), cloudInitConfiguration.Value, Optional.ToNullable(virtualApplianceAsn), sshPublicKey.Value, virtualApplianceNics ?? new ChangeTrackingList<VirtualApplianceNicProperties>(), additionalNics ?? new ChangeTrackingList<VirtualApplianceAdditionalNicProperties>(), internetIngressPublicIPs ?? new ChangeTrackingList<WritableSubResource>(), virtualApplianceSites ?? new ChangeTrackingList<WritableSubResource>(), virtualApplianceConnections ?? new ChangeTrackingList<WritableSubResource>(), inboundSecurityRules ?? new ChangeTrackingList<WritableSubResource>(), Optional.ToNullable(provisioningState), deploymentType.Value, delegation.Value, partnerManagedResource.Value);
        }

        BinaryData IPersistableModel<NetworkVirtualApplianceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support '{options.Format}' format.");
            }
        }

        NetworkVirtualApplianceData IPersistableModel<NetworkVirtualApplianceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkVirtualApplianceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkVirtualApplianceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkVirtualApplianceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkVirtualApplianceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
