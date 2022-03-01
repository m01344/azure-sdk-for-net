// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPolicyThreatIntelWhitelist : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPAddresses))
            {
                writer.WritePropertyName("ipAddresses");
                writer.WriteStartArray();
                foreach (var item in IPAddresses)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Fqdns))
            {
                writer.WritePropertyName("fqdns");
                writer.WriteStartArray();
                foreach (var item in Fqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FirewallPolicyThreatIntelWhitelist DeserializeFirewallPolicyThreatIntelWhitelist(JsonElement element)
        {
            Optional<IList<string>> ipAddresses = default;
            Optional<IList<string>> fqdns = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddresses"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipAddresses = array;
                    continue;
                }
                if (property.NameEquals("fqdns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fqdns = array;
                    continue;
                }
            }
            return new FirewallPolicyThreatIntelWhitelist(Optional.ToList(ipAddresses), Optional.ToList(fqdns));
        }
    }
}
