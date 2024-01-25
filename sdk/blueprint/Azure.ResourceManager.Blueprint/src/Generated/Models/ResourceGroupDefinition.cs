// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Represents an Azure resource group in a blueprint definition. </summary>
    public partial class ResourceGroupDefinition
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

        /// <summary> Initializes a new instance of <see cref="ResourceGroupDefinition"/>. </summary>
        public ResourceGroupDefinition()
        {
            DependsOn = new ChangeTrackingList<string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceGroupDefinition"/>. </summary>
        /// <param name="name"> Name of this resourceGroup. Leave empty if the resource group name will be specified during the blueprint assignment. </param>
        /// <param name="location"> Location of this resourceGroup. Leave empty if the resource group location will be specified during the blueprint assignment. </param>
        /// <param name="dependsOn"> Artifacts which need to be deployed before this resource group. </param>
        /// <param name="tags"> Tags to be assigned to this resource group. </param>
        /// <param name="displayName"> DisplayName of this parameter/resourceGroup. </param>
        /// <param name="description"> Description of this parameter/resourceGroup. </param>
        /// <param name="strongType"> StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceGroupDefinition(string name, AzureLocation? location, IList<string> dependsOn, IDictionary<string, string> tags, string displayName, string description, string strongType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Location = location;
            DependsOn = dependsOn;
            Tags = tags;
            DisplayName = displayName;
            Description = description;
            StrongType = strongType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of this resourceGroup. Leave empty if the resource group name will be specified during the blueprint assignment. </summary>
        public string Name { get; set; }
        /// <summary> Location of this resourceGroup. Leave empty if the resource group location will be specified during the blueprint assignment. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Artifacts which need to be deployed before this resource group. </summary>
        public IList<string> DependsOn { get; }
        /// <summary> Tags to be assigned to this resource group. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> DisplayName of this parameter/resourceGroup. </summary>
        public string DisplayName { get; set; }
        /// <summary> Description of this parameter/resourceGroup. </summary>
        public string Description { get; set; }
        /// <summary> StrongType for UI to render rich experience during blueprint assignment. Supported strong types are resourceType, principalId and location. </summary>
        public string StrongType { get; set; }
    }
}
