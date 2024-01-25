// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class HciInfraVnetProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MocGroup))
            {
                writer.WritePropertyName("mocGroup"u8);
                writer.WriteStringValue(MocGroup);
            }
            if (Optional.IsDefined(MocLocation))
            {
                writer.WritePropertyName("mocLocation"u8);
                writer.WriteStringValue(MocLocation);
            }
            if (Optional.IsDefined(MocVnetName))
            {
                writer.WritePropertyName("mocVnetName"u8);
                writer.WriteStringValue(MocVnetName);
            }
            writer.WriteEndObject();
        }

        internal static HciInfraVnetProfile DeserializeHciInfraVnetProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> mocGroup = default;
            Optional<string> mocLocation = default;
            Optional<string> mocVnetName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mocGroup"u8))
                {
                    mocGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocLocation"u8))
                {
                    mocLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocVnetName"u8))
                {
                    mocVnetName = property.Value.GetString();
                    continue;
                }
            }
            return new HciInfraVnetProfile(mocGroup.Value, mocLocation.Value, mocVnetName.Value);
        }
    }
}
