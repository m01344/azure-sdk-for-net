// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Active Directory allowed principals. </summary>
    public partial class AppServiceAadAllowedPrincipals
    {
        /// <summary> Initializes a new instance of <see cref="AppServiceAadAllowedPrincipals"/>. </summary>
        public AppServiceAadAllowedPrincipals()
        {
            Groups = new ChangeTrackingList<string>();
            Identities = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceAadAllowedPrincipals"/>. </summary>
        /// <param name="groups"> The list of the allowed groups. </param>
        /// <param name="identities"> The list of the allowed identities. </param>
        internal AppServiceAadAllowedPrincipals(IList<string> groups, IList<string> identities)
        {
            Groups = groups;
            Identities = identities;
        }

        /// <summary> The list of the allowed groups. </summary>
        public IList<string> Groups { get; }
        /// <summary> The list of the allowed identities. </summary>
        public IList<string> Identities { get; }
    }
}
