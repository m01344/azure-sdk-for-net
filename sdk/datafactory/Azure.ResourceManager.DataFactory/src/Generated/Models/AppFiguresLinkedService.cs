// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Linked service for AppFigures. </summary>
    public partial class AppFiguresLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="AppFiguresLinkedService"/>. </summary>
        /// <param name="userName"> The username of the Appfigures source. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password of the AppFigures source. </param>
        /// <param name="clientKey"> The client key for the AppFigures source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/>, <paramref name="password"/> or <paramref name="clientKey"/> is null. </exception>
        public AppFiguresLinkedService(DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, DataFactorySecretBaseDefinition clientKey)
        {
            Argument.AssertNotNull(userName, nameof(userName));
            Argument.AssertNotNull(password, nameof(password));
            Argument.AssertNotNull(clientKey, nameof(clientKey));

            UserName = userName;
            Password = password;
            ClientKey = clientKey;
            LinkedServiceType = "AppFigures";
        }

        /// <summary> Initializes a new instance of <see cref="AppFiguresLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="userName"> The username of the Appfigures source. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> The password of the AppFigures source. </param>
        /// <param name="clientKey"> The client key for the AppFigures source. </param>
        internal AppFiguresLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, DataFactorySecretBaseDefinition clientKey) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            UserName = userName;
            Password = password;
            ClientKey = clientKey;
            LinkedServiceType = linkedServiceType ?? "AppFigures";
        }

        /// <summary> The username of the Appfigures source. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> The password of the AppFigures source. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The client key for the AppFigures source. </summary>
        public DataFactorySecretBaseDefinition ClientKey { get; set; }
    }
}
