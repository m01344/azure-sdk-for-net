// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> Options for DTMF recognition. </summary>
    internal partial class DtmfOptionsInternal
    {
        /// <summary> Initializes a new instance of <see cref="DtmfOptionsInternal"/>. </summary>
        public DtmfOptionsInternal()
        {
            StopTones = new ChangeTrackingList<DtmfTone>();
        }

        /// <summary> Time to wait between DTMF inputs to stop recognizing. </summary>
        public int? InterToneTimeoutInSeconds { get; set; }
        /// <summary> Maximum number of DTMF tones to be collected. </summary>
        public int? MaxTonesToCollect { get; set; }
    }
}
