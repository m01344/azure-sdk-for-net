// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Dimension splitting and filtering definition. </summary>
    public partial class MonitorDimension
    {
        /// <summary> Initializes a new instance of <see cref="MonitorDimension"/>. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="operator"> Operator for dimension values. </param>
        /// <param name="values"> List of dimension values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="values"/> is null. </exception>
        public MonitorDimension(string name, MonitorDimensionOperator @operator, IEnumerable<string> values)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(values, nameof(values));

            Name = name;
            Operator = @operator;
            Values = values.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="MonitorDimension"/>. </summary>
        /// <param name="name"> Name of the dimension. </param>
        /// <param name="operator"> Operator for dimension values. </param>
        /// <param name="values"> List of dimension values. </param>
        internal MonitorDimension(string name, MonitorDimensionOperator @operator, IList<string> values)
        {
            Name = name;
            Operator = @operator;
            Values = values;
        }

        /// <summary> Name of the dimension. </summary>
        public string Name { get; set; }
        /// <summary> Operator for dimension values. </summary>
        public MonitorDimensionOperator Operator { get; set; }
        /// <summary> List of dimension values. </summary>
        public IList<string> Values { get; }
    }
}
