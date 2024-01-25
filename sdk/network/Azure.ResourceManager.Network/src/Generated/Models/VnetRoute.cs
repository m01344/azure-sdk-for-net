// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of routes that control routing from VirtualHub into a virtual network connection. </summary>
    public partial class VnetRoute
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

        /// <summary> Initializes a new instance of <see cref="VnetRoute"/>. </summary>
        public VnetRoute()
        {
            StaticRoutes = new ChangeTrackingList<StaticRoute>();
            BgpConnections = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="VnetRoute"/>. </summary>
        /// <param name="staticRoutesConfig"> Configuration for static routes on this HubVnetConnection. </param>
        /// <param name="staticRoutes"> List of all Static Routes. </param>
        /// <param name="bgpConnections"> The list of references to HubBgpConnection objects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VnetRoute(StaticRoutesConfig staticRoutesConfig, IList<StaticRoute> staticRoutes, IReadOnlyList<WritableSubResource> bgpConnections, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StaticRoutesConfig = staticRoutesConfig;
            StaticRoutes = staticRoutes;
            BgpConnections = bgpConnections;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Configuration for static routes on this HubVnetConnection. </summary>
        public StaticRoutesConfig StaticRoutesConfig { get; set; }
        /// <summary> List of all Static Routes. </summary>
        public IList<StaticRoute> StaticRoutes { get; }
        /// <summary> The list of references to HubBgpConnection objects. </summary>
        public IReadOnlyList<WritableSubResource> BgpConnections { get; }
    }
}
