// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The metadata response for the app, including available tables, etc. </summary>
    internal partial class MetadataResults
    {
        /// <summary> Initializes a new instance of <see cref="MetadataResults"/>. </summary>
        internal MetadataResults()
        {
            Categories = new ChangeTrackingList<MetadataCategory>();
            ResourceTypes = new ChangeTrackingList<MetadataResourceType>();
            Solutions = new ChangeTrackingList<MetadataSolution>();
            Tables = new ChangeTrackingList<MetadataTable>();
            Functions = new ChangeTrackingList<MetadataFunction>();
            Queries = new ChangeTrackingList<MetadataQuery>();
            Applications = new ChangeTrackingList<MetadataApplication>();
            Workspaces = new ChangeTrackingList<MetadataWorkspace>();
            Resources = new ChangeTrackingList<object>();
            Permissions = new ChangeTrackingList<MetadataPermissions>();
        }

        /// <summary> The list of categories that are referenced in this metadata response. </summary>
        public IReadOnlyList<MetadataCategory> Categories { get; }
        /// <summary> The list of resource types that are referenced in this metadata response. </summary>
        public IReadOnlyList<MetadataResourceType> ResourceTypes { get; }
        /// <summary> The list of Log Analytics solutions installed on the workspace. </summary>
        public IReadOnlyList<MetadataSolution> Solutions { get; }
        /// <summary> The list of tables and columns that comprise the schema of the workspace. </summary>
        public IReadOnlyList<MetadataTable> Tables { get; }
        /// <summary> The list of functions stored on the workspace, or introduced by solutions etc. </summary>
        public IReadOnlyList<MetadataFunction> Functions { get; }
        /// <summary> The list of saved queries stored on the workspace, or introduced by solutions, resource types, etc. </summary>
        public IReadOnlyList<MetadataQuery> Queries { get; }
        /// <summary> The list of Application Insights apps that were referenced in the metadata request. </summary>
        public IReadOnlyList<MetadataApplication> Applications { get; }
        /// <summary> The list of Log Analytics workspaces that were referenced in the metadata request. </summary>
        public IReadOnlyList<MetadataWorkspace> Workspaces { get; }
        /// <summary> The list of Azure resources that were referenced in the metadata request. </summary>
        public IReadOnlyList<object> Resources { get; }
        /// <summary> The list of permission rules that affected the metadata request. </summary>
        public IReadOnlyList<MetadataPermissions> Permissions { get; }
    }
}
