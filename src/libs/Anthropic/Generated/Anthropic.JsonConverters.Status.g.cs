#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Anthropic.JsonConverters
{
    /// <inheritdoc />
    public class StatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Anthropic.Status>
    {
        /// <inheritdoc />
        public override global::Anthropic.Status Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaFallbackCreditUsageStatusDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Anthropic.BetaFallbackCreditRedeemed? redeemed = default;
            if (discriminator?.Type == global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType.Redeemed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaFallbackCreditRedeemed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaFallbackCreditRedeemed> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaFallbackCreditRedeemed)}");
                redeemed = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Anthropic.BetaFallbackCreditNotApplied? notApplied = default;
            if (discriminator?.Type == global::Anthropic.BetaFallbackCreditUsageStatusDiscriminatorType.NotApplied)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaFallbackCreditNotApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaFallbackCreditNotApplied> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Anthropic.BetaFallbackCreditNotApplied)}");
                notApplied = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Anthropic.Status(
                discriminator?.Type,
                redeemed,

                notApplied
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Anthropic.Status value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsRedeemed)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaFallbackCreditRedeemed), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaFallbackCreditRedeemed?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaFallbackCreditRedeemed).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Redeemed!, typeInfo);
            }
            else if (value.IsNotApplied)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Anthropic.BetaFallbackCreditNotApplied), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Anthropic.BetaFallbackCreditNotApplied?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Anthropic.BetaFallbackCreditNotApplied).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NotApplied!, typeInfo);
            }
        }
    }
}