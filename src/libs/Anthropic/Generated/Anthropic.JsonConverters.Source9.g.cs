#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Source9JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source9>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source9 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WorkspaceRateLimitValueSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.WorkspaceRateLimitWorkspaceSource? workspace = default;
            if (discriminator?.Type == global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType.Workspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceRateLimitWorkspaceSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceRateLimitWorkspaceSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WorkspaceRateLimitWorkspaceSource)}");
                workspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.WorkspaceRateLimitOrganizationSource? organization = default;
            if (discriminator?.Type == global::Anthropic.WorkspaceRateLimitValueSourceDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceRateLimitOrganizationSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceRateLimitOrganizationSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.WorkspaceRateLimitOrganizationSource)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Source9(
                discriminator?.Type,
                workspace,

                organization
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source9 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceRateLimitWorkspaceSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceRateLimitWorkspaceSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.WorkspaceRateLimitWorkspaceSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkspace(), typeInfo);
            }
            else if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.WorkspaceRateLimitOrganizationSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.WorkspaceRateLimitOrganizationSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.WorkspaceRateLimitOrganizationSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
        }
    }
}