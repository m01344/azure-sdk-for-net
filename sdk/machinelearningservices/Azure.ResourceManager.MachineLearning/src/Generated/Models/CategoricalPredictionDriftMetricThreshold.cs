// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The CategoricalPredictionDriftMetricThreshold. </summary>
    public partial class CategoricalPredictionDriftMetricThreshold : PredictionDriftMetricThresholdBase
    {
        /// <summary> Initializes a new instance of <see cref="CategoricalPredictionDriftMetricThreshold"/>. </summary>
        /// <param name="metric"> [Required] The categorical prediction drift metric to calculate. </param>
        public CategoricalPredictionDriftMetricThreshold(CategoricalPredictionDriftMetric metric)
        {
            Metric = metric;
            DataType = MonitoringFeatureDataType.Categorical;
        }

        /// <summary> Initializes a new instance of <see cref="CategoricalPredictionDriftMetricThreshold"/>. </summary>
        /// <param name="dataType"> [Required] Specifies the data type of the metric threshold. </param>
        /// <param name="threshold"> The threshold value. If null, a default value will be set depending on the selected metric. </param>
        /// <param name="metric"> [Required] The categorical prediction drift metric to calculate. </param>
        internal CategoricalPredictionDriftMetricThreshold(MonitoringFeatureDataType dataType, MonitoringThreshold threshold, CategoricalPredictionDriftMetric metric) : base(dataType, threshold)
        {
            Metric = metric;
            DataType = dataType;
        }

        /// <summary> [Required] The categorical prediction drift metric to calculate. </summary>
        public CategoricalPredictionDriftMetric Metric { get; set; }
    }
}
