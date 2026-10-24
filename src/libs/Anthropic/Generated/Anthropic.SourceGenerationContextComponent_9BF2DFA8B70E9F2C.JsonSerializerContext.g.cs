
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9BF2DFA8B70E9F2C
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_3084B3D4BEDD4138.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_4FD18A02A6B78BF4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8506D08EEB2AA24C.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A92466515E8BD56F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_EAC0613365373A94.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.StateChangesVariant1Item2JsonConverter>(static () => new global::Anthropic.JsonConverters.StateChangesVariant1Item2JsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.StateChangesVariant1Item2))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0304.Create_StateChangesVariant1Item22(options);
                }
                if (type == typeof(global::Anthropic.StateChangesVariant1Item2?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0238.Create_NullableStateChangesVariant1Item22(options);
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