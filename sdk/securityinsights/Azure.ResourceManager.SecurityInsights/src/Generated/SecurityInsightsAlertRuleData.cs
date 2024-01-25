// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsAlertRule data model.
    /// Alert rule.
    /// Please note <see cref="SecurityInsightsAlertRuleData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SecurityInsightsFusionAlertRule"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRule"/> and <see cref="SecurityInsightsScheduledAlertRule"/>.
    /// </summary>
    public partial class SecurityInsightsAlertRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertRuleData"/>. </summary>
        public SecurityInsightsAlertRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The alert rule kind. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        internal SecurityInsightsAlertRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AlertRuleKind kind, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            ETag = etag;
        }

        /// <summary> The alert rule kind. </summary>
        internal AlertRuleKind Kind { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
