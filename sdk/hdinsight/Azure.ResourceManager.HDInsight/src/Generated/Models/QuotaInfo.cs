// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The quota properties for the cluster. </summary>
    internal partial class QuotaInfo
    {
        /// <summary> Initializes a new instance of <see cref="QuotaInfo"/>. </summary>
        public QuotaInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaInfo"/>. </summary>
        /// <param name="coresUsed"> The cores used by the cluster. </param>
        internal QuotaInfo(int? coresUsed)
        {
            CoresUsed = coresUsed;
        }

        /// <summary> The cores used by the cluster. </summary>
        public int? CoresUsed { get; set; }
    }
}
