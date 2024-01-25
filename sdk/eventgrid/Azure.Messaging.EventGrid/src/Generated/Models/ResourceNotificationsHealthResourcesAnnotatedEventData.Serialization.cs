// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceNotificationsHealthResourcesAnnotatedEventDataConverter))]
    public partial class ResourceNotificationsHealthResourcesAnnotatedEventData
    {
        internal static ResourceNotificationsHealthResourcesAnnotatedEventData DeserializeResourceNotificationsHealthResourcesAnnotatedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceNotificationsResourceUpdatedDetails> resourceInfo = default;
            Optional<ResourceNotificationsOperationalDetails> operationalInfo = default;
            Optional<string> apiVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceInfo = ResourceNotificationsResourceUpdatedDetails.DeserializeResourceNotificationsResourceUpdatedDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationalInfo = ResourceNotificationsOperationalDetails.DeserializeResourceNotificationsOperationalDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceNotificationsHealthResourcesAnnotatedEventData(resourceInfo.Value, operationalInfo.Value, apiVersion.Value);
        }

        internal partial class ResourceNotificationsHealthResourcesAnnotatedEventDataConverter : JsonConverter<ResourceNotificationsHealthResourcesAnnotatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceNotificationsHealthResourcesAnnotatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ResourceNotificationsHealthResourcesAnnotatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceNotificationsHealthResourcesAnnotatedEventData(document.RootElement);
            }
        }
    }
}
