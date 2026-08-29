
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Cumulative token usage for a session thread across all turns.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadUsage2
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
        /// Cumulative list cost of this thread across all turns, priced at public list rates. Absent until cost tracking is available for the thread. Each figure is rounded to the nearest cent independently and the session's aggregate `usage.list_cost` additionally includes session runtime, so per-thread costs do not sum exactly to the session figure; the session figure is authoritative and is what a budget is enforced against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_cost")]
        public global::Anthropic.BetaMonetaryAmount? ListCost { get; set; }

        /// <summary>
        /// Cumulative time in seconds this thread spent in running status. Equal to `stats.active_seconds`; surfaced here so a thread's usage carries every quantity its cost is priced on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_seconds")]
        public double? ActiveSeconds { get; set; }

        /// <summary>
        /// Cumulative server-executed tool usage across all turns of this thread. Absent until server-tool tracking is available for the thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::Anthropic.BetaManagedAgentsServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadUsage2" /> class.
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
        /// <param name="listCost">
        /// Cumulative list cost of this thread across all turns, priced at public list rates. Absent until cost tracking is available for the thread. Each figure is rounded to the nearest cent independently and the session's aggregate `usage.list_cost` additionally includes session runtime, so per-thread costs do not sum exactly to the session figure; the session figure is authoritative and is what a budget is enforced against.
        /// </param>
        /// <param name="activeSeconds">
        /// Cumulative time in seconds this thread spent in running status. Equal to `stats.active_seconds`; surfaced here so a thread's usage carries every quantity its cost is priced on.
        /// </param>
        /// <param name="serverToolUse">
        /// Cumulative server-executed tool usage across all turns of this thread. Absent until server-tool tracking is available for the thread.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionThreadUsage2(
            int? inputTokens,
            int? outputTokens,
            int? cacheReadInputTokens,
            global::Anthropic.BetaManagedAgentsCacheCreationUsage? cacheCreation,
            global::Anthropic.BetaMonetaryAmount? listCost,
            double? activeSeconds,
            global::Anthropic.BetaManagedAgentsServerToolUsage? serverToolUse)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreation = cacheCreation;
            this.ListCost = listCost;
            this.ActiveSeconds = activeSeconds;
            this.ServerToolUse = serverToolUse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadUsage2" /> class.
        /// </summary>
        public BetaManagedAgentsSessionThreadUsage2()
        {
        }

    }
}