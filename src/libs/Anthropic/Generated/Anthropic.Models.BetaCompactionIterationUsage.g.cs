
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Token usage for a compaction iteration.
    /// </summary>
    public sealed partial class BetaCompactionIterationUsage
    {
        /// <summary>
        /// Breakdown of cached tokens by TTL<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::Anthropic.BetaCacheCreation? CacheCreation { get; set; }

        /// <summary>
        /// The number of input tokens used to create the cache entry.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheCreationInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheReadInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens which were used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// Usage for a compaction iteration<br/>
        /// Default Value: compaction
        /// </summary>
        /// <default>"compaction"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compaction";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionIterationUsage" /> class.
        /// </summary>
        /// <param name="cacheCreation">
        /// Breakdown of cached tokens by TTL<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// The number of input tokens used to create the cache entry.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens read from the cache.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.
        /// </param>
        /// <param name="type">
        /// Usage for a compaction iteration<br/>
        /// Default Value: compaction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionIterationUsage(
            int cacheCreationInputTokens,
            int cacheReadInputTokens,
            int inputTokens,
            int outputTokens,
            global::Anthropic.BetaCacheCreation? cacheCreation,
            string type = "compaction")
        {
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheCreation = cacheCreation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionIterationUsage" /> class.
        /// </summary>
        public BetaCompactionIterationUsage()
        {
        }
    }
}