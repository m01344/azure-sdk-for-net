// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ApiManagement;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Paged AccessInformation list representation. </summary>
    internal partial class TenantSettingsListResult
    {
        /// <summary> Initializes a new instance of <see cref="TenantSettingsListResult"/>. </summary>
        internal TenantSettingsListResult()
        {
            Value = new ChangeTrackingList<ApiManagementTenantSettingData>();
        }

        /// <summary> Initializes a new instance of <see cref="TenantSettingsListResult"/>. </summary>
        /// <param name="value"> Page values. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        internal TenantSettingsListResult(IReadOnlyList<ApiManagementTenantSettingData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Page values. </summary>
        public IReadOnlyList<ApiManagementTenantSettingData> Value { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
