// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class CmdkeySetup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CustomSetupBaseType);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("targetName"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(TargetName);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(TargetName.ToString()).RootElement);
#endif
            writer.WritePropertyName("userName"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(UserName);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(UserName.ToString()).RootElement);
#endif
            writer.WritePropertyName("password"u8);
            JsonSerializer.Serialize(writer, Password);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CmdkeySetup DeserializeCmdkeySetup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            BinaryData targetName = default;
            BinaryData userName = default;
            DataFactorySecretBaseDefinition password = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("targetName"u8))
                        {
                            targetName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            userName = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            password = JsonSerializer.Deserialize<DataFactorySecretBaseDefinition>(property0.Value.GetRawText());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CmdkeySetup(type, targetName, userName, password);
        }
    }
}
