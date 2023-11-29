// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> KeySetUser represents the properties of the user in the key set. </summary>
    public partial class KeySetUser
    {
        /// <summary> Initializes a new instance of <see cref="KeySetUser"/>. </summary>
        /// <param name="azureUserName"> The user name that will be used for access. </param>
        /// <param name="sshPublicKey"> The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private key for logging in. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureUserName"/> or <paramref name="sshPublicKey"/> is null. </exception>
        public KeySetUser(string azureUserName, NetworkCloudSshPublicKey sshPublicKey)
        {
            Argument.AssertNotNull(azureUserName, nameof(azureUserName));
            Argument.AssertNotNull(sshPublicKey, nameof(sshPublicKey));

            AzureUserName = azureUserName;
            SshPublicKey = sshPublicKey;
        }

        /// <summary> Initializes a new instance of <see cref="KeySetUser"/>. </summary>
        /// <param name="azureUserName"> The user name that will be used for access. </param>
        /// <param name="description"> The free-form description for this user. </param>
        /// <param name="sshPublicKey"> The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private key for logging in. </param>
        internal KeySetUser(string azureUserName, string description, NetworkCloudSshPublicKey sshPublicKey)
        {
            AzureUserName = azureUserName;
            Description = description;
            SshPublicKey = sshPublicKey;
        }

        /// <summary> The user name that will be used for access. </summary>
        public string AzureUserName { get; set; }
        /// <summary> The free-form description for this user. </summary>
        public string Description { get; set; }
        /// <summary> The SSH public key that will be provisioned for user access. The user is expected to have the corresponding SSH private key for logging in. </summary>
        internal NetworkCloudSshPublicKey SshPublicKey { get; set; }
        /// <summary> The SSH public key data. </summary>
        public string KeyData
        {
            get => SshPublicKey is null ? default : SshPublicKey.KeyData;
            set => SshPublicKey = new NetworkCloudSshPublicKey(value);
        }
    }
}
