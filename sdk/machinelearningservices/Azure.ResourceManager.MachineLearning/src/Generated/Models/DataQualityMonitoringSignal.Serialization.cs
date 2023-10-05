// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class DataQualityMonitoringSignal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(FeatureDataTypeOverride))
            {
                if (FeatureDataTypeOverride != null)
                {
                    writer.WritePropertyName("featureDataTypeOverride"u8);
                    writer.WriteStartObject();
                    foreach (var item in FeatureDataTypeOverride)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value.ToString());
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("featureDataTypeOverride");
                }
            }
            if (Optional.IsDefined(Features))
            {
                if (Features != null)
                {
                    writer.WritePropertyName("features"u8);
                    writer.WriteObjectValue(Features);
                }
                else
                {
                    writer.WriteNull("features");
                }
            }
            writer.WritePropertyName("metricThresholds"u8);
            writer.WriteStartArray();
            foreach (var item in MetricThresholds)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("productionData"u8);
            writer.WriteObjectValue(ProductionData);
            writer.WritePropertyName("referenceData"u8);
            writer.WriteObjectValue(ReferenceData);
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Properties))
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
            writer.WriteEndObject();
        }

        internal static DataQualityMonitoringSignal DeserializeDataQualityMonitoringSignal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, MonitoringFeatureDataType>> featureDataTypeOverride = default;
            Optional<MonitoringFeatureFilterBase> features = default;
            IList<DataQualityMetricThresholdBase> metricThresholds = default;
            MonitoringInputDataBase productionData = default;
            MonitoringInputDataBase referenceData = default;
            Optional<MonitoringNotificationMode> mode = default;
            Optional<IDictionary<string, string>> properties = default;
            MonitoringSignalType signalType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("featureDataTypeOverride"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        featureDataTypeOverride = null;
                        continue;
                    }
                    Dictionary<string, MonitoringFeatureDataType> dictionary = new Dictionary<string, MonitoringFeatureDataType>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, new MonitoringFeatureDataType(property0.Value.GetString()));
                    }
                    featureDataTypeOverride = dictionary;
                    continue;
                }
                if (property.NameEquals("features"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        features = null;
                        continue;
                    }
                    features = MonitoringFeatureFilterBase.DeserializeMonitoringFeatureFilterBase(property.Value);
                    continue;
                }
                if (property.NameEquals("metricThresholds"u8))
                {
                    List<DataQualityMetricThresholdBase> array = new List<DataQualityMetricThresholdBase>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataQualityMetricThresholdBase.DeserializeDataQualityMetricThresholdBase(item));
                    }
                    metricThresholds = array;
                    continue;
                }
                if (property.NameEquals("productionData"u8))
                {
                    productionData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value);
                    continue;
                }
                if (property.NameEquals("referenceData"u8))
                {
                    referenceData = MonitoringInputDataBase.DeserializeMonitoringInputDataBase(property.Value);
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
            }
            return new DataQualityMonitoringSignal(Optional.ToNullable(mode), Optional.ToDictionary(properties), signalType, Optional.ToDictionary(featureDataTypeOverride), features.Value, metricThresholds, productionData, referenceData);
        }
    }
}
