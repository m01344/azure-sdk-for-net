// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Amazon Redshift. </summary>
    public partial class AmazonRedshiftLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of <see cref="AmazonRedshiftLinkedService"/>. </summary>
        /// <param name="server"> The name of the Amazon Redshift server. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> The database name of the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> or <paramref name="database"/> is null. </exception>
        public AmazonRedshiftLinkedService(object server, object database)
        {
            Argument.AssertNotNull(server, nameof(server));
            Argument.AssertNotNull(database, nameof(database));

            Server = server;
            Database = database;
            Type = "AmazonRedshift";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonRedshiftLinkedService"/>. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="server"> The name of the Amazon Redshift server. Type: string (or Expression with resultType string). </param>
        /// <param name="username"> The username of the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// The password of the Amazon Redshift source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="database"> The database name of the Amazon Redshift source. Type: string (or Expression with resultType string). </param>
        /// <param name="port"> The TCP port number that the Amazon Redshift server uses to listen for client connections. The default value is 5439. Type: integer (or Expression with resultType integer). </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal AmazonRedshiftLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object server, object username, SecretBase password, object database, object port, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            Server = server;
            Username = username;
            Password = password;
            Database = database;
            Port = port;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "AmazonRedshift";
        }

        /// <summary> The name of the Amazon Redshift server. Type: string (or Expression with resultType string). </summary>
        public object Server { get; set; }
        /// <summary> The username of the Amazon Redshift source. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// The password of the Amazon Redshift source.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> The database name of the Amazon Redshift source. Type: string (or Expression with resultType string). </summary>
        public object Database { get; set; }
        /// <summary> The TCP port number that the Amazon Redshift server uses to listen for client connections. The default value is 5439. Type: integer (or Expression with resultType integer). </summary>
        public object Port { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
