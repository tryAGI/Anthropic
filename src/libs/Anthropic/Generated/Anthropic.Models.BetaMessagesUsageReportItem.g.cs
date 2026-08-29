
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMessagesUsageReportItem
    {
        /// <summary>
        /// The number of uncached input tokens processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncached_input_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int UncachedInputTokens { get; set; }

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
        /// Server-side tool usage metrics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_tool_use")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaServerToolUse ServerToolUse { get; set; }

        /// <summary>
        /// ID of the API key used. `null` if not grouping by API key or for usage in the Anthropic Console.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        public string? ApiKeyId { get; set; }

        /// <summary>
        /// ID of the Workspace used. `null` if not grouping by workspace or for the default workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// ID of the user account that made the request. `null` if not grouping by account or for non-OAuth requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account_id")]
        public string? AccountId { get; set; }

        /// <summary>
        /// ID of the service account that made the request. `null` if not grouping by service account or for non-OIDC-federation requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        public string? ServiceAccountId { get; set; }

        /// <summary>
        /// Model used. `null` if not grouping by model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Service tier used. `null` if not grouping by service tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::Anthropic.BetaUsageReportServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Context window used. `null` if not grouping by context window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public global::Anthropic.BetaMessagesUsageReportContextWindow? ContextWindow { get; set; }

        /// <summary>
        /// Inference geo used matching requests' `inference_geo` parameter if set, otherwise the workspace's `default_inference_geo`.<br/>
        /// For models that do not support specifying `inference_geo` the value is `"not_available"`. Always `null` if not grouping by inference geo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_geo")]
        public global::Anthropic.BetaInferenceGeoFilter? InferenceGeo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesUsageReportItem" /> class.
        /// </summary>
        /// <param name="uncachedInputTokens">
        /// The number of uncached input tokens processed.
        /// </param>
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
        /// <param name="apiKeyId">
        /// ID of the API key used. `null` if not grouping by API key or for usage in the Anthropic Console.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the Workspace used. `null` if not grouping by workspace or for the default workspace.
        /// </param>
        /// <param name="accountId">
        /// ID of the user account that made the request. `null` if not grouping by account or for non-OAuth requests.
        /// </param>
        /// <param name="serviceAccountId">
        /// ID of the service account that made the request. `null` if not grouping by service account or for non-OIDC-federation requests.
        /// </param>
        /// <param name="model">
        /// Model used. `null` if not grouping by model.
        /// </param>
        /// <param name="serviceTier">
        /// Service tier used. `null` if not grouping by service tier.
        /// </param>
        /// <param name="contextWindow">
        /// Context window used. `null` if not grouping by context window.
        /// </param>
        /// <param name="inferenceGeo">
        /// Inference geo used matching requests' `inference_geo` parameter if set, otherwise the workspace's `default_inference_geo`.<br/>
        /// For models that do not support specifying `inference_geo` the value is `"not_available"`. Always `null` if not grouping by inference geo.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessagesUsageReportItem(
            int uncachedInputTokens,
            global::Anthropic.BetaCacheCreation cacheCreation,
            int cacheReadInputTokens,
            int outputTokens,
            global::Anthropic.BetaServerToolUse serverToolUse,
            string? apiKeyId,
            string? workspaceId,
            string? accountId,
            string? serviceAccountId,
            string? model,
            global::Anthropic.BetaUsageReportServiceTier? serviceTier,
            global::Anthropic.BetaMessagesUsageReportContextWindow? contextWindow,
            global::Anthropic.BetaInferenceGeoFilter? inferenceGeo)
        {
            this.UncachedInputTokens = uncachedInputTokens;
            this.CacheCreation = cacheCreation ?? throw new global::System.ArgumentNullException(nameof(cacheCreation));
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.OutputTokens = outputTokens;
            this.ServerToolUse = serverToolUse ?? throw new global::System.ArgumentNullException(nameof(serverToolUse));
            this.ApiKeyId = apiKeyId;
            this.WorkspaceId = workspaceId;
            this.AccountId = accountId;
            this.ServiceAccountId = serviceAccountId;
            this.Model = model;
            this.ServiceTier = serviceTier;
            this.ContextWindow = contextWindow;
            this.InferenceGeo = inferenceGeo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesUsageReportItem" /> class.
        /// </summary>
        public BetaMessagesUsageReportItem()
        {
        }

    }
}