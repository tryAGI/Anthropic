
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative token usage for the dream across every pipeline stage.
    /// </summary>
    public sealed partial class BetaDreamUsage
    {
        /// <summary>
        /// Total uncached input tokens consumed across every pipeline stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// Total output tokens generated across every pipeline stage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Total tokens read from prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadInputTokens { get; set; }

        /// <summary>
        /// Total tokens used to create prompt-cache entries (sum of all TTL tiers).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheCreationInputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Total uncached input tokens consumed across every pipeline stage.
        /// </param>
        /// <param name="outputTokens">
        /// Total output tokens generated across every pipeline stage.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Total tokens read from prompt cache.
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// Total tokens used to create prompt-cache entries (sum of all TTL tiers).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamUsage(
            int inputTokens,
            int outputTokens,
            int cacheReadInputTokens,
            int cacheCreationInputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamUsage" /> class.
        /// </summary>
        public BetaDreamUsage()
        {
        }

    }
}