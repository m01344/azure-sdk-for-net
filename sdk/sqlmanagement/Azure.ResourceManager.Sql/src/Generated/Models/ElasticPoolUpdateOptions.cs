// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An elastic pool update. </summary>
    public partial class ElasticPoolUpdateOptions
    {
        /// <summary> Initializes a new instance of ElasticPoolUpdateOptions. </summary>
        public ElasticPoolUpdateOptions()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> An ARM Resource SKU. </summary>
        public Sku Sku { get; set; }
        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The storage limit for the database elastic pool in bytes. </summary>
        public long? MaxSizeBytes { get; set; }
        /// <summary> The per database settings for the elastic pool. </summary>
        public ElasticPoolPerDatabaseSettings PerDatabaseSettings { get; set; }
        /// <summary> Whether or not this elastic pool is zone redundant, which means the replicas of this elastic pool will be spread across multiple availability zones. </summary>
        public bool? ZoneRedundant { get; set; }
        /// <summary> The license type to apply for this elastic pool. </summary>
        public ElasticPoolLicenseType? LicenseType { get; set; }
        /// <summary> Maintenance configuration id assigned to the elastic pool. This configuration defines the period when the maintenance updates will will occur. </summary>
        public string MaintenanceConfigurationId { get; set; }
    }
}
