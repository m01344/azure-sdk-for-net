// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> Site information for WebChat or DirectLine Channels to identify which site to regenerate keys for. </summary>
    public partial class BotChannelRegenerateKeysContent
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

        /// <summary> Initializes a new instance of <see cref="BotChannelRegenerateKeysContent"/>. </summary>
        /// <param name="siteName"> The site name. </param>
        /// <param name="key"> Determines which key is to be regenerated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> is null. </exception>
        public BotChannelRegenerateKeysContent(string siteName, BotServiceKey key)
        {
            Argument.AssertNotNull(siteName, nameof(siteName));

            SiteName = siteName;
            Key = key;
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelRegenerateKeysContent"/>. </summary>
        /// <param name="siteName"> The site name. </param>
        /// <param name="key"> Determines which key is to be regenerated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BotChannelRegenerateKeysContent(string siteName, BotServiceKey key, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SiteName = siteName;
            Key = key;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BotChannelRegenerateKeysContent"/> for deserialization. </summary>
        internal BotChannelRegenerateKeysContent()
        {
        }

        /// <summary> The site name. </summary>
        public string SiteName { get; }
        /// <summary> Determines which key is to be regenerated. </summary>
        public BotServiceKey Key { get; }
    }
}
