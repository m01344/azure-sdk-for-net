// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> ESU key. </summary>
    public partial class EsuKey
    {
        /// <summary> Initializes a new instance of <see cref="EsuKey"/>. </summary>
        internal EsuKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EsuKey"/>. </summary>
        /// <param name="sku"> SKU number. </param>
        /// <param name="licenseStatus"> The current status of the license profile key. </param>
        internal EsuKey(string sku, string licenseStatus)
        {
            Sku = sku;
            LicenseStatus = licenseStatus;
        }

        /// <summary> SKU number. </summary>
        public string Sku { get; }
        /// <summary> The current status of the license profile key. </summary>
        public string LicenseStatus { get; }
    }
}
