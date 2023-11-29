// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> Describes the properties of a Message Details resource. </summary>
    public partial class ChatTranscriptMessageProperties
    {
        /// <summary> Initializes a new instance of <see cref="ChatTranscriptMessageProperties"/>. </summary>
        /// <param name="body"> Body of the communication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        public ChatTranscriptMessageProperties(string body)
        {
            Argument.AssertNotNull(body, nameof(body));

            Body = body;
        }

        /// <summary> Initializes a new instance of <see cref="ChatTranscriptMessageProperties"/>. </summary>
        /// <param name="contentType"> Content type. </param>
        /// <param name="communicationDirection"> Direction of communication. </param>
        /// <param name="sender"> Name of the sender. </param>
        /// <param name="body"> Body of the communication. </param>
        /// <param name="createdOn"> Time in UTC (ISO 8601 format) when the communication was created. </param>
        internal ChatTranscriptMessageProperties(TranscriptContentType? contentType, SupportTicketCommunicationDirection? communicationDirection, string sender, string body, DateTimeOffset? createdOn)
        {
            ContentType = contentType;
            CommunicationDirection = communicationDirection;
            Sender = sender;
            Body = body;
            CreatedOn = createdOn;
        }

        /// <summary> Content type. </summary>
        public TranscriptContentType? ContentType { get; }
        /// <summary> Direction of communication. </summary>
        public SupportTicketCommunicationDirection? CommunicationDirection { get; }
        /// <summary> Name of the sender. </summary>
        public string Sender { get; set; }
        /// <summary> Body of the communication. </summary>
        public string Body { get; set; }
        /// <summary> Time in UTC (ISO 8601 format) when the communication was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
    }
}
