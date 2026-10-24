
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A8582F68C2548186
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_0923ABF089D1BFDF.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_22052184BCF8026B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_26C0F3DF331B6079.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2AE3BF83A928404A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2E19410C1182EFF9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_43BD37DF462CCAA2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4F6BC3ABB61241B2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6229DE1A0845C9EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6B22F42322249B57.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9CD8172E1FF3FB07.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_ADE08E5BB20B786B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BB498710F784991C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BF78171D85898F64.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C0580CAFACC5BEC5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EB286241461E9BB9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FBDA14D7F5A46710.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FE4235E4B2AC65EE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaComputerMemberInputJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaComputerMemberInputJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaComputerMemberInput))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0027.Create_BetaComputerMemberInput2(options);
                }
                if (type == typeof(global::Anthropic.BetaComputerMemberInput?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0195.Create_NullableBetaComputerMemberInput2(options);
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