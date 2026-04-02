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


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminator>(ref readerCopy, options);

            global::Anthropic.BetaResponseClearToolUses20250919Edit? clearToolUses20250919 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType.ClearToolUses20250919)
            {
                clearToolUses20250919 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseClearToolUses20250919Edit>(ref reader, options);
            }
            global::Anthropic.BetaResponseClearThinking20251015Edit? clearThinking20251015 = default;
            if (discriminator?.Type == global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType.ClearThinking20251015)
            {
                clearThinking20251015 = global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BetaResponseClearThinking20251015Edit>(ref reader, options);
            }

            var __value = new global::Anthropic.AppliedEditsItem(
                discriminator?.Type,
                clearToolUses20250919,

                clearThinking20251015
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.AppliedEditsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsClearToolUses20250919)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClearToolUses20250919, typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit), options);
            }
            else if (value.IsClearThinking20251015)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ClearThinking20251015, typeof(global::Anthropic.BetaResponseClearThinking20251015Edit), options);
            }
        }
    }
}