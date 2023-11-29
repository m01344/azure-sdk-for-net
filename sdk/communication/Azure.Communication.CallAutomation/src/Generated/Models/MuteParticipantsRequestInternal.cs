// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    /// <summary> The request payload for muting participants from the call. </summary>
    internal partial class MuteParticipantsRequestInternal
    {
        /// <summary> Initializes a new instance of <see cref="MuteParticipantsRequestInternal"/>. </summary>
        /// <param name="targetParticipants">
        /// Participants to be muted from the call.
        /// Only ACS Users are supported.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetParticipants"/> is null. </exception>
        public MuteParticipantsRequestInternal(IEnumerable<CommunicationIdentifierModel> targetParticipants)
        {
            Argument.AssertNotNull(targetParticipants, nameof(targetParticipants));

            TargetParticipants = targetParticipants.ToList();
        }

        /// <summary>
        /// Participants to be muted from the call.
        /// Only ACS Users are supported.
        /// </summary>
        public IList<CommunicationIdentifierModel> TargetParticipants { get; }
        /// <summary> Used by customers when calling mid-call actions to correlate the request to the response event. </summary>
        public string OperationContext { get; set; }
    }
}
