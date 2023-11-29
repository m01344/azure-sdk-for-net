// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Billing plan information. </summary>
    public partial class FirewallBillingPlanInfo
    {
        /// <summary> Initializes a new instance of <see cref="FirewallBillingPlanInfo"/>. </summary>
        /// <param name="billingCycle"> different billing cycles like MONTHLY/WEEKLY. </param>
        /// <param name="planId"> plan id as published by Liftr.PAN. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="planId"/> is null. </exception>
        public FirewallBillingPlanInfo(FirewallBillingCycle billingCycle, string planId)
        {
            Argument.AssertNotNull(planId, nameof(planId));

            BillingCycle = billingCycle;
            PlanId = planId;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallBillingPlanInfo"/>. </summary>
        /// <param name="usageType"> different usage type like PAYG/COMMITTED. </param>
        /// <param name="billingCycle"> different billing cycles like MONTHLY/WEEKLY. </param>
        /// <param name="planId"> plan id as published by Liftr.PAN. </param>
        /// <param name="effectiveOn"> date when plan was applied. </param>
        internal FirewallBillingPlanInfo(FirewallBillingPlanUsageType? usageType, FirewallBillingCycle billingCycle, string planId, DateTimeOffset? effectiveOn)
        {
            UsageType = usageType;
            BillingCycle = billingCycle;
            PlanId = planId;
            EffectiveOn = effectiveOn;
        }

        /// <summary> different usage type like PAYG/COMMITTED. </summary>
        public FirewallBillingPlanUsageType? UsageType { get; set; }
        /// <summary> different billing cycles like MONTHLY/WEEKLY. </summary>
        public FirewallBillingCycle BillingCycle { get; set; }
        /// <summary> plan id as published by Liftr.PAN. </summary>
        public string PlanId { get; set; }
        /// <summary> date when plan was applied. </summary>
        public DateTimeOffset? EffectiveOn { get; }
    }
}
