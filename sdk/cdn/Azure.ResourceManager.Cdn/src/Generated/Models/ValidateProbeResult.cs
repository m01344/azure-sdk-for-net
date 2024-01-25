// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Output of the validate probe API. </summary>
    public partial class ValidateProbeResult
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

        /// <summary> Initializes a new instance of <see cref="ValidateProbeResult"/>. </summary>
        internal ValidateProbeResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ValidateProbeResult"/>. </summary>
        /// <param name="isValid"> Indicates whether the probe URL is accepted or not. </param>
        /// <param name="errorCode"> Specifies the error code when the probe url is not accepted. </param>
        /// <param name="message"> The detailed error message describing why the probe URL is not accepted. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ValidateProbeResult(bool? isValid, string errorCode, string message, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsValid = isValid;
            ErrorCode = errorCode;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Indicates whether the probe URL is accepted or not. </summary>
        public bool? IsValid { get; }
        /// <summary> Specifies the error code when the probe url is not accepted. </summary>
        public string ErrorCode { get; }
        /// <summary> The detailed error message describing why the probe URL is not accepted. </summary>
        public string Message { get; }
    }
}
