
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative token usage for a session across all turns.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionUsage
    {
        /// <summary>
        /// Total input tokens consumed across all turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Total output tokens generated across all turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Total tokens read from prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Tokens used to create prompt cache entries, broken down by cache TTL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::Anthropic.BetaManagedAgentsCacheCreationUsage? CacheCreation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Total input tokens consumed across all turns.
        /// </param>
        /// <param name="outputTokens">
        /// Total output tokens generated across all turns.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Total tokens read from prompt cache.
        /// </param>
        /// <param name="cacheCreation">
        /// Tokens used to create prompt cache entries, broken down by cache TTL.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionUsage(
            int? inputTokens,
            int? outputTokens,
            int? cacheReadInputTokens,
            global::Anthropic.BetaManagedAgentsCacheCreationUsage? cacheCreation)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreation = cacheCreation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionUsage" /> class.
        /// </summary>
        public BetaManagedAgentsSessionUsage()
        {
        }
    }
}