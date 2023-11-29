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
    /// <summary> SAP Business Warehouse Linked Service. </summary>
    public partial class SapBWLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="SapBWLinkedService"/>. </summary>
        /// <param name="server"> Host name of the SAP BW instance. Type: string (or Expression with resultType string). </param>
        /// <param name="systemNumber"> System number of the BW system. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </param>
        /// <param name="clientId"> Client ID of the client on the BW system. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/>, <paramref name="systemNumber"/> or <paramref name="clientId"/> is null. </exception>
        public SapBWLinkedService(DataFactoryElement<string> server, DataFactoryElement<string> systemNumber, DataFactoryElement<string> clientId)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(systemNumber, nameof(systemNumber));
            Argument.AssertNotNull(clientId, nameof(clientId));

            Server = server;
            SystemNumber = systemNumber;
            ClientId = clientId;
            LinkedServiceType = "SapBW";
        }

        /// <summary> Initializes a new instance of <see cref="SapBWLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> Host name of the SAP BW instance. Type: string (or Expression with resultType string). </param>
        /// <param name="systemNumber"> System number of the BW system. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </param>
        /// <param name="clientId"> Client ID of the client on the BW system. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </param>
        /// <param name="userName"> Username to access the SAP BW server. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password to access the SAP BW server. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal SapBWLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> server, DataFactoryElement<string> systemNumber, DataFactoryElement<string> clientId, DataFactoryElement<string> userName, DataFactorySecretBaseDefinition password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            SystemNumber = systemNumber;
            ClientId = clientId;
            UserName = userName;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "SapBW";
        }

        /// <summary> Host name of the SAP BW instance. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> System number of the BW system. (Usually a two-digit decimal number represented as a string.) Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> SystemNumber { get; set; }
        /// <summary> Client ID of the client on the BW system. (Usually a three-digit decimal number represented as a string) Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ClientId { get; set; }
        /// <summary> Username to access the SAP BW server. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> UserName { get; set; }
        /// <summary> Password to access the SAP BW server. </summary>
        public DataFactorySecretBaseDefinition Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
