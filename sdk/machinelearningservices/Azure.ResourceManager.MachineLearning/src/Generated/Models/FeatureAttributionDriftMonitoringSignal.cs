// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The FeatureAttributionDriftMonitoringSignal. </summary>
    public partial class FeatureAttributionDriftMonitoringSignal : MonitoringSignalBase
    {
        /// <summary> Initializes a new instance of <see cref="FeatureAttributionDriftMonitoringSignal"/>. </summary>
        /// <param name="metricThreshold"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <param name="productionData">
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricThreshold"/>, <paramref name="productionData"/> or <paramref name="referenceData"/> is null. </exception>
        public FeatureAttributionDriftMonitoringSignal(FeatureAttributionMetricThreshold metricThreshold, IEnumerable<MonitoringInputDataBase> productionData, MonitoringInputDataBase referenceData)
        {
            Argument.AssertNotNull(metricThreshold, nameof(metricThreshold));
            Argument.AssertNotNull(productionData, nameof(productionData));
            Argument.AssertNotNull(referenceData, nameof(referenceData));

            MetricThreshold = metricThreshold;
            ProductionData = productionData.ToList();
            ReferenceData = referenceData;
            SignalType = MonitoringSignalType.FeatureAttributionDrift;
        }

        /// <summary> Initializes a new instance of <see cref="FeatureAttributionDriftMonitoringSignal"/>. </summary>
        /// <param name="mode"> The current notification mode for this signal. </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="signalType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="metricThreshold"> [Required] A list of metrics to calculate and their associated thresholds. </param>
        /// <param name="productionData">
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        /// <param name="referenceData">
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </param>
        internal FeatureAttributionDriftMonitoringSignal(MonitoringNotificationMode? mode, IDictionary<string, string> properties, MonitoringSignalType signalType, FeatureAttributionMetricThreshold metricThreshold, IList<MonitoringInputDataBase> productionData, MonitoringInputDataBase referenceData) : base(mode, properties, signalType)
        {
            MetricThreshold = metricThreshold;
            ProductionData = productionData;
            ReferenceData = referenceData;
            SignalType = signalType;
        }

        /// <summary> [Required] A list of metrics to calculate and their associated thresholds. </summary>
        public FeatureAttributionMetricThreshold MetricThreshold { get; set; }
        /// <summary>
        /// [Required] The data which drift will be calculated for.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public IList<MonitoringInputDataBase> ProductionData { get; }
        /// <summary>
        /// [Required] The data to calculate drift against.
        /// Please note <see cref="MonitoringInputDataBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FixedInputData"/>, <see cref="StaticInputData"/> and <see cref="TrailingInputData"/>.
        /// </summary>
        public MonitoringInputDataBase ReferenceData { get; set; }
    }
}
