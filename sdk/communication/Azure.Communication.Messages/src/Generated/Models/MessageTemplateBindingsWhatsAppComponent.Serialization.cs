// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Messages
{
    internal partial class MessageTemplateBindingsWhatsAppComponent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("refValue"u8);
            writer.WriteStringValue(RefValue);
            writer.WriteEndObject();
        }
    }
}
