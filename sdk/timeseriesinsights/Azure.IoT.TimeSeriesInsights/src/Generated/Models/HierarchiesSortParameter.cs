// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Definition of sorting of hierarchy nodes. </summary>
    internal partial class HierarchiesSortParameter
    {
        /// <summary> Initializes a new instance of <see cref="HierarchiesSortParameter"/>. </summary>
        public HierarchiesSortParameter()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HierarchiesSortParameter"/>. </summary>
        /// <param name="by"> Value to use for hierarchy node sorting. When it is set to 'CumulativeInstanceCount', the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to 'Name', the returned hierarchies are sorted based on the hierarchy name. Optional, default is 'CumulativeInstanceCount'. </param>
        internal HierarchiesSortParameter(HierarchiesSortBy? @by)
        {
            By = @by;
        }

        /// <summary> Value to use for hierarchy node sorting. When it is set to 'CumulativeInstanceCount', the returned hierarchies are sorted based on the total instances belonging to the hierarchy node and its child hierarchy nodes. When it is set to 'Name', the returned hierarchies are sorted based on the hierarchy name. Optional, default is 'CumulativeInstanceCount'. </summary>
        public HierarchiesSortBy? By { get; set; }
    }
}
