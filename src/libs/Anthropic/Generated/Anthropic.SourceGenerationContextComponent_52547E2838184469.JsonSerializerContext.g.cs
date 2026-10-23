
#nullable enable
namespace Anthropic
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_52547E2838184469
    {

        internal static readonly global::Anthropic.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::Anthropic.SourceGenerationContextMetadataScope>[] {
                    static () => global::Anthropic.SourceGenerationContextComponent_61FB6108186E2A01.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_935451E1B2F6FDF0.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_CE95F296E000495F.MetadataScope,                    static () => global::Anthropic.SourceGenerationContextComponent_DB6D7E1D18D86779.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::Anthropic.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthJsonConverter>(static () => new global::Anthropic.JsonConverters.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthJsonConverter());
            collector.AddEager<global::Anthropic.JsonConverters.UnixTimestampJsonConverter>(static () => new global::Anthropic.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0071.Create_BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth2(options);
                }
                if (type == typeof(global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth?))
                {
                    return global::Anthropic.SourceGenerationContextMetadata0FactoryBatch0218.Create_NullableBetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth2(options);
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