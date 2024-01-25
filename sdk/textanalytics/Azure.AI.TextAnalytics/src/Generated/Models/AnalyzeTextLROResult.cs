// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary>
    /// The AnalyzeTextLROResult.
    /// Please note <see cref="AnalyzeTextLROResult"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AbstractiveSummarizationLROResult"/>, <see cref="CustomEntityRecognitionLROResult"/>, <see cref="CustomMultiLabelClassificationLROResult"/>, <see cref="CustomSingleLabelClassificationLROResult"/>, <see cref="EntityLinkingLROResult"/>, <see cref="EntityRecognitionLROResult"/>, <see cref="ExtractiveSummarizationLROResult"/>, <see cref="HealthcareLROResult"/>, <see cref="KeyPhraseExtractionLROResult"/>, <see cref="PiiEntityRecognitionLROResult"/> and <see cref="SentimentLROResult"/>.
    /// </summary>
    internal abstract partial class AnalyzeTextLROResult : TaskState
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeTextLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        protected AnalyzeTextLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status) : base(lastUpdateDateTime, status)
        {
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextLROResult"/>. </summary>
        /// <param name="lastUpdateDateTime"></param>
        /// <param name="status"></param>
        /// <param name="kind"> Enumeration of supported Text Analysis long-running operation task results. </param>
        /// <param name="taskName"></param>
        internal AnalyzeTextLROResult(DateTimeOffset lastUpdateDateTime, TextAnalyticsOperationStatus status, AnalyzeTextLROResultsKind kind, string taskName) : base(lastUpdateDateTime, status)
        {
            Kind = kind;
            TaskName = taskName;
        }

        /// <summary> Enumeration of supported Text Analysis long-running operation task results. </summary>
        internal AnalyzeTextLROResultsKind Kind { get; set; }
        /// <summary> Gets or sets the task name. </summary>
        public string TaskName { get; set; }
    }
}
