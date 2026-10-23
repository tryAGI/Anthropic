
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FEB1029823751883
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_828F80780C26E9F3.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_8937977394D584BD.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_B6E0D10C610AE129.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DEC7666C604725C9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsAgentAutoEvaluatedPermissionJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsAgentAutoEvaluatedPermissionJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0048.Create_BetaManagedAgentsAgentAutoEvaluatedPermission2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsAgentAutoEvaluatedPermission?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0207.Create_NullableBetaManagedAgentsAgentAutoEvaluatedPermission2(options);
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