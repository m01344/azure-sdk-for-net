// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Information about resource association. </summary>
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation
    {
        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation"/>. </summary>
        /// <param name="name"> Name of the resource association. </param>
        /// <param name="accessMode"> Access Mode of the resource association. </param>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(string name, EventHubsResourceAssociationAccessMode? accessMode)
        {
            Name = name;
            AccessMode = accessMode;
        }

        /// <summary> Name of the resource association. </summary>
        public string Name { get; }
        /// <summary> Access Mode of the resource association. </summary>
        public EventHubsResourceAssociationAccessMode? AccessMode { get; }
    }
}
