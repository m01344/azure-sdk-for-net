// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SelfHelp.Models;

namespace Azure.ResourceManager.SelfHelp
{
    /// <summary>
    /// A class representing the TroubleshooterResource data model.
    /// Troubleshooter response.
    /// </summary>
    public partial class TroubleshooterResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="TroubleshooterResourceData"/>. </summary>
        public TroubleshooterResourceData()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
            Steps = new ChangeTrackingList<SelfHelpStep>();
        }

        /// <summary> Initializes a new instance of <see cref="TroubleshooterResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="solutionId"> Solution Id to identify single troubleshooter. </param>
        /// <param name="parameters"> Client input parameters to run Troubleshooter Resource. </param>
        /// <param name="provisioningState"> Status of troubleshooter provisioning. </param>
        /// <param name="steps"> List of step object. </param>
        internal TroubleshooterResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string solutionId, IDictionary<string, string> parameters, TroubleshooterProvisioningState? provisioningState, IReadOnlyList<SelfHelpStep> steps) : base(id, name, resourceType, systemData)
        {
            SolutionId = solutionId;
            Parameters = parameters;
            ProvisioningState = provisioningState;
            Steps = steps;
        }

        /// <summary> Solution Id to identify single troubleshooter. </summary>
        public string SolutionId { get; set; }
        /// <summary> Client input parameters to run Troubleshooter Resource. </summary>
        public IDictionary<string, string> Parameters { get; }
        /// <summary> Status of troubleshooter provisioning. </summary>
        public TroubleshooterProvisioningState? ProvisioningState { get; }
        /// <summary> List of step object. </summary>
        public IReadOnlyList<SelfHelpStep> Steps { get; }
    }
}
