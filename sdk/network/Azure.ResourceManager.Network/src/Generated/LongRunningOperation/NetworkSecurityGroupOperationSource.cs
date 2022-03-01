// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    internal class NetworkSecurityGroupOperationSource : IOperationSource<NetworkSecurityGroup>
    {
        private readonly ArmClient _client;

        internal NetworkSecurityGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        NetworkSecurityGroup IOperationSource<NetworkSecurityGroup>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(document.RootElement);
            return new NetworkSecurityGroup(_client, data);
        }

        async ValueTask<NetworkSecurityGroup> IOperationSource<NetworkSecurityGroup>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = NetworkSecurityGroupData.DeserializeNetworkSecurityGroupData(document.RootElement);
            return new NetworkSecurityGroup(_client, data);
        }
    }
}
