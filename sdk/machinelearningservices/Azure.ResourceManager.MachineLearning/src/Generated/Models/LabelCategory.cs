// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Label category definition. </summary>
    public partial class LabelCategory
    {
        /// <summary> Initializes a new instance of LabelCategory. </summary>
        public LabelCategory()
        {
            Classes = new ChangeTrackingDictionary<string, LabelClass>();
        }

        /// <summary> Initializes a new instance of LabelCategory. </summary>
        /// <param name="classes"> Dictionary of label classes in this category. </param>
        /// <param name="displayName"> Display name of the label category. </param>
        /// <param name="multiSelect"> Indicates whether it is allowed to select multiple classes in this category. </param>
        internal LabelCategory(IDictionary<string, LabelClass> classes, string displayName, LabelCategoryMultiSelect? multiSelect)
        {
            Classes = classes;
            DisplayName = displayName;
            MultiSelect = multiSelect;
        }

        /// <summary> Dictionary of label classes in this category. </summary>
        public IDictionary<string, LabelClass> Classes { get; set; }
        /// <summary> Display name of the label category. </summary>
        public string DisplayName { get; set; }
        /// <summary> Indicates whether it is allowed to select multiple classes in this category. </summary>
        public LabelCategoryMultiSelect? MultiSelect { get; set; }
    }
}
