
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The cost of one row.
    /// </summary>
    public sealed partial class BetaAnalyticsFlatCostMetrics
    {
        /// <summary>
        /// Amount (post-discount, pre-credit) in fractional cents (minor units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// Currency code for the cost amount. Currently always `"USD"`.<br/>
        /// Default Value: USD
        /// </summary>
        /// <default>"USD"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; } = "USD";

        /// <summary>
        /// List-price amount (pre-discount) in fractional cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ListAmount { get; set; }

        /// <summary>
        /// Number of API requests in this row's scope. Null when `group_by` includes `cost_type` or `token_type` (the count has no per-component attribution; read it from the ungrouped response). For sandbox / code-execution events, this counts execution spans rather than HTTP requests (these rows surface with `product: null`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requests")]
        public int? Requests { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatCostMetrics" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount (post-discount, pre-credit) in fractional cents (minor units).
        /// </param>
        /// <param name="currency">
        /// Currency code for the cost amount. Currently always `"USD"`.<br/>
        /// Default Value: USD
        /// </param>
        /// <param name="listAmount">
        /// List-price amount (pre-discount) in fractional cents.
        /// </param>
        /// <param name="requests">
        /// Number of API requests in this row's scope. Null when `group_by` includes `cost_type` or `token_type` (the count has no per-component attribution; read it from the ungrouped response). For sandbox / code-execution events, this counts execution spans rather than HTTP requests (these rows surface with `product: null`).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFlatCostMetrics(
            string amount,
            string currency,
            string listAmount,
            int? requests)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.ListAmount = listAmount ?? throw new global::System.ArgumentNullException(nameof(listAmount));
            this.Requests = requests;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatCostMetrics" /> class.
        /// </summary>
        public BetaAnalyticsFlatCostMetrics()
        {
        }

    }
}