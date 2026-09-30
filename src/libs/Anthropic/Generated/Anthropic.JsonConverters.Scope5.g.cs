#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Scope5JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Scope5>
    {
        /// <inheritdoc />
        public override global::Anthropic.Scope5 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyScopeDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyScopeDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ApiKeyScopeDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.ApiKeyOrganizationScope? organization = default;
            if (discriminator?.Type == global::Anthropic.ApiKeyScopeDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyOrganizationScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyOrganizationScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ApiKeyOrganizationScope)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.ApiKeyWorkspaceScope? workspace = default;
            if (discriminator?.Type == global::Anthropic.ApiKeyScopeDiscriminatorType.Workspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyWorkspaceScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyWorkspaceScope> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.ApiKeyWorkspaceScope)}");
                workspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Scope5(
                discriminator?.Type,
                organization,

                workspace
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Scope5 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyOrganizationScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyOrganizationScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ApiKeyOrganizationScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
            else if (value.IsWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.ApiKeyWorkspaceScope), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.ApiKeyWorkspaceScope?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.ApiKeyWorkspaceScope).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkspace(), typeInfo);
            }
        }
    }
}