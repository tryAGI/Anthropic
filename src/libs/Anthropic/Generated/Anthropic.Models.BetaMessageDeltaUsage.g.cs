
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageDeltaUsage
    {
        /// <summary>
        /// The cumulative number of input tokens used to create the cache entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// The cumulative number of input tokens read from the cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Outcome of the `fallback_credit_token` presented on this request.<br/>
        /// Present on every response to a non-batch request that carried a<br/>
        /// `fallback_credit_token`, in either redemption mode; absent otherwise (batch<br/>
        /// items accept and ignore the token and carry no outcome object).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fallback_credit")]
        public global::Anthropic.BetaFallbackCreditUsage? FallbackCredit { get; set; }

        /// <summary>
        /// The cumulative number of input tokens which were used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Per-iteration token usage breakdown.<br/>
        /// Each entry represents one sampling iteration, with its own input/output token counts and cache statistics. This allows you to:<br/>
        /// - Determine which iterations exceeded long context thresholds (&gt;=200k tokens)<br/>
        /// - Calculate the true context window size from the last iteration<br/>
        /// - Understand token accumulation across server-side tool use loops<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iterations")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? Iterations { get; set; }

        /// <summary>
        /// The cumulative number of output tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Breakdown of output tokens by category.<br/>
        /// `output_tokens` remains the inclusive, authoritative total used for billing.<br/>
        /// This object provides a read-only decomposition for observability — for example,<br/>
        /// how many of the billed output tokens were spent on internal reasoning that may<br/>
        /// have been summarized before being returned to you.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::Anthropic.BetaOutputTokensDetails? OutputTokensDetails { get; set; }

        /// <summary>
        /// The number of server tool requests.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::Anthropic.BetaServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDeltaUsage" /> class.
        /// </summary>
        /// <param name="outputTokens">
        /// The cumulative number of output tokens which were used.
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// The cumulative number of input tokens used to create the cache entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The cumulative number of input tokens read from the cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="fallbackCredit">
        /// Outcome of the `fallback_credit_token` presented on this request.<br/>
        /// Present on every response to a non-batch request that carried a<br/>
        /// `fallback_credit_token`, in either redemption mode; absent otherwise (batch<br/>
        /// items accept and ignore the token and carry no outcome object).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="inputTokens">
        /// The cumulative number of input tokens which were used.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="iterations">
        /// Per-iteration token usage breakdown.<br/>
        /// Each entry represents one sampling iteration, with its own input/output token counts and cache statistics. This allows you to:<br/>
        /// - Determine which iterations exceeded long context thresholds (&gt;=200k tokens)<br/>
        /// - Calculate the true context window size from the last iteration<br/>
        /// - Understand token accumulation across server-side tool use loops<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="outputTokensDetails">
        /// Breakdown of output tokens by category.<br/>
        /// `output_tokens` remains the inclusive, authoritative total used for billing.<br/>
        /// This object provides a read-only decomposition for observability — for example,<br/>
        /// how many of the billed output tokens were spent on internal reasoning that may<br/>
        /// have been summarized before being returned to you.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serverToolUse">
        /// The number of server tool requests.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessageDeltaUsage(
            int outputTokens,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            global::Anthropic.BetaFallbackCreditUsage? fallbackCredit,
            int? inputTokens,
            global::System.Collections.Generic.IList<global::Anthropic.BetaIterationsUsageVariant1Item>? iterations,
            global::Anthropic.BetaOutputTokensDetails? outputTokensDetails,
            global::Anthropic.BetaServerToolUsage? serverToolUse)
        {
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.FallbackCredit = fallbackCredit;
            this.InputTokens = inputTokens;
            this.Iterations = iterations;
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails;
            this.ServerToolUse = serverToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageDeltaUsage" /> class.
        /// </summary>
        public BetaMessageDeltaUsage()
        {
        }

    }
}