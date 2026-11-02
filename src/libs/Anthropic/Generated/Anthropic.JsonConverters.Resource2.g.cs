#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Resource2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Resource2>
    {
        /// <inheritdoc />
        public override global::Anthropic.Resource2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RbacRolePermissionResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RbacRolePermissionResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RbacRolePermissionResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.OrganizationPermissionResource? organization = default;
            if (discriminator?.Type == global::Anthropic.RbacRolePermissionResourceDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OrganizationPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OrganizationPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.OrganizationPermissionResource)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ConnectorToolPermissionResource? connectorTool = default;
            if (discriminator?.Type == global::Anthropic.RbacRolePermissionResourceDiscriminatorType.ConnectorTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ConnectorToolPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ConnectorToolPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ConnectorToolPermissionResource)}");
                connectorTool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ConnectorScopePermissionResource? connectorScope = default;
            if (discriminator?.Type == global::Anthropic.RbacRolePermissionResourceDiscriminatorType.ConnectorScope)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ConnectorScopePermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ConnectorScopePermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ConnectorScopePermissionResource)}");
                connectorScope = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ConnectorPermissionResource? connector = default;
            if (discriminator?.Type == global::Anthropic.RbacRolePermissionResourceDiscriminatorType.Connector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ConnectorPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ConnectorPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ConnectorPermissionResource)}");
                connector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.AllConnectorsPermissionResource? allConnectors = default;
            if (discriminator?.Type == global::Anthropic.RbacRolePermissionResourceDiscriminatorType.AllConnectors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllConnectorsPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllConnectorsPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.AllConnectorsPermissionResource)}");
                allConnectors = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Resource2(
                discriminator?.Type,
                organization,

                connectorTool,

                connectorScope,

                connector,

                allConnectors
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Resource2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::Anthropic.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.OrganizationPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.OrganizationPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.OrganizationPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
            else if (value.IsConnectorTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ConnectorToolPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ConnectorToolPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ConnectorToolPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnectorTool(), typeInfo);
            }
            else if (value.IsConnectorScope)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ConnectorScopePermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ConnectorScopePermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ConnectorScopePermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnectorScope(), typeInfo);
            }
            else if (value.IsConnector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ConnectorPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ConnectorPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ConnectorPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickConnector(), typeInfo);
            }
            else if (value.IsAllConnectors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.AllConnectorsPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.AllConnectorsPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.AllConnectorsPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickAllConnectors(), typeInfo);
            }
        }
    }
}