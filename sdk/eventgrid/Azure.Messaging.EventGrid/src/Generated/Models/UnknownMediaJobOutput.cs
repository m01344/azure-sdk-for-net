// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Messaging.EventGrid.SystemEvents;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> The UnknownMediaJobOutput. </summary>
    internal partial class UnknownMediaJobOutput : MediaJobOutput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMediaJobOutput"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="error"> Gets the Job output error. </param>
        /// <param name="label"> Gets the Job output label. </param>
        /// <param name="progress"> Gets the Job output progress. </param>
        /// <param name="state"> Gets the Job output state. </param>
        internal UnknownMediaJobOutput(string odataType, MediaJobError error, string label, long progress, MediaJobState state) : base(odataType, error, label, progress, state)
        {
            OdataType = odataType ?? "Unknown";
        }
    }
}
