// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing the AdaptiveNetworkHardening data model.
    /// The resource whose properties describes the Adaptive Network Hardening settings for some Azure resource
    /// </summary>
    public partial class AdaptiveNetworkHardeningData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningData"/>. </summary>
        public AdaptiveNetworkHardeningData()
        {
            Rules = new ChangeTrackingList<RecommendedSecurityRule>();
            EffectiveNetworkSecurityGroups = new ChangeTrackingList<EffectiveNetworkSecurityGroups>();
        }

        /// <summary> Initializes a new instance of <see cref="AdaptiveNetworkHardeningData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rules"> The security rules which are recommended to be effective on the VM. </param>
        /// <param name="rulesCalculatedOn"> The UTC time on which the rules were calculated. </param>
        /// <param name="effectiveNetworkSecurityGroups"> The Network Security Groups effective on the network interfaces of the protected resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AdaptiveNetworkHardeningData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<RecommendedSecurityRule> rules, DateTimeOffset? rulesCalculatedOn, IList<EffectiveNetworkSecurityGroups> effectiveNetworkSecurityGroups, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Rules = rules;
            RulesCalculatedOn = rulesCalculatedOn;
            EffectiveNetworkSecurityGroups = effectiveNetworkSecurityGroups;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The security rules which are recommended to be effective on the VM. </summary>
        public IList<RecommendedSecurityRule> Rules { get; }
        /// <summary> The UTC time on which the rules were calculated. </summary>
        public DateTimeOffset? RulesCalculatedOn { get; set; }
        /// <summary> The Network Security Groups effective on the network interfaces of the protected resource. </summary>
        public IList<EffectiveNetworkSecurityGroups> EffectiveNetworkSecurityGroups { get; }
    }
}
