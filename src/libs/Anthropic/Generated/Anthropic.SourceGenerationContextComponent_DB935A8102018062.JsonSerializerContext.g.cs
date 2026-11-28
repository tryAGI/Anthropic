
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_DB935A8102018062
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_E540DD06A2785537.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E9586CA58631A28D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.UserProfileNotBillableErrorDetails>>(static () => new global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.UserProfileNotBillableErrorDetails>());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.UserProfileNotBillableErrorDetails>))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0359.Create_SourceGenerationContextMetadataType_DB935A8102018062(options);
                }
                if (type == typeof(global::Anthropic.AnyOf<global::Anthropic.UserProfileBillingNotAuthorizedErrorDetails, global::Anthropic.UserProfileNotBillableErrorDetails>?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0330.Create_SourceGenerationContextMetadataType_4ED9F8F65C181D65(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}