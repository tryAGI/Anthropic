
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Usage
    {
        /// <summary>
        /// Breakdown of cached tokens by TTL<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::Anthropic.CacheCreation? CacheCreation { get; set; }

        /// <summary>
        /// The number of input tokens used to create the cache entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// The number of input tokens read from the cache.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// The geographic region where inference was performed for this request.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public string? InferenceGeo { get; set; }

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
        /// The number of server tool requests.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        public global::Anthropic.ServerToolUsage? ServerToolUse { get; set; }

        /// <summary>
        /// If the request used the priority, standard, or batch tier.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::Anthropic.UsageServiceTier2? ServiceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// The number of input tokens which were used.
        /// </param>
        /// <param name="outputTokens">
        /// The number of output tokens which were used.
        /// </param>
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
        /// <param name="serverToolUse">
        /// The number of server tool requests.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceTier">
        /// If the request used the priority, standard, or batch tier.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Usage(
            int inputTokens,
            int outputTokens,
            global::Anthropic.CacheCreation? cacheCreation,
            int? cacheCreationInputTokens,
            int? cacheReadInputTokens,
            string? inferenceGeo,
            global::Anthropic.ServerToolUsage? serverToolUse,
            global::Anthropic.UsageServiceTier2? serviceTier)
        {
            this.CacheCreation = cacheCreation;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.InferenceGeo = inferenceGeo;
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.ServerToolUse = serverToolUse;
            this.ServiceTier = serviceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage" /> class.
        /// </summary>
        public Usage()
        {
        }
    }
}