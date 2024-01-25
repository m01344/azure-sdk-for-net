// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> A list of the server's security alert policies. </summary>
    internal partial class MySqlServerSecurityAlertPolicyListResult
    {
        /// <summary> Initializes a new instance of <see cref="MySqlServerSecurityAlertPolicyListResult"/>. </summary>
        internal MySqlServerSecurityAlertPolicyListResult()
        {
            Value = new ChangeTrackingList<MySqlServerSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="MySqlServerSecurityAlertPolicyListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal MySqlServerSecurityAlertPolicyListResult(IReadOnlyList<MySqlServerSecurityAlertPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<MySqlServerSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
