
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaUsage
    {
        /// <summary>
        /// Breakdown of cached tokens by TTL<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCacheCreation? CacheCreation { get; set; }

        /// <summary>
        /// The number of input tokens used to create the cache entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// The geographic region where inference was performed for this request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? InferenceGeo { get; set; }

        /// <summary>
        /// The number of input tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Per-iteration token usage breakdown.<br/>
        /// Each entry represents one sampling iteration, with its own input/output token counts and cache statistics. This allows you to:<br/>
        /// - Determine which iterations exceeded long context thresholds (&gt;=200k tokens)<br/>
        /// - Calculate the true context window size from the last iteration<br/>
        /// - Understand token accumulation across server-side tool use loops<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.AnyOf<global::Anthropic.BetaMessageIterationUsage, global::Anthropic.BetaCompactionIterationUsage>>? Iterations { get; set; }

        /// <summary>
        /// The number of output tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The number of server tool requests.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        /// If the request used the priority, standard, or batch tier.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUsageServiceTier2? ServiceTier { get; set; }

        /// <summary>
        /// The inference speed mode used for this request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("speed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSpeed? Speed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsage" /> class.
        /// </summary>
        /// <param name="cacheCreation">
        /// Breakdown of cached tokens by TTL<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// The number of input tokens used to create the cache entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens read from the cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inferenceGeo">
        /// The geographic region where inference was performed for this request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.
        /// </param>
        /// <param name="iterations">
        /// Per-iteration token usage breakdown.<br/>
        /// Each entry represents one sampling iteration, with its own input/output token counts and cache statistics. This allows you to:<br/>
        /// - Determine which iterations exceeded long context thresholds (&gt;=200k tokens)<br/>
        /// - Calculate the true context window size from the last iteration<br/>
        /// - Understand token accumulation across server-side tool use loops<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.
        /// </param>
        /// <param name="serverToolUse">
        /// The number of server tool requests.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceTier">
        /// If the request used the priority, standard, or batch tier.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="speed">
        /// The inference speed mode used for this request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUsage(
            global::Anthropic.BetaCacheCreation? cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            string? inferenceGeo,
            int inputTokens,
            global::System.Collections.Generic.IList<global::Anthropic.AnyOf<global::Anthropic.BetaMessageIterationUsage, global::Anthropic.BetaCompactionIterationUsage>>? iterations,
            int outputTokens,
            global::Anthropic.BetaServerToolUsage? serverToolUse,
            global::Anthropic.BetaUsageServiceTier2? serviceTier,
            global::Anthropic.BetaSpeed? speed)
        {
            this.CacheCreation = cacheCreation ?? throw new global::System.ArgumentNullException(nameof(cacheCreation));
            this.CacheCreationInputTokens = cacheCreationInputTokens ?? throw new global::System.ArgumentNullException(nameof(cacheCreationInputTokens));
            this.CacheReadInputTokens = cacheReadInputTokens ?? throw new global::System.ArgumentNullException(nameof(cacheReadInputTokens));
            this.InferenceGeo = inferenceGeo ?? throw new global::System.ArgumentNullException(nameof(inferenceGeo));
            this.InputTokens = inputTokens;
            this.Iterations = iterations ?? throw new global::System.ArgumentNullException(nameof(iterations));
            this.OutputTokens = outputTokens;
            this.ServerToolUse = serverToolUse ?? throw new global::System.ArgumentNullException(nameof(serverToolUse));
            this.ServiceTier = serviceTier ?? throw new global::System.ArgumentNullException(nameof(serviceTier));
            this.Speed = speed ?? throw new global::System.ArgumentNullException(nameof(speed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsage" /> class.
        /// </summary>
        public BetaUsage()
        {
        }
    }
}