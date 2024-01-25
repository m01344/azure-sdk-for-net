// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> ExtendedLocation details data. </summary>
    public partial class A2AExtendedLocationDetails
    {
        /// <summary> Initializes a new instance of <see cref="A2AExtendedLocationDetails"/>. </summary>
        internal A2AExtendedLocationDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="A2AExtendedLocationDetails"/>. </summary>
        /// <param name="primaryExtendedLocation"> The primary ExtendedLocation. </param>
        /// <param name="recoveryExtendedLocation"> The recovery ExtendedLocation. </param>
        internal A2AExtendedLocationDetails(SiteRecoveryExtendedLocation primaryExtendedLocation, SiteRecoveryExtendedLocation recoveryExtendedLocation)
        {
            PrimaryExtendedLocation = primaryExtendedLocation;
            RecoveryExtendedLocation = recoveryExtendedLocation;
        }

        /// <summary> The primary ExtendedLocation. </summary>
        public SiteRecoveryExtendedLocation PrimaryExtendedLocation { get; }
        /// <summary> The recovery ExtendedLocation. </summary>
        public SiteRecoveryExtendedLocation RecoveryExtendedLocation { get; }
    }
}
