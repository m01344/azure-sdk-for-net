// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The EncryptionUpdateProperties. </summary>
    public partial class EncryptionUpdateProperties
    {
        /// <summary> Initializes a new instance of <see cref="EncryptionUpdateProperties"/>. </summary>
        /// <param name="keyVaultProperties"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVaultProperties"/> is null. </exception>
        public EncryptionUpdateProperties(EncryptionKeyVaultUpdateProperties keyVaultProperties)
        {
            Argument.AssertNotNull(keyVaultProperties, nameof(keyVaultProperties));

            KeyVaultProperties = keyVaultProperties;
        }

        /// <summary> Gets the key vault properties. </summary>
        internal EncryptionKeyVaultUpdateProperties KeyVaultProperties { get; }
        /// <summary> Gets the key identifier. </summary>
        public string KeyIdentifier
        {
            get => KeyVaultProperties?.KeyIdentifier;
        }
    }
}
