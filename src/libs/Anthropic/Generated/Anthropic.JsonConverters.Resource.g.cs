#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class ResourceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Resource>
    {
        /// <inheritdoc />
        public override global::Anthropic.Resource Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRbacRolePermissionResourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRbacRolePermissionResourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRbacRolePermissionResourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaOrganizationPermissionResource? organization = default;
            if (discriminator?.Type == global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOrganizationPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOrganizationPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaOrganizationPermissionResource)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaConnectorToolPermissionResource? connectorTool = default;
            if (discriminator?.Type == global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType.ConnectorTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaConnectorToolPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaConnectorToolPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaConnectorToolPermissionResource)}");
                connectorTool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaConnectorScopePermissionResource? connectorScope = default;
            if (discriminator?.Type == global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType.ConnectorScope)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaConnectorScopePermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaConnectorScopePermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaConnectorScopePermissionResource)}");
                connectorScope = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaConnectorPermissionResource? connector = default;
            if (discriminator?.Type == global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType.Connector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaConnectorPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaConnectorPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaConnectorPermissionResource)}");
                connector = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaAllConnectorsPermissionResource? allConnectors = default;
            if (discriminator?.Type == global::Anthropic.BetaRbacRolePermissionResourceDiscriminatorType.AllConnectors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAllConnectorsPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAllConnectorsPermissionResource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaAllConnectorsPermissionResource)}");
                allConnectors = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Resource(
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
            global::Anthropic.Resource value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaOrganizationPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaOrganizationPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaOrganizationPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Organization!, typeInfo);
            }
            else if (value.IsConnectorTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaConnectorToolPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaConnectorToolPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaConnectorToolPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConnectorTool!, typeInfo);
            }
            else if (value.IsConnectorScope)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaConnectorScopePermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaConnectorScopePermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaConnectorScopePermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ConnectorScope!, typeInfo);
            }
            else if (value.IsConnector)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaConnectorPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaConnectorPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaConnectorPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Connector!, typeInfo);
            }
            else if (value.IsAllConnectors)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaAllConnectorsPermissionResource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaAllConnectorsPermissionResource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaAllConnectorsPermissionResource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AllConnectors!, typeInfo);
            }
        }
    }
}