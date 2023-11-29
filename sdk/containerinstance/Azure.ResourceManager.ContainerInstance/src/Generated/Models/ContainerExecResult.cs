// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The information for the container exec command. </summary>
    public partial class ContainerExecResult
    {
        /// <summary> Initializes a new instance of <see cref="ContainerExecResult"/>. </summary>
        internal ContainerExecResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerExecResult"/>. </summary>
        /// <param name="webSocketUri"> The uri for the exec websocket. </param>
        /// <param name="password"> The password to start the exec command. </param>
        internal ContainerExecResult(Uri webSocketUri, string password)
        {
            WebSocketUri = webSocketUri;
            Password = password;
        }

        /// <summary> The uri for the exec websocket. </summary>
        public Uri WebSocketUri { get; }
        /// <summary> The password to start the exec command. </summary>
        public string Password { get; }
    }
}
