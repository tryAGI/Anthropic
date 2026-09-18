#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class GroupJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Group>
    {
        /// <inheritdoc />
        public override global::Anthropic.Group Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitGroupDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitGroupDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitGroupDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaRateLimitModelGroup? modelGroup = default;
            if (discriminator?.Type == global::Anthropic.BetaRateLimitGroupDiscriminatorType.ModelGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitModelGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitModelGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitModelGroup)}");
                modelGroup = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRateLimitBatchGroup? batch = default;
            if (discriminator?.Type == global::Anthropic.BetaRateLimitGroupDiscriminatorType.Batch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitBatchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitBatchGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitBatchGroup)}");
                batch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRateLimitTokenCountGroup? tokenCount = default;
            if (discriminator?.Type == global::Anthropic.BetaRateLimitGroupDiscriminatorType.TokenCount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitTokenCountGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitTokenCountGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitTokenCountGroup)}");
                tokenCount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRateLimitFilesGroup? files = default;
            if (discriminator?.Type == global::Anthropic.BetaRateLimitGroupDiscriminatorType.Files)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitFilesGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitFilesGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitFilesGroup)}");
                files = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRateLimitSkillsGroup? skills = default;
            if (discriminator?.Type == global::Anthropic.BetaRateLimitGroupDiscriminatorType.Skills)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitSkillsGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitSkillsGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitSkillsGroup)}");
                skills = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaRateLimitWebSearchGroup? webSearch = default;
            if (discriminator?.Type == global::Anthropic.BetaRateLimitGroupDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitWebSearchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitWebSearchGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaRateLimitWebSearchGroup)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Group(
                discriminator?.Type,
                modelGroup,

                batch,

                tokenCount,

                files,

                skills,

                webSearch
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Group value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitModelGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitModelGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitModelGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ModelGroup!, typeInfo);
            }
            else if (value.IsBatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitBatchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitBatchGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitBatchGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Batch!, typeInfo);
            }
            else if (value.IsTokenCount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitTokenCountGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitTokenCountGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitTokenCountGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.TokenCount!, typeInfo);
            }
            else if (value.IsFiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitFilesGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitFilesGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitFilesGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Files!, typeInfo);
            }
            else if (value.IsSkills)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitSkillsGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitSkillsGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitSkillsGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Skills!, typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaRateLimitWebSearchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaRateLimitWebSearchGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaRateLimitWebSearchGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.WebSearch!, typeInfo);
            }
        }
    }
}