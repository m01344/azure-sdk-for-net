// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatementOptions. </summary>
    public partial class SparkStatementOptions
    {
        /// <summary> Initializes a new instance of <see cref="SparkStatementOptions"/>. </summary>
        public SparkStatementOptions()
        {
        }

        /// <summary> Gets or sets the code. </summary>
        public string Code { get; set; }
        /// <summary> Gets or sets the kind. </summary>
        public SparkStatementLanguageType? Kind { get; set; }
    }
}
