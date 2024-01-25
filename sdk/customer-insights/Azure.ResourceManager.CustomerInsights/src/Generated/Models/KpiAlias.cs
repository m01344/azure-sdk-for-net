// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The KPI alias. </summary>
    public partial class KpiAlias
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

        /// <summary> Initializes a new instance of <see cref="KpiAlias"/>. </summary>
        /// <param name="aliasName"> KPI alias name. </param>
        /// <param name="expression"> The expression. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aliasName"/> or <paramref name="expression"/> is null. </exception>
        public KpiAlias(string aliasName, string expression)
        {
            Argument.AssertNotNull(aliasName, nameof(aliasName));
            Argument.AssertNotNull(expression, nameof(expression));

            AliasName = aliasName;
            Expression = expression;
        }

        /// <summary> Initializes a new instance of <see cref="KpiAlias"/>. </summary>
        /// <param name="aliasName"> KPI alias name. </param>
        /// <param name="expression"> The expression. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal KpiAlias(string aliasName, string expression, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AliasName = aliasName;
            Expression = expression;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="KpiAlias"/> for deserialization. </summary>
        internal KpiAlias()
        {
        }

        /// <summary> KPI alias name. </summary>
        public string AliasName { get; set; }
        /// <summary> The expression. </summary>
        public string Expression { get; set; }
    }
}
