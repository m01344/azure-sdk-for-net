// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Represents a ContentKeyPolicyConfiguration that is unavailable in the current API version. </summary>
    public partial class ContentKeyPolicyUnknownConfiguration : ContentKeyPolicyConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyUnknownConfiguration"/>. </summary>
        public ContentKeyPolicyUnknownConfiguration()
        {
            OdataType = "#Microsoft.Media.ContentKeyPolicyUnknownConfiguration";
        }

        /// <summary> Initializes a new instance of <see cref="ContentKeyPolicyUnknownConfiguration"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal ContentKeyPolicyUnknownConfiguration(string odataType) : base(odataType)
        {
            OdataType = odataType ?? "#Microsoft.Media.ContentKeyPolicyUnknownConfiguration";
        }
    }
}
