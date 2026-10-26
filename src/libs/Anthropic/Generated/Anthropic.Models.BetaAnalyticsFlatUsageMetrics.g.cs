
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The token usage of one row.
    /// </summary>
    public sealed partial class BetaAnalyticsFlatUsageMetrics
    {
        /// <summary>
        /// The number of input tokens for cache creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCacheCreation CacheCreation { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadInputTokens { get; set; }

        /// <summary>
        /// The number of output tokens generated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Number of API requests in this row's scope. For sandbox / code-execution events, this counts execution spans rather than HTTP requests (these rows surface with `product: null`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Server-side tool usage metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServerToolUse ServerToolUse { get; set; }

        /// <summary>
        /// Total token count across all token types. This is the value the default `order_by` (`total_tokens`) sorts on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// The number of uncached input tokens processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UncachedInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatUsageMetrics" /> class.
        /// </summary>
        /// <param name="cacheCreation">
        /// The number of input tokens for cache creation.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens read from the cache.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens generated.
        /// </param>
        /// <param name="serverToolUse">
        /// Server-side tool usage metrics.
        /// </param>
        /// <param name="totalTokens">
        /// Total token count across all token types. This is the value the default `order_by` (`total_tokens`) sorts on.
        /// </param>
        /// <param name="uncachedInputTokens">
        /// The number of uncached input tokens processed.
        /// </param>
        /// <param name="requests">
        /// Number of API requests in this row's scope. For sandbox / code-execution events, this counts execution spans rather than HTTP requests (these rows surface with `product: null`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFlatUsageMetrics(
            global::Anthropic.BetaCacheCreation cacheCreation,
            int cacheReadInputTokens,
            int outputTokens,
            global::Anthropic.BetaServerToolUse serverToolUse,
            int totalTokens,
            int uncachedInputTokens,
            int? requests)
        {
            this.CacheCreation = cacheCreation ?? throw new global::System.ArgumentNullException(nameof(cacheCreation));
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.OutputTokens = outputTokens;
            this.Requests = requests;
            this.ServerToolUse = serverToolUse ?? throw new global::System.ArgumentNullException(nameof(serverToolUse));
            this.TotalTokens = totalTokens;
            this.UncachedInputTokens = uncachedInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatUsageMetrics" /> class.
        /// </summary>
        public BetaAnalyticsFlatUsageMetrics()
        {
        }

    }
}