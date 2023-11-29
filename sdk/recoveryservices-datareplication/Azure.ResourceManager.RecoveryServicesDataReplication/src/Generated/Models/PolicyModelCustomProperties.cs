// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary>
    /// Policy model custom properties.
    /// Please note <see cref="PolicyModelCustomProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="HyperVToAzStackHciPolicyModelCustomProperties"/>, <see cref="GeneralPolicyModelCustomProperties"/> and <see cref="VMwareToAzStackHciPolicyModelCustomProperties"/>.
    /// </summary>
    public abstract partial class PolicyModelCustomProperties
    {
        /// <summary> Initializes a new instance of <see cref="PolicyModelCustomProperties"/>. </summary>
        protected PolicyModelCustomProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PolicyModelCustomProperties"/>. </summary>
        /// <param name="instanceType"> Gets or sets the instance type. </param>
        internal PolicyModelCustomProperties(string instanceType)
        {
            InstanceType = instanceType;
        }

        /// <summary> Gets or sets the instance type. </summary>
        internal string InstanceType { get; set; }
    }
}
