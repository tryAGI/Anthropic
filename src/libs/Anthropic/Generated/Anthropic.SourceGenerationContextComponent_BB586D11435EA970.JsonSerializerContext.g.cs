
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BB586D11435EA970
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_59ACD6BBDE47F310.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_5C58FC238C9FE44F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_9B0FAFAAB63E33C4.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_BFEA3DD7931FFA1A.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0071.Create_BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0218.Create_NullableBetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth2(options);
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