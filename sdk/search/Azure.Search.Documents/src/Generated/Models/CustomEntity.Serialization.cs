// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Type != null)
            {
                if (Type != null)
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(Type);
                }
                else
                {
                    writer.WriteNull("type");
                }
            }
            if (Subtype != null)
            {
                if (Subtype != null)
                {
                    writer.WritePropertyName("subtype"u8);
                    writer.WriteStringValue(Subtype);
                }
                else
                {
                    writer.WriteNull("subtype");
                }
            }
            if (Id != null)
            {
                if (Id != null)
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Id);
                }
                else
                {
                    writer.WriteNull("id");
                }
            }
            if (CaseSensitive.HasValue)
            {
                if (CaseSensitive != null)
                {
                    writer.WritePropertyName("caseSensitive"u8);
                    writer.WriteBooleanValue(CaseSensitive.Value);
                }
                else
                {
                    writer.WriteNull("caseSensitive");
                }
            }
            if (AccentSensitive.HasValue)
            {
                if (AccentSensitive != null)
                {
                    writer.WritePropertyName("accentSensitive"u8);
                    writer.WriteBooleanValue(AccentSensitive.Value);
                }
                else
                {
                    writer.WriteNull("accentSensitive");
                }
            }
            if (FuzzyEditDistance.HasValue)
            {
                if (FuzzyEditDistance != null)
                {
                    writer.WritePropertyName("fuzzyEditDistance"u8);
                    writer.WriteNumberValue(FuzzyEditDistance.Value);
                }
                else
                {
                    writer.WriteNull("fuzzyEditDistance");
                }
            }
            if (DefaultCaseSensitive.HasValue)
            {
                if (DefaultCaseSensitive != null)
                {
                    writer.WritePropertyName("defaultCaseSensitive"u8);
                    writer.WriteBooleanValue(DefaultCaseSensitive.Value);
                }
                else
                {
                    writer.WriteNull("defaultCaseSensitive");
                }
            }
            if (DefaultAccentSensitive.HasValue)
            {
                if (DefaultAccentSensitive != null)
                {
                    writer.WritePropertyName("defaultAccentSensitive"u8);
                    writer.WriteBooleanValue(DefaultAccentSensitive.Value);
                }
                else
                {
                    writer.WriteNull("defaultAccentSensitive");
                }
            }
            if (DefaultFuzzyEditDistance.HasValue)
            {
                if (DefaultFuzzyEditDistance != null)
                {
                    writer.WritePropertyName("defaultFuzzyEditDistance"u8);
                    writer.WriteNumberValue(DefaultFuzzyEditDistance.Value);
                }
                else
                {
                    writer.WriteNull("defaultFuzzyEditDistance");
                }
            }
            if (!(Aliases is ChangeTrackingList<CustomEntityAlias> collection && collection.IsUndefined))
            {
                if (Aliases != null)
                {
                    writer.WritePropertyName("aliases"u8);
                    writer.WriteStartArray();
                    foreach (var item in Aliases)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("aliases");
                }
            }
            writer.WriteEndObject();
        }

        internal static CustomEntity DeserializeCustomEntity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            Optional<string> type = default;
            Optional<string> subtype = default;
            Optional<string> id = default;
            Optional<bool?> caseSensitive = default;
            Optional<bool?> accentSensitive = default;
            Optional<int?> fuzzyEditDistance = default;
            Optional<bool?> defaultCaseSensitive = default;
            Optional<bool?> defaultAccentSensitive = default;
            Optional<int?> defaultFuzzyEditDistance = default;
            IList<CustomEntityAlias> aliases = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        type = null;
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subtype"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subtype = null;
                        continue;
                    }
                    subtype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        caseSensitive = null;
                        continue;
                    }
                    caseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("accentSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accentSensitive = null;
                        continue;
                    }
                    accentSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fuzzyEditDistance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fuzzyEditDistance = null;
                        continue;
                    }
                    fuzzyEditDistance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultCaseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultCaseSensitive = null;
                        continue;
                    }
                    defaultCaseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultAccentSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultAccentSensitive = null;
                        continue;
                    }
                    defaultAccentSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultFuzzyEditDistance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultFuzzyEditDistance = null;
                        continue;
                    }
                    defaultFuzzyEditDistance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        aliases = null;
                        continue;
                    }
                    List<CustomEntityAlias> array = new List<CustomEntityAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomEntityAlias.DeserializeCustomEntityAlias(item));
                    }
                    aliases = array;
                    continue;
                }
            }
            return new CustomEntity(name, description.Value, type.Value, subtype.Value, id.Value, Optional.ToNullable(caseSensitive), Optional.ToNullable(accentSensitive), Optional.ToNullable(fuzzyEditDistance), Optional.ToNullable(defaultCaseSensitive), Optional.ToNullable(defaultAccentSensitive), Optional.ToNullable(defaultFuzzyEditDistance), aliases ?? new ChangeTrackingList<CustomEntityAlias>());
        }
    }
}
