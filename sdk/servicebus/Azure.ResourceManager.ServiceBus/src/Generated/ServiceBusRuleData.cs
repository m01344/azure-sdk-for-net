// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing the ServiceBusRule data model.
    /// Description of Rule Resource.
    /// </summary>
    public partial class ServiceBusRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ServiceBusRuleData"/>. </summary>
        public ServiceBusRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBusRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="action"> Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression. </param>
        /// <param name="filterType"> Filter type that is evaluated against a BrokeredMessage. </param>
        /// <param name="sqlFilter"> Properties of sqlFilter. </param>
        /// <param name="correlationFilter"> Properties of correlationFilter. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        internal ServiceBusRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ServiceBusFilterAction action, ServiceBusFilterType? filterType, ServiceBusSqlFilter sqlFilter, ServiceBusCorrelationFilter correlationFilter, AzureLocation? location) : base(id, name, resourceType, systemData)
        {
            Action = action;
            FilterType = filterType;
            SqlFilter = sqlFilter;
            CorrelationFilter = correlationFilter;
            Location = location;
        }

        /// <summary> Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression. </summary>
        public ServiceBusFilterAction Action { get; set; }
        /// <summary> Filter type that is evaluated against a BrokeredMessage. </summary>
        public ServiceBusFilterType? FilterType { get; set; }
        /// <summary> Properties of sqlFilter. </summary>
        public ServiceBusSqlFilter SqlFilter { get; set; }
        /// <summary> Properties of correlationFilter. </summary>
        public ServiceBusCorrelationFilter CorrelationFilter { get; set; }
        /// <summary> The geo-location where the resource lives. </summary>
        public AzureLocation? Location { get; }
    }
}
