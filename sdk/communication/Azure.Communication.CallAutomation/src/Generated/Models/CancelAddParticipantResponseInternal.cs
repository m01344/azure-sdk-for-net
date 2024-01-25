// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> Response payload for cancel add participant request. </summary>
    internal partial class CancelAddParticipantResponseInternal
    {
        /// <summary> Initializes a new instance of <see cref="CancelAddParticipantResponseInternal"/>. </summary>
        internal CancelAddParticipantResponseInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CancelAddParticipantResponseInternal"/>. </summary>
        /// <param name="invitationId"> Invitation ID used to cancel the add participant action. </param>
        /// <param name="operationContext"> The operation context provided by client. </param>
        internal CancelAddParticipantResponseInternal(string invitationId, string operationContext)
        {
            InvitationId = invitationId;
            OperationContext = operationContext;
        }

        /// <summary> Invitation ID used to cancel the add participant action. </summary>
        public string InvitationId { get; }
        /// <summary> The operation context provided by client. </summary>
        public string OperationContext { get; }
    }
}
