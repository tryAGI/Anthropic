
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_CE9AFCCA11051FF6
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_216017E551A111ED.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_29FCF5276EBFFF7E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_303F8365437AAC7B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_533CFAC53DB475B5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_65AC809A192EFC9C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_7101EBDD3F5B2FA2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9E50788F69BC4343.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D36EDEA5FB3B887C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D3D253078C9512CC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D5491E0714AFC5DB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E2FE50035E659037.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EE2959C3FDBBDB12.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F99F0F30D7420C91.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FEF2463E1CA8B90C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventErrorJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsSessionErrorEventErrorJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventError))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0082.Create_BetaManagedAgentsSessionErrorEventError2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsSessionErrorEventError?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0209.Create_NullableBetaManagedAgentsSessionErrorEventError2(options);
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