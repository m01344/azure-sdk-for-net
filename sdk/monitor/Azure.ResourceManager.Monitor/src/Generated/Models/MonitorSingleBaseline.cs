// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The baseline values for a single sensitivity value. </summary>
    public partial class MonitorSingleBaseline
    {
        /// <summary> Initializes a new instance of <see cref="MonitorSingleBaseline"/>. </summary>
        /// <param name="sensitivity"> the sensitivity of the baseline. </param>
        /// <param name="lowThresholds"> The low thresholds of the baseline. </param>
        /// <param name="highThresholds"> The high thresholds of the baseline. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="lowThresholds"/> or <paramref name="highThresholds"/> is null. </exception>
        internal MonitorSingleBaseline(MonitorBaselineSensitivity sensitivity, IEnumerable<double> lowThresholds, IEnumerable<double> highThresholds)
        {
            Argument.AssertNotNull(lowThresholds, nameof(lowThresholds));
            Argument.AssertNotNull(highThresholds, nameof(highThresholds));

            Sensitivity = sensitivity;
            LowThresholds = lowThresholds.ToList();
            HighThresholds = highThresholds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorSingleBaseline"/>. </summary>
        /// <param name="sensitivity"> the sensitivity of the baseline. </param>
        /// <param name="lowThresholds"> The low thresholds of the baseline. </param>
        /// <param name="highThresholds"> The high thresholds of the baseline. </param>
        internal MonitorSingleBaseline(MonitorBaselineSensitivity sensitivity, IReadOnlyList<double> lowThresholds, IReadOnlyList<double> highThresholds)
        {
            Sensitivity = sensitivity;
            LowThresholds = lowThresholds;
            HighThresholds = highThresholds;
        }

        /// <summary> the sensitivity of the baseline. </summary>
        public MonitorBaselineSensitivity Sensitivity { get; }
        /// <summary> The low thresholds of the baseline. </summary>
        public IReadOnlyList<double> LowThresholds { get; }
        /// <summary> The high thresholds of the baseline. </summary>
        public IReadOnlyList<double> HighThresholds { get; }
    }
}
