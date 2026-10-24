
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_51A2AD56CEFD5DC2
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_03684ED9F66FEC6A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0940C311AD9A621A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_0A44814B2F409A0C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1548B13CED2C3C39.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_18C88EDEC744B8A9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_1C7A35CA1474166D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2A9080860198A5D4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_31EBF34B1B37359E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4400E249B4CED41E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_525CA37CE3111F9B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_70806A315329E20A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_74B245CDF4C0A3D8.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_98824167AC3B5D2A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AFE076CDD138808D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B10344428571FCF5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B86D5A89D24738B0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EB5F49A2B98A7075.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.ComputerMemberInputJsonConverter>(static () => new global::Anthropic.JsonConverters.ComputerMemberInputJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.ComputerMemberInput))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0169.Create_ComputerMemberInput2(options);
                }
                if (type == typeof(global::Anthropic.ComputerMemberInput?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0228.Create_NullableComputerMemberInput2(options);
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