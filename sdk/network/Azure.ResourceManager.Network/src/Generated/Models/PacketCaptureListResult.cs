// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of packet capture sessions. </summary>
    internal partial class PacketCaptureListResult
    {
        /// <summary> Initializes a new instance of PacketCaptureListResult. </summary>
        internal PacketCaptureListResult()
        {
            Value = new ChangeTrackingList<PacketCaptureData>();
        }

        /// <summary> Initializes a new instance of PacketCaptureListResult. </summary>
        /// <param name="value"> Information about packet capture sessions. </param>
        internal PacketCaptureListResult(IReadOnlyList<PacketCaptureData> value)
        {
            Value = value;
        }

        /// <summary> Information about packet capture sessions. </summary>
        public IReadOnlyList<PacketCaptureData> Value { get; }
    }
}
