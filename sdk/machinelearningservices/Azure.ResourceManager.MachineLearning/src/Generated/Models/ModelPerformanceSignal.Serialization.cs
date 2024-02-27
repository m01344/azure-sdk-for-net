// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ModelPerformanceSignal : IUtf8JsonSerializable, IJsonModel<ModelPerformanceSignal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelPerformanceSignal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ModelPerformanceSignal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPerformanceSignal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DataSegment != null)
            {
                if (DataSegment != null)
                {
                    writer.WritePropertyName("dataSegment"u8);
                    writer.WriteObjectValue(DataSegment);
                }
                else
                {
                    writer.WriteNull("dataSegment");
                }
            }
            writer.WritePropertyName("metricThreshold"u8);
            writer.WriteObjectValue(MetricThreshold);
            writer.WritePropertyName("productionData"u8);
            writer.WriteStartArray();
            foreach (var item in ProductionData)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("referenceData"u8);
            writer.WriteObjectValue(ReferenceData);
            if (Mode.HasValue)
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (!(Properties is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (Properties != null)
                {
                    writer.WritePropertyName("properties"u8);
                    writer.WriteStartObject();
                    foreach (var item in Properties)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("properties");
                }
            }
            writer.WritePropertyName("signalType"u8);
            writer.WriteStringValue(SignalType.ToString());
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

        ModelPerformanceSignal IJsonModel<ModelPerformanceSignal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceSignal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPerformanceSignal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelPerformanceSignal(document.RootElement, options);
        }

        internal static ModelPerformanceSignal DeserializeModelPerformanceSignal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MonitoringDataSegment> dataSegment = default;
            ModelPerformanceMetricThresholdBase metricThreshold = default;
            IList<MonitoringInputDataBase> productionData = default;
            MonitoringInputDataBase referenceData = default;
            Optional<MonitoringNotificationMode> mode = default;
            IDictionary<string, string> properties = default;
            MonitoringSignalType signalType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataSegment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        dataSegment = null;
                        continue;
                    }
                    dataSegment = MonitoringDataSegment.DeserializeMonitoringDataSegment(property.Value, options);
                    continue;
                }
                if (property.NameEquals("metricThreshold"u8))
                {
                    metricThreshold = ModelPerformanceMetricThresholdBase.DeserializeModelPerformanceMetricThresholdBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("productionData"u8))
                {
                    List<MonitoringInputDataBase> array = new List<MonitoringInputDataBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitoringInputDataBase.DeserializeMonitoringInputDataBase(item, options));
                    }
                    productionData = array;
                    continue;
                }
                if (property.NameEquals("referenceData"u8))
                {
                    referenceData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value, options);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MonitoringNotificationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    signalType = new MonitoringSignalType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ModelPerformanceSignal(Optional.ToNullable(mode), properties ?? new ChangeTrackingDictionary<string, string>(), signalType, serializedAdditionalRawData, dataSegment.Value, metricThreshold, productionData, referenceData);
        }

        BinaryData IPersistableModel<ModelPerformanceSignal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelPerformanceSignal)} does not support '{options.Format}' format.");
            }
        }

        ModelPerformanceSignal IPersistableModel<ModelPerformanceSignal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPerformanceSignal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelPerformanceSignal(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelPerformanceSignal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelPerformanceSignal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
