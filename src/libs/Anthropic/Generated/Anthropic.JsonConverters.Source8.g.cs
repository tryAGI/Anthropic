#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Source8JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Source8>
    {
        /// <inheritdoc />
        public override global::Anthropic.Source8 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource? workspace = default;
            if (discriminator?.Type == global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType.Workspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource)}");
                workspace = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaWorkspaceRateLimitOrganizationSource? organization = default;
            if (discriminator?.Type == global::Anthropic.BetaWorkspaceRateLimitValueSourceDiscriminatorType.Organization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWorkspaceRateLimitOrganizationSource> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource)}");
                organization = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Source8(
                discriminator?.Type,
                workspace,

                organization
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Source8 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsWorkspace)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWorkspaceRateLimitWorkspaceSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWorkspace(), typeInfo);
            }
            else if (value.IsOrganization)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaWorkspaceRateLimitOrganizationSource?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaWorkspaceRateLimitOrganizationSource).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickOrganization(), typeInfo);
            }
        }
    }
}