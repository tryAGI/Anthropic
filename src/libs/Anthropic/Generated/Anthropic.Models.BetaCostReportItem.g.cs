
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaCostReportItem
    {
        /// <summary>
        /// Currency code for the cost amount. Currently always `"USD"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Cost amount in lowest currency units (e.g. cents) as a decimal string. For example, `"123.45"` in `"USD"` represents `$1.23`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// ID of the Workspace this cost is associated with. `null` if not grouping by workspace or for the default workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Description of the cost item. `null` if not grouping by description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Type of cost. `null` if not grouping by description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_type")]
        public global::Anthropic.BetaCostType? CostType { get; set; }

        /// <summary>
        /// Input context window used. `null` if not grouping by description or for non-token costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_window")]
        public global::Anthropic.BetaMessagesUsageReportContextWindow? ContextWindow { get; set; }

        /// <summary>
        /// Model name used. `null` if not grouping by description or for non-token costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Service tier used. `null` if not grouping by description or for non-token costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_tier")]
        public global::Anthropic.BetaCostReportServiceTier? ServiceTier { get; set; }

        /// <summary>
        /// Type of token. `null` if not grouping by description or for non-token costs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public global::Anthropic.BetaCostReportTokenType? TokenType { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaCostReportItem" /> class.
        /// </summary>
        /// <param name="currency">
        /// Currency code for the cost amount. Currently always `"USD"`.
        /// </param>
        /// <param name="amount">
        /// Cost amount in lowest currency units (e.g. cents) as a decimal string. For example, `"123.45"` in `"USD"` represents `$1.23`.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the Workspace this cost is associated with. `null` if not grouping by workspace or for the default workspace.
        /// </param>
        /// <param name="description">
        /// Description of the cost item. `null` if not grouping by description.
        /// </param>
        /// <param name="costType">
        /// Type of cost. `null` if not grouping by description.
        /// </param>
        /// <param name="contextWindow">
        /// Input context window used. `null` if not grouping by description or for non-token costs.
        /// </param>
        /// <param name="model">
        /// Model name used. `null` if not grouping by description or for non-token costs.
        /// </param>
        /// <param name="serviceTier">
        /// Service tier used. `null` if not grouping by description or for non-token costs.
        /// </param>
        /// <param name="tokenType">
        /// Type of token. `null` if not grouping by description or for non-token costs.
        /// </param>
        /// <param name="inferenceGeo">
        /// Inference geo used matching requests' `inference_geo` parameter if set, otherwise the workspace's `default_inference_geo`.<br/>
        /// For models that do not support specifying `inference_geo` the value is `"not_available"`. Always `null` if not grouping by inference geo.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCostReportItem(
            string currency,
            string amount,
            string? workspaceId,
            string? description,
            global::Anthropic.BetaCostType? costType,
            global::Anthropic.BetaMessagesUsageReportContextWindow? contextWindow,
            string? model,
            global::Anthropic.BetaCostReportServiceTier? serviceTier,
            global::Anthropic.BetaCostReportTokenType? tokenType,
            global::Anthropic.BetaInferenceGeoFilter? inferenceGeo)
        {
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.WorkspaceId = workspaceId;
            this.Description = description;
            this.CostType = costType;
            this.ContextWindow = contextWindow;
            this.Model = model;
            this.ServiceTier = serviceTier;
            this.TokenType = tokenType;
            this.InferenceGeo = inferenceGeo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCostReportItem" /> class.
        /// </summary>
        public BetaCostReportItem()
        {
        }

    }
}