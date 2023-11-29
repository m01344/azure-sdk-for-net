// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    /// <summary> The SavingsPlanUpdateValidateContent. </summary>
    public partial class SavingsPlanUpdateValidateContent
    {
        /// <summary> Initializes a new instance of <see cref="SavingsPlanUpdateValidateContent"/>. </summary>
        public SavingsPlanUpdateValidateContent()
        {
            Benefits = new ChangeTrackingList<BillingBenefitsSavingsPlanPatchProperties>();
        }

        /// <summary> Gets the benefits. </summary>
        public IList<BillingBenefitsSavingsPlanPatchProperties> Benefits { get; }
    }
}
