// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing the SphereCatalog data model.
    /// An Azure Sphere catalog
    /// Serialized Name: Catalog
    /// </summary>
    public partial class SphereCatalogData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SphereCatalogData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SphereCatalogData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereCatalogData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Catalog.properties.provisioningState
        /// </param>
        internal SphereCatalogData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, SphereProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// The status of the last operation.
        /// Serialized Name: Catalog.properties.provisioningState
        /// </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}
