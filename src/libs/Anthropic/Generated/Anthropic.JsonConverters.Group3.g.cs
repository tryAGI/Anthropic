#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class Group3JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Group3>
    {
        /// <inheritdoc />
        public override global::Anthropic.Group3 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitGroupDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitGroupDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitGroupDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.RateLimitModelGroup? modelGroup = default;
            if (discriminator?.Type == global::Anthropic.RateLimitGroupDiscriminatorType.ModelGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitModelGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitModelGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitModelGroup)}");
                modelGroup = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RateLimitBatchGroup? batch = default;
            if (discriminator?.Type == global::Anthropic.RateLimitGroupDiscriminatorType.Batch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitBatchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitBatchGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitBatchGroup)}");
                batch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RateLimitTokenCountGroup? tokenCount = default;
            if (discriminator?.Type == global::Anthropic.RateLimitGroupDiscriminatorType.TokenCount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitTokenCountGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitTokenCountGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitTokenCountGroup)}");
                tokenCount = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RateLimitFilesGroup? files = default;
            if (discriminator?.Type == global::Anthropic.RateLimitGroupDiscriminatorType.Files)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitFilesGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitFilesGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitFilesGroup)}");
                files = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RateLimitSkillsGroup? skills = default;
            if (discriminator?.Type == global::Anthropic.RateLimitGroupDiscriminatorType.Skills)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitSkillsGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitSkillsGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitSkillsGroup)}");
                skills = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.RateLimitWebSearchGroup? webSearch = default;
            if (discriminator?.Type == global::Anthropic.RateLimitGroupDiscriminatorType.WebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitWebSearchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitWebSearchGroup> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.RateLimitWebSearchGroup)}");
                webSearch = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Group3(
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
            global::Anthropic.Group3 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsModelGroup)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitModelGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitModelGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitModelGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickModelGroup(), typeInfo);
            }
            else if (value.IsBatch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitBatchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitBatchGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitBatchGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickBatch(), typeInfo);
            }
            else if (value.IsTokenCount)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitTokenCountGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitTokenCountGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitTokenCountGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickTokenCount(), typeInfo);
            }
            else if (value.IsFiles)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitFilesGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitFilesGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitFilesGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFiles(), typeInfo);
            }
            else if (value.IsSkills)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitSkillsGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitSkillsGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitSkillsGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSkills(), typeInfo);
            }
            else if (value.IsWebSearch)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.RateLimitWebSearchGroup), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.RateLimitWebSearchGroup?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.RateLimitWebSearchGroup).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickWebSearch(), typeInfo);
            }
        }
    }
}