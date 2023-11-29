// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Username and password credentials. </summary>
    public partial class UsernamePasswordCredentials : CredentialsBase
    {
        /// <summary> Initializes a new instance of <see cref="UsernamePasswordCredentials"/>. </summary>
        /// <param name="username"> Username to be presented as part of the credentials. </param>
        /// <param name="password"> Password to be presented as part of the credentials. It is recommended that this value is parameterized as a secret string in order to prevent this value to be returned as part of the resource on API requests. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="username"/> or <paramref name="password"/> is null. </exception>
        public UsernamePasswordCredentials(string username, string password)
        {
            Argument.AssertNotNull(username, nameof(username));
            Argument.AssertNotNull(password, nameof(password));

            Username = username;
            Password = password;
            Type = "#Microsoft.VideoAnalyzer.UsernamePasswordCredentials";
        }

        /// <summary> Initializes a new instance of <see cref="UsernamePasswordCredentials"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="username"> Username to be presented as part of the credentials. </param>
        /// <param name="password"> Password to be presented as part of the credentials. It is recommended that this value is parameterized as a secret string in order to prevent this value to be returned as part of the resource on API requests. </param>
        internal UsernamePasswordCredentials(string type, string username, string password) : base(type)
        {
            Username = username;
            Password = password;
            Type = type ?? "#Microsoft.VideoAnalyzer.UsernamePasswordCredentials";
        }

        /// <summary> Username to be presented as part of the credentials. </summary>
        public string Username { get; set; }
        /// <summary> Password to be presented as part of the credentials. It is recommended that this value is parameterized as a secret string in order to prevent this value to be returned as part of the resource on API requests. </summary>
        public string Password { get; set; }
    }
}
