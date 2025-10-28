#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class AppliedEditsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.AppliedEditsItem>
    {
        /// <inheritdoc />
        public override global::Anthropic.AppliedEditsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaResponseClearToolUses20250919Edit? clearToolUses20250919 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType.ClearToolUses20250919)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseClearToolUses20250919Edit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseClearToolUses20250919Edit)}");
                clearToolUses20250919 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaResponseClearThinking20251015Edit? clearThinking20251015 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType.ClearThinking20251015)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseClearThinking20251015Edit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseClearThinking20251015Edit> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaResponseClearThinking20251015Edit)}");
                clearThinking20251015 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::Anthropic.AppliedEditsItem(
                discriminator?.Type,
                clearToolUses20250919,
                clearThinking20251015
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.AppliedEditsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClearToolUses20250919)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseClearToolUses20250919Edit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClearToolUses20250919, typeInfo);
            }
            else if (value.IsClearThinking20251015)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaResponseClearThinking20251015Edit), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaResponseClearThinking20251015Edit?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaResponseClearThinking20251015Edit).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClearThinking20251015, typeInfo);
            }
        }
    }
}