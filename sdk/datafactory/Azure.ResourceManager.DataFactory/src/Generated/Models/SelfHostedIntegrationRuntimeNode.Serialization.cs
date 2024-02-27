// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class SelfHostedIntegrationRuntimeNode : IUtf8JsonSerializable, IJsonModel<SelfHostedIntegrationRuntimeNode>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHostedIntegrationRuntimeNode>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHostedIntegrationRuntimeNode>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeNode)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && NodeName != null)
            {
                writer.WritePropertyName("nodeName"u8);
                writer.WriteStringValue(NodeName);
            }
            if (options.Format != "W" && MachineName != null)
            {
                writer.WritePropertyName("machineName"u8);
                writer.WriteStringValue(MachineName);
            }
            if (options.Format != "W" && HostServiceUri != null)
            {
                writer.WritePropertyName("hostServiceUri"u8);
                writer.WriteStringValue(HostServiceUri.AbsoluteUri);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && !(Capabilities is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStartObject();
                foreach (var item in Capabilities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && VersionStatus != null)
            {
                writer.WritePropertyName("versionStatus"u8);
                writer.WriteStringValue(VersionStatus);
            }
            if (options.Format != "W" && Version != null)
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (options.Format != "W" && RegisterOn.HasValue)
            {
                writer.WritePropertyName("registerTime"u8);
                writer.WriteStringValue(RegisterOn.Value, "O");
            }
            if (options.Format != "W" && LastConnectOn.HasValue)
            {
                writer.WritePropertyName("lastConnectTime"u8);
                writer.WriteStringValue(LastConnectOn.Value, "O");
            }
            if (options.Format != "W" && ExpireOn.HasValue)
            {
                writer.WritePropertyName("expiryTime"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && LastStartOn.HasValue)
            {
                writer.WritePropertyName("lastStartTime"u8);
                writer.WriteStringValue(LastStartOn.Value, "O");
            }
            if (options.Format != "W" && LastStopOn.HasValue)
            {
                writer.WritePropertyName("lastStopTime"u8);
                writer.WriteStringValue(LastStopOn.Value, "O");
            }
            if (options.Format != "W" && LastUpdateResult.HasValue)
            {
                writer.WritePropertyName("lastUpdateResult"u8);
                writer.WriteStringValue(LastUpdateResult.Value.ToString());
            }
            if (options.Format != "W" && LastStartUpdateOn.HasValue)
            {
                writer.WritePropertyName("lastStartUpdateTime"u8);
                writer.WriteStringValue(LastStartUpdateOn.Value, "O");
            }
            if (options.Format != "W" && LastEndUpdateOn.HasValue)
            {
                writer.WritePropertyName("lastEndUpdateTime"u8);
                writer.WriteStringValue(LastEndUpdateOn.Value, "O");
            }
            if (options.Format != "W" && IsActiveDispatcher.HasValue)
            {
                writer.WritePropertyName("isActiveDispatcher"u8);
                writer.WriteBooleanValue(IsActiveDispatcher.Value);
            }
            if (options.Format != "W" && ConcurrentJobsLimit.HasValue)
            {
                writer.WritePropertyName("concurrentJobsLimit"u8);
                writer.WriteNumberValue(ConcurrentJobsLimit.Value);
            }
            if (options.Format != "W" && MaxConcurrentJobs.HasValue)
            {
                writer.WritePropertyName("maxConcurrentJobs"u8);
                writer.WriteNumberValue(MaxConcurrentJobs.Value);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        SelfHostedIntegrationRuntimeNode IJsonModel<SelfHostedIntegrationRuntimeNode>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeNode)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHostedIntegrationRuntimeNode(document.RootElement, options);
        }

        internal static SelfHostedIntegrationRuntimeNode DeserializeSelfHostedIntegrationRuntimeNode(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodeName = default;
            Optional<string> machineName = default;
            Optional<Uri> hostServiceUri = default;
            Optional<SelfHostedIntegrationRuntimeNodeStatus> status = default;
            IReadOnlyDictionary<string, string> capabilities = default;
            Optional<string> versionStatus = default;
            Optional<string> version = default;
            Optional<DateTimeOffset> registerTime = default;
            Optional<DateTimeOffset> lastConnectTime = default;
            Optional<DateTimeOffset> expiryTime = default;
            Optional<DateTimeOffset> lastStartTime = default;
            Optional<DateTimeOffset> lastStopTime = default;
            Optional<IntegrationRuntimeUpdateResult> lastUpdateResult = default;
            Optional<DateTimeOffset> lastStartUpdateTime = default;
            Optional<DateTimeOffset> lastEndUpdateTime = default;
            Optional<bool> isActiveDispatcher = default;
            Optional<int> concurrentJobsLimit = default;
            Optional<int> maxConcurrentJobs = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeName"u8))
                {
                    nodeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hostServiceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hostServiceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new SelfHostedIntegrationRuntimeNodeStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
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
                    capabilities = dictionary;
                    continue;
                }
                if (property.NameEquals("versionStatus"u8))
                {
                    versionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("registerTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    registerTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastConnectTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastConnectTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expiryTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiryTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastStopTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStopTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdateResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastUpdateResult = new IntegrationRuntimeUpdateResult(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastStartUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStartUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastEndUpdateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastEndUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isActiveDispatcher"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isActiveDispatcher = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("concurrentJobsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    concurrentJobsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentJobs = property.Value.GetInt32();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SelfHostedIntegrationRuntimeNode(nodeName.Value, machineName.Value, hostServiceUri.Value, Optional.ToNullable(status), capabilities ?? new ChangeTrackingDictionary<string, string>(), versionStatus.Value, version.Value, Optional.ToNullable(registerTime), Optional.ToNullable(lastConnectTime), Optional.ToNullable(expiryTime), Optional.ToNullable(lastStartTime), Optional.ToNullable(lastStopTime), Optional.ToNullable(lastUpdateResult), Optional.ToNullable(lastStartUpdateTime), Optional.ToNullable(lastEndUpdateTime), Optional.ToNullable(isActiveDispatcher), Optional.ToNullable(concurrentJobsLimit), Optional.ToNullable(maxConcurrentJobs), additionalProperties);
        }

        BinaryData IPersistableModel<SelfHostedIntegrationRuntimeNode>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }
        }

        SelfHostedIntegrationRuntimeNode IPersistableModel<SelfHostedIntegrationRuntimeNode>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHostedIntegrationRuntimeNode>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHostedIntegrationRuntimeNode(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHostedIntegrationRuntimeNode)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHostedIntegrationRuntimeNode>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
