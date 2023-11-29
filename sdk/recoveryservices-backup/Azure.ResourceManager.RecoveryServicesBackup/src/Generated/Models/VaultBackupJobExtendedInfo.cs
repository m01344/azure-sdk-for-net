// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Vault Job for CMK - has CMK specific info. </summary>
    internal partial class VaultBackupJobExtendedInfo
    {
        /// <summary> Initializes a new instance of <see cref="VaultBackupJobExtendedInfo"/>. </summary>
        public VaultBackupJobExtendedInfo()
        {
            PropertyBag = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="VaultBackupJobExtendedInfo"/>. </summary>
        /// <param name="propertyBag"> Job properties. </param>
        internal VaultBackupJobExtendedInfo(IDictionary<string, string> propertyBag)
        {
            PropertyBag = propertyBag;
        }

        /// <summary> Job properties. </summary>
        public IDictionary<string, string> PropertyBag { get; }
    }
}
