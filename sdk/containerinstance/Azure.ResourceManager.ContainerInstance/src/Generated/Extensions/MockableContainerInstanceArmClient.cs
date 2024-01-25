// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.ContainerInstance;

namespace Azure.ResourceManager.ContainerInstance.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableContainerInstanceArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableContainerInstanceArmClient"/> class for mocking. </summary>
        protected MockableContainerInstanceArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableContainerInstanceArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableContainerInstanceArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableContainerInstanceArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerGroupResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerGroupResource.CreateResourceIdentifier" /> to create a <see cref="ContainerGroupResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ContainerGroupResource"/> object. </returns>
        public virtual ContainerGroupResource GetContainerGroupResource(ResourceIdentifier id)
        {
            ContainerGroupResource.ValidateResourceId(id);
            return new ContainerGroupResource(Client, id);
        }
    }
}
