
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_496602ED577E9F89
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_234E729812258D1D.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5CE3AF509E65AFED.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9001C79BA2E0D082.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_91EF3717B8C4CB75.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_AD067FAA6400C0FC.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_C27919E6A6AF895E.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_D6209EE60A930A98.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EE2DDA7BEE1E390B.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F373B4A7888D3959.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_FB595B603F9143E6.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.Error2JsonConverter>(static () => new global::Anthropic.JsonConverters.Error2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.Error2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0176.Create_Error22(options);
                }
                if (type == typeof(global::Anthropic.Error2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0230.Create_NullableError22(options);
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