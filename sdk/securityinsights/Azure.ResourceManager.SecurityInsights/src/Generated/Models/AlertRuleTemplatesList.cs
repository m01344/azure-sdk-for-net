// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List all the alert rule templates. </summary>
    internal partial class AlertRuleTemplatesList
    {
        /// <summary> Initializes a new instance of <see cref="AlertRuleTemplatesList"/>. </summary>
        /// <param name="value">
        /// Array of alert rule templates.
        /// Please note <see cref="SecurityInsightsAlertRuleTemplateData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsFusionAlertRuleTemplate"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRuleTemplate"/> and <see cref="ScheduledAlertRuleTemplate"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AlertRuleTemplatesList(IEnumerable<SecurityInsightsAlertRuleTemplateData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AlertRuleTemplatesList"/>. </summary>
        /// <param name="nextLink"> URL to fetch the next set of alert rule templates. </param>
        /// <param name="value">
        /// Array of alert rule templates.
        /// Please note <see cref="SecurityInsightsAlertRuleTemplateData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsFusionAlertRuleTemplate"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRuleTemplate"/> and <see cref="ScheduledAlertRuleTemplate"/>.
        /// </param>
        internal AlertRuleTemplatesList(string nextLink, IReadOnlyList<SecurityInsightsAlertRuleTemplateData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> URL to fetch the next set of alert rule templates. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Array of alert rule templates.
        /// Please note <see cref="SecurityInsightsAlertRuleTemplateData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecurityInsightsFusionAlertRuleTemplate"/>, <see cref="MicrosoftSecurityIncidentCreationAlertRuleTemplate"/> and <see cref="ScheduledAlertRuleTemplate"/>.
        /// </summary>
        public IReadOnlyList<SecurityInsightsAlertRuleTemplateData> Value { get; }
    }
}
