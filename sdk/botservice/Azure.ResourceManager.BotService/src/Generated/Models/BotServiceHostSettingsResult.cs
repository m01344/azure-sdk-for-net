// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.BotService.Models
{
    /// <summary> The response body returned for a request to Bot Service Management to check per subscription hostSettings. </summary>
    public partial class BotServiceHostSettingsResult
    {
        /// <summary> Initializes a new instance of <see cref="BotServiceHostSettingsResult"/>. </summary>
        internal BotServiceHostSettingsResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BotServiceHostSettingsResult"/>. </summary>
        /// <param name="oAuthUri"> For in-conversation bot user authentication. </param>
        /// <param name="toBotFromChannelOpenIdMetadataUri"> For verifying incoming tokens from the channels. </param>
        /// <param name="toBotFromChannelTokenIssuer"> For verifying incoming tokens from the channels. </param>
        /// <param name="toBotFromEmulatorOpenIdMetadataUri"> For verifying incoming tokens from bot emulator. </param>
        /// <param name="toChannelFromBotLoginUri"> For getting access token to channels from bot host. </param>
        /// <param name="toChannelFromBotOAuthScope"> For getting access token to channels from bot host. </param>
        /// <param name="validateAuthority"> Per cloud OAuth setting on whether authority is validated. </param>
        /// <param name="botOpenIdMetadata"> Same as toBotFromChannelOpenIdMetadataUrl, used by SDK &lt; v4.12. </param>
        internal BotServiceHostSettingsResult(Uri oAuthUri, Uri toBotFromChannelOpenIdMetadataUri, string toBotFromChannelTokenIssuer, Uri toBotFromEmulatorOpenIdMetadataUri, Uri toChannelFromBotLoginUri, string toChannelFromBotOAuthScope, bool? validateAuthority, string botOpenIdMetadata)
        {
            OAuthUri = oAuthUri;
            ToBotFromChannelOpenIdMetadataUri = toBotFromChannelOpenIdMetadataUri;
            ToBotFromChannelTokenIssuer = toBotFromChannelTokenIssuer;
            ToBotFromEmulatorOpenIdMetadataUri = toBotFromEmulatorOpenIdMetadataUri;
            ToChannelFromBotLoginUri = toChannelFromBotLoginUri;
            ToChannelFromBotOAuthScope = toChannelFromBotOAuthScope;
            ValidateAuthority = validateAuthority;
            BotOpenIdMetadata = botOpenIdMetadata;
        }

        /// <summary> For in-conversation bot user authentication. </summary>
        public Uri OAuthUri { get; }
        /// <summary> For verifying incoming tokens from the channels. </summary>
        public Uri ToBotFromChannelOpenIdMetadataUri { get; }
        /// <summary> For verifying incoming tokens from the channels. </summary>
        public string ToBotFromChannelTokenIssuer { get; }
        /// <summary> For verifying incoming tokens from bot emulator. </summary>
        public Uri ToBotFromEmulatorOpenIdMetadataUri { get; }
        /// <summary> For getting access token to channels from bot host. </summary>
        public Uri ToChannelFromBotLoginUri { get; }
        /// <summary> For getting access token to channels from bot host. </summary>
        public string ToChannelFromBotOAuthScope { get; }
        /// <summary> Per cloud OAuth setting on whether authority is validated. </summary>
        public bool? ValidateAuthority { get; }
        /// <summary> Same as toBotFromChannelOpenIdMetadataUrl, used by SDK &lt; v4.12. </summary>
        public string BotOpenIdMetadata { get; }
    }
}
