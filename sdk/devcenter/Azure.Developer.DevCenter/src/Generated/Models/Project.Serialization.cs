// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Developer.DevCenter.Models
{
    public partial class Project
    {
        internal static Project DeserializeProject(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            Optional<int> maxDevBoxesPerUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxDevBoxesPerUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxDevBoxesPerUser = property.Value.GetInt32();
                    continue;
                }
            }
            return new Project(name, description.Value, Optional.ToNullable(maxDevBoxesPerUser));
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Project FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeProject(document.RootElement);
        }
    }
}
