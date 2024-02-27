// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedDatabasePatch : IUtf8JsonSerializable, IJsonModel<ManagedDatabasePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedDatabasePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedDatabasePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDatabasePatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Collation != null)
            {
                writer.WritePropertyName("collation"u8);
                writer.WriteStringValue(Collation);
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationDate"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && EarliestRestorePoint.HasValue)
            {
                writer.WritePropertyName("earliestRestorePoint"u8);
                writer.WriteStringValue(EarliestRestorePoint.Value, "O");
            }
            if (RestorePointInTime.HasValue)
            {
                writer.WritePropertyName("restorePointInTime"u8);
                writer.WriteStringValue(RestorePointInTime.Value, "O");
            }
            if (options.Format != "W" && DefaultSecondaryLocation.HasValue)
            {
                writer.WritePropertyName("defaultSecondaryLocation"u8);
                writer.WriteStringValue(DefaultSecondaryLocation.Value);
            }
            if (CatalogCollation.HasValue)
            {
                writer.WritePropertyName("catalogCollation"u8);
                writer.WriteStringValue(CatalogCollation.Value.ToString());
            }
            if (CreateMode.HasValue)
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (StorageContainerUri != null)
            {
                writer.WritePropertyName("storageContainerUri"u8);
                writer.WriteStringValue(StorageContainerUri.AbsoluteUri);
            }
            if (SourceDatabaseId != null)
            {
                writer.WritePropertyName("sourceDatabaseId"u8);
                writer.WriteStringValue(SourceDatabaseId);
            }
            if (CrossSubscriptionSourceDatabaseId != null)
            {
                writer.WritePropertyName("crossSubscriptionSourceDatabaseId"u8);
                writer.WriteStringValue(CrossSubscriptionSourceDatabaseId);
            }
            if (RestorableDroppedDatabaseId != null)
            {
                writer.WritePropertyName("restorableDroppedDatabaseId"u8);
                writer.WriteStringValue(RestorableDroppedDatabaseId);
            }
            if (CrossSubscriptionRestorableDroppedDatabaseId != null)
            {
                writer.WritePropertyName("crossSubscriptionRestorableDroppedDatabaseId"u8);
                writer.WriteStringValue(CrossSubscriptionRestorableDroppedDatabaseId);
            }
            if (StorageContainerIdentity != null)
            {
                writer.WritePropertyName("storageContainerIdentity"u8);
                writer.WriteStringValue(StorageContainerIdentity);
            }
            if (StorageContainerSasToken != null)
            {
                writer.WritePropertyName("storageContainerSasToken"u8);
                writer.WriteStringValue(StorageContainerSasToken);
            }
            if (options.Format != "W" && FailoverGroupId != null)
            {
                writer.WritePropertyName("failoverGroupId"u8);
                writer.WriteStringValue(FailoverGroupId);
            }
            if (RecoverableDatabaseId != null)
            {
                writer.WritePropertyName("recoverableDatabaseId"u8);
                writer.WriteStringValue(RecoverableDatabaseId);
            }
            if (LongTermRetentionBackupResourceId != null)
            {
                writer.WritePropertyName("longTermRetentionBackupResourceId"u8);
                writer.WriteStringValue(LongTermRetentionBackupResourceId);
            }
            if (AllowAutoCompleteRestore.HasValue)
            {
                writer.WritePropertyName("autoCompleteRestore"u8);
                writer.WriteBooleanValue(AllowAutoCompleteRestore.Value);
            }
            if (LastBackupName != null)
            {
                writer.WritePropertyName("lastBackupName"u8);
                writer.WriteStringValue(LastBackupName);
            }
            if (CrossSubscriptionTargetManagedInstanceId != null)
            {
                writer.WritePropertyName("crossSubscriptionTargetManagedInstanceId"u8);
                writer.WriteStringValue(CrossSubscriptionTargetManagedInstanceId);
            }
            if (IsLedgerOn.HasValue)
            {
                writer.WritePropertyName("isLedgerOn"u8);
                writer.WriteBooleanValue(IsLedgerOn.Value);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ManagedDatabasePatch IJsonModel<ManagedDatabasePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedDatabasePatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedDatabasePatch(document.RootElement, options);
        }

        internal static ManagedDatabasePatch DeserializeManagedDatabasePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            Optional<string> collation = default;
            Optional<ManagedDatabaseStatus> status = default;
            Optional<DateTimeOffset> creationDate = default;
            Optional<DateTimeOffset> earliestRestorePoint = default;
            Optional<DateTimeOffset> restorePointInTime = default;
            Optional<AzureLocation> defaultSecondaryLocation = default;
            Optional<CatalogCollationType> catalogCollation = default;
            Optional<ManagedDatabaseCreateMode> createMode = default;
            Optional<Uri> storageContainerUri = default;
            Optional<ResourceIdentifier> sourceDatabaseId = default;
            Optional<ResourceIdentifier> crossSubscriptionSourceDatabaseId = default;
            Optional<ResourceIdentifier> restorableDroppedDatabaseId = default;
            Optional<ResourceIdentifier> crossSubscriptionRestorableDroppedDatabaseId = default;
            Optional<string> storageContainerIdentity = default;
            Optional<string> storageContainerSasToken = default;
            Optional<ResourceIdentifier> failoverGroupId = default;
            Optional<ResourceIdentifier> recoverableDatabaseId = default;
            Optional<ResourceIdentifier> longTermRetentionBackupResourceId = default;
            Optional<bool> autoCompleteRestore = default;
            Optional<string> lastBackupName = default;
            Optional<ResourceIdentifier> crossSubscriptionTargetManagedInstanceId = default;
            Optional<bool> isLedgerOn = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("collation"u8))
                        {
                            collation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new ManagedDatabaseStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("earliestRestorePoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            earliestRestorePoint = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("restorePointInTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorePointInTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("defaultSecondaryLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultSecondaryLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("catalogCollation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            catalogCollation = new CatalogCollationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("createMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createMode = new ManagedDatabaseCreateMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageContainerUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageContainerUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sourceDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sourceDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSubscriptionSourceDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSubscriptionSourceDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("restorableDroppedDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            restorableDroppedDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("crossSubscriptionRestorableDroppedDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSubscriptionRestorableDroppedDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("storageContainerIdentity"u8))
                        {
                            storageContainerIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageContainerSasToken"u8))
                        {
                            storageContainerSasToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("failoverGroupId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failoverGroupId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("recoverableDatabaseId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverableDatabaseId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("longTermRetentionBackupResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            longTermRetentionBackupResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("autoCompleteRestore"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoCompleteRestore = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastBackupName"u8))
                        {
                            lastBackupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("crossSubscriptionTargetManagedInstanceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            crossSubscriptionTargetManagedInstanceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("isLedgerOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isLedgerOn = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedDatabasePatch(tags ?? new ChangeTrackingDictionary<string, string>(), collation.Value, Optional.ToNullable(status), Optional.ToNullable(creationDate), Optional.ToNullable(earliestRestorePoint), Optional.ToNullable(restorePointInTime), Optional.ToNullable(defaultSecondaryLocation), Optional.ToNullable(catalogCollation), Optional.ToNullable(createMode), storageContainerUri.Value, sourceDatabaseId.Value, crossSubscriptionSourceDatabaseId.Value, restorableDroppedDatabaseId.Value, crossSubscriptionRestorableDroppedDatabaseId.Value, storageContainerIdentity.Value, storageContainerSasToken.Value, failoverGroupId.Value, recoverableDatabaseId.Value, longTermRetentionBackupResourceId.Value, Optional.ToNullable(autoCompleteRestore), lastBackupName.Value, crossSubscriptionTargetManagedInstanceId.Value, Optional.ToNullable(isLedgerOn), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedDatabasePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedDatabasePatch)} does not support '{options.Format}' format.");
            }
        }

        ManagedDatabasePatch IPersistableModel<ManagedDatabasePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedDatabasePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedDatabasePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedDatabasePatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedDatabasePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
