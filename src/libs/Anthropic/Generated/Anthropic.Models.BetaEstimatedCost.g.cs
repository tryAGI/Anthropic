
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaEstimatedCost
    {
        /// <summary>
        /// Estimated cost amount in minor currency units (e.g., cents for USD).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Amount { get; set; }

        /// <summary>
        /// Currency code for the estimated cost (e.g., 'USD').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEstimatedCost" /> class.
        /// </summary>
        /// <param name="amount">
        /// Estimated cost amount in minor currency units (e.g., cents for USD).
        /// </param>
        /// <param name="currency">
        /// Currency code for the estimated cost (e.g., 'USD').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEstimatedCost(
            int amount,
            string currency)
        {
            this.Amount = amount;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEstimatedCost" /> class.
        /// </summary>
        public BetaEstimatedCost()
        {
        }

    }
}