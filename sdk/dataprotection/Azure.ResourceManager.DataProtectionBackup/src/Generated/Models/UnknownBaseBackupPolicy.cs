// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownBaseBackupPolicy. </summary>
    internal partial class UnknownBaseBackupPolicy : DataProtectionBackupPolicyPropertiesBase
    {
        /// <summary> Initializes a new instance of <see cref="UnknownBaseBackupPolicy"/>. </summary>
        /// <param name="dataSourceTypes"> Type of datasource for the backup management. </param>
        /// <param name="objectType"></param>
        internal UnknownBaseBackupPolicy(IList<string> dataSourceTypes, string objectType) : base(dataSourceTypes, objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
