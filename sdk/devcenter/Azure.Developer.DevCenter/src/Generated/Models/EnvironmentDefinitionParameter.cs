// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    /// <summary> Properties of an Environment Definition parameter. </summary>
    public partial class EnvironmentDefinitionParameter
    {
        /// <summary> Initializes a new instance of <see cref="EnvironmentDefinitionParameter"/>. </summary>
        /// <param name="id"> Unique ID of the parameter. </param>
        /// <param name="parameterType">
        /// A string of one of the basic JSON types (number, integer, array, object,
        /// boolean, string)
        /// </param>
        /// <param name="required"> Whether or not this parameter is required. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        internal EnvironmentDefinitionParameter(string id, EnvironmentDefinitionParameterType parameterType, bool required)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
            ParameterType = parameterType;
            Required = required;
            Allowed = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EnvironmentDefinitionParameter"/>. </summary>
        /// <param name="id"> Unique ID of the parameter. </param>
        /// <param name="name"> Display name of the parameter. </param>
        /// <param name="description"> Description of the parameter. </param>
        /// <param name="defaultValue"> Default value of the parameter. </param>
        /// <param name="parameterType">
        /// A string of one of the basic JSON types (number, integer, array, object,
        /// boolean, string)
        /// </param>
        /// <param name="readOnly">
        /// Whether or not this parameter is read-only.  If true, default should have a
        /// value.
        /// </param>
        /// <param name="required"> Whether or not this parameter is required. </param>
        /// <param name="allowed"> An array of allowed values. </param>
        internal EnvironmentDefinitionParameter(string id, string name, string description, BinaryData defaultValue, EnvironmentDefinitionParameterType parameterType, bool? readOnly, bool required, IReadOnlyList<string> allowed)
        {
            Id = id;
            Name = name;
            Description = description;
            DefaultValue = defaultValue;
            ParameterType = parameterType;
            ReadOnly = readOnly;
            Required = required;
            Allowed = allowed;
        }

        /// <summary> Unique ID of the parameter. </summary>
        public string Id { get; }
        /// <summary> Display name of the parameter. </summary>
        public string Name { get; }
        /// <summary> Description of the parameter. </summary>
        public string Description { get; }
        /// <summary>
        /// A string of one of the basic JSON types (number, integer, array, object,
        /// boolean, string)
        /// </summary>
        public EnvironmentDefinitionParameterType ParameterType { get; }
        /// <summary>
        /// Whether or not this parameter is read-only.  If true, default should have a
        /// value.
        /// </summary>
        public bool? ReadOnly { get; }
        /// <summary> Whether or not this parameter is required. </summary>
        public bool Required { get; }
        /// <summary> An array of allowed values. </summary>
        public IReadOnlyList<string> Allowed { get; }
    }
}
