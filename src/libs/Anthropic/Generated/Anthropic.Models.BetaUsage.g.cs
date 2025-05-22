
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCacheCreation CacheCreation { get; set; }

        /// <summary>
        /// The number of input tokens used to create the cache entry.<br/>
        /// Example: 2051
        /// </summary>
        /// <example>2051</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.<br/>
        /// Example: 2051
        /// </summary>
        /// <example>2051</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens which were used.<br/>
        /// Example: 2095
        /// </summary>
        /// <example>2095</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int InputTokens { get; set; }

        /// <summary>
        /// The number of output tokens which were used.<br/>
        /// Example: 503
        /// </summary>
        /// <example>503</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServerToolUsage ServerToolUse { get; set; }

        /// <summary>
        /// If the request used the priority, standard, or batch tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaUsageServiceTierJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUsageServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsage" /> class.
        /// </summary>
        /// <param name="cacheCreation"></param>
        /// <param name="cacheCreationInputTokens">
        /// The number of input tokens used to create the cache entry.<br/>
        /// Example: 2051
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// The number of input tokens read from the cache.<br/>
        /// Example: 2051
        /// </param>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.<br/>
        /// Example: 2095
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.<br/>
        /// Example: 503
        /// </param>
        /// <param name="serverToolUse"></param>
        /// <param name="serviceTier">
        /// If the request used the priority, standard, or batch tier.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUsage(
            global::Anthropic.BetaCacheCreation cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            int inputTokens,
            int outputTokens,
            global::Anthropic.BetaServerToolUsage serverToolUse,
            global::Anthropic.BetaUsageServiceTier? serviceTier)
        {
            this.CacheCreation = cacheCreation ?? throw new global::System.ArgumentNullException(nameof(cacheCreation));
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.ServerToolUse = serverToolUse ?? throw new global::System.ArgumentNullException(nameof(serverToolUse));
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUsage" /> class.
        /// </summary>
        public BetaUsage()
        {
        }
    }
}