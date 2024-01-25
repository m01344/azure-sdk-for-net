// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the DataMaskingPolicy data model.
    /// Represents a database data masking policy.
    /// </summary>
    public partial class DataMaskingPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="DataMaskingPolicyData"/>. </summary>
        public DataMaskingPolicyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataMaskingPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> The location of the data masking policy. </param>
        /// <param name="kind"> The kind of data masking policy. Metadata, used for Azure portal. </param>
        /// <param name="dataMaskingState"> The state of the data masking policy. </param>
        /// <param name="exemptPrincipals"> The list of the exempt principals. Specifies the semicolon-separated list of database users for which the data masking policy does not apply. The specified users receive data results without masking for all of the database queries. </param>
        /// <param name="applicationPrincipals"> The list of the application principals. This is a legacy parameter and is no longer used. </param>
        /// <param name="maskingLevel"> The masking level. This is a legacy parameter and is no longer used. </param>
        internal DataMaskingPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, string kind, DataMaskingState? dataMaskingState, string exemptPrincipals, string applicationPrincipals, string maskingLevel) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Kind = kind;
            DataMaskingState = dataMaskingState;
            ExemptPrincipals = exemptPrincipals;
            ApplicationPrincipals = applicationPrincipals;
            MaskingLevel = maskingLevel;
        }

        /// <summary> The location of the data masking policy. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The kind of data masking policy. Metadata, used for Azure portal. </summary>
        public string Kind { get; }
        /// <summary> The state of the data masking policy. </summary>
        public DataMaskingState? DataMaskingState { get; set; }
        /// <summary> The list of the exempt principals. Specifies the semicolon-separated list of database users for which the data masking policy does not apply. The specified users receive data results without masking for all of the database queries. </summary>
        public string ExemptPrincipals { get; set; }
        /// <summary> The list of the application principals. This is a legacy parameter and is no longer used. </summary>
        public string ApplicationPrincipals { get; }
        /// <summary> The masking level. This is a legacy parameter and is no longer used. </summary>
        public string MaskingLevel { get; }
    }
}
