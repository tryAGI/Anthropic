
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tokens that a dream has used so far.<br/>
    /// The counts are zero while the dream is `pending` and update while it is `running`. They can keep changing after a cancel.<br/>
    /// See the [Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#billing) for how dreams are billed. See the [prompt caching guide](https://platform.claude.com/docs/en/build-with-claude/prompt-caching#tracking-cache-performance) for how the input token counts add up.
    /// </summary>
    public sealed partial class BetaDreamUsage
    {
        /// <summary>
        /// The dream's input tokens that weren't read from or written to the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The tokens that the model generated for the dream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// The dream's input tokens that were read from the prompt cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadInputTokens { get; set; }

        /// <summary>
        /// The dream's input tokens that were written to the prompt cache, for both the 5-minute and 1-hour cache durations.
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
        /// The dream's input tokens that weren't read from or written to the prompt cache.
        /// </param>
        /// <param name="outputTokens">
        /// The tokens that the model generated for the dream.
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The dream's input tokens that were read from the prompt cache.
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// The dream's input tokens that were written to the prompt cache, for both the 5-minute and 1-hour cache durations.
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