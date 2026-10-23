
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_9DB92A1955AE498C
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_1D30754F16897F7A.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_2B63F4E4A6DAB32F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8A57A5D78896C1A2.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_A20FF0894118D7D9.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_F8C46EF9273A8CF8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.StateChangesVariant1ItemJsonConverter>(static () => new global::Anthropic.JsonConverters.StateChangesVariant1ItemJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.StateChangesVariant1Item))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0321.Create_StateChangesVariant1Item2_3(options);
                }
                if (type == typeof(global::Anthropic.StateChangesVariant1Item?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0256.Create_NullableStateChangesVariant1Item2_3(options);
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