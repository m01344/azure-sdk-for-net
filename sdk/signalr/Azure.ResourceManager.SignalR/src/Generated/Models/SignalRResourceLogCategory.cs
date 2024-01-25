// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Resource log category configuration of a Microsoft.SignalRService resource. </summary>
    public partial class SignalRResourceLogCategory
    {
        /// <summary> Initializes a new instance of <see cref="SignalRResourceLogCategory"/>. </summary>
        public SignalRResourceLogCategory()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRResourceLogCategory"/>. </summary>
        /// <param name="name">
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </param>
        /// <param name="enabled">
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </param>
        internal SignalRResourceLogCategory(string name, string enabled)
        {
            Name = name;
            Enabled = enabled;
        }

        /// <summary>
        /// Gets or sets the resource log category's name.
        /// Available values: ConnectivityLogs, MessagingLogs.
        /// Case insensitive.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether or the resource log category is enabled.
        /// Available values: true, false.
        /// Case insensitive.
        /// </summary>
        public string Enabled { get; set; }
    }
}
