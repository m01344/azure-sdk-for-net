// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearningCompute.Models
{
    /// <summary> Information about updates available for system services in a cluster. </summary>
    public partial class CheckSystemServicesUpdatesAvailableResponse
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CheckSystemServicesUpdatesAvailableResponse"/>. </summary>
        internal CheckSystemServicesUpdatesAvailableResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CheckSystemServicesUpdatesAvailableResponse"/>. </summary>
        /// <param name="updatesAvailable"> Yes if updates are available for the system services, No if not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CheckSystemServicesUpdatesAvailableResponse(UpdatesAvailable? updatesAvailable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UpdatesAvailable = updatesAvailable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Yes if updates are available for the system services, No if not. </summary>
        public UpdatesAvailable? UpdatesAvailable { get; }
    }
}
