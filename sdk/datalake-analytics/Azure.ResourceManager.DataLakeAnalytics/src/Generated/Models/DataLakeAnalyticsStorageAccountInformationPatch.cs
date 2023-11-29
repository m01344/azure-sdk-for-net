// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to update an Azure Storage account.
    /// Serialized Name: UpdateStorageAccountParameters
    /// </summary>
    public partial class DataLakeAnalyticsStorageAccountInformationPatch
    {
        /// <summary> Initializes a new instance of <see cref="DataLakeAnalyticsStorageAccountInformationPatch"/>. </summary>
        public DataLakeAnalyticsStorageAccountInformationPatch()
        {
        }

        /// <summary>
        /// The updated access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: UpdateStorageAccountParameters.properties.accessKey
        /// </summary>
        public string AccessKey { get; set; }
        /// <summary>
        /// The optional suffix for the storage account.
        /// Serialized Name: UpdateStorageAccountParameters.properties.suffix
        /// </summary>
        public string Suffix { get; set; }
    }
}
