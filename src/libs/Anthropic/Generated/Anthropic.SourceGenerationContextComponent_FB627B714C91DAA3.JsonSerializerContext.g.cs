
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FB627B714C91DAA3
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_46933E96F47FDCE0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5AF8C2C1455C2CA6.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_6697FB76C4D8E3B5.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8B4C9A13A24D53EE.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AB249CE7E3E6C0CB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BC26301B1756BAAB.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_E7B0BDF015E28D5D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F6F31E6E6B0802B9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Scope3JsonConverter>(static () => new global::Anthropic.JsonConverters.Scope3JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Scope3))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0258.Create_Scope32(options);
                }
                if (type == typeof(global::Anthropic.Scope3?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0236.Create_NullableScope32(options);
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