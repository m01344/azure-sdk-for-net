// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    /// <summary> Multivariate anomaly detection status. </summary>
    public partial class MultivariateBatchDetectionResultSummary
    {
        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionResultSummary"/>. </summary>
        /// <param name="status"> Status of detection results. </param>
        /// <param name="setupInfo">
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="setupInfo"/> is null. </exception>
        internal MultivariateBatchDetectionResultSummary(MultivariateBatchDetectionStatus status, MultivariateBatchDetectionOptions setupInfo)
        {
            Argument.AssertNotNull(setupInfo, nameof(setupInfo));

            Status = status;
            Errors = new ChangeTrackingList<ErrorResponse>();
            VariableStates = new ChangeTrackingList<VariableState>();
            SetupInfo = setupInfo;
        }

        /// <summary> Initializes a new instance of <see cref="MultivariateBatchDetectionResultSummary"/>. </summary>
        /// <param name="status"> Status of detection results. </param>
        /// <param name="errors"> Error message when detection fails. </param>
        /// <param name="variableStates"> Variable status. </param>
        /// <param name="setupInfo">
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </param>
        internal MultivariateBatchDetectionResultSummary(MultivariateBatchDetectionStatus status, IReadOnlyList<ErrorResponse> errors, IReadOnlyList<VariableState> variableStates, MultivariateBatchDetectionOptions setupInfo)
        {
            Status = status;
            Errors = errors;
            VariableStates = variableStates;
            SetupInfo = setupInfo;
        }

        /// <summary> Status of detection results. </summary>
        public MultivariateBatchDetectionStatus Status { get; }
        /// <summary> Error message when detection fails. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        /// <summary> Variable status. </summary>
        public IReadOnlyList<VariableState> VariableStates { get; }
        /// <summary>
        /// Detection request for batch inference. This is an asynchronous inference that
        /// will need another API to get detection results.
        /// </summary>
        public MultivariateBatchDetectionOptions SetupInfo { get; }
    }
}
