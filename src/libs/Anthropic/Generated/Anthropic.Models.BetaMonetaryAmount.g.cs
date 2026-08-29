
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A monetary amount in a specific currency.<br/>
    /// Example: {"currency":"USD","amount":"2500"}
    /// </summary>
    public sealed partial class BetaMonetaryAmount
    {
        /// <summary>
        /// Uppercase ISO-4217 currency code. `USD` is the only currency currently supported; the accepted set is closed and grows only when a new currency is priced.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaCurrencyJsonConverter))]
        public global::Anthropic.BetaCurrency Currency { get; set; }

        /// <summary>
        /// Amount in minor units of the currency, as an integer decimal string with no leading zeros: "2500" is $25.00 and "50" is fifty cents. A string rather than a number so no float rounding is ever applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMonetaryAmount" /> class.
        /// </summary>
        /// <param name="amount">
        /// Amount in minor units of the currency, as an integer decimal string with no leading zeros: "2500" is $25.00 and "50" is fifty cents. A string rather than a number so no float rounding is ever applied.
        /// </param>
        /// <param name="currency">
        /// Uppercase ISO-4217 currency code. `USD` is the only currency currently supported; the accepted set is closed and grows only when a new currency is priced.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMonetaryAmount(
            string amount,
            global::Anthropic.BetaCurrency currency)
        {
            this.Currency = currency;
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMonetaryAmount" /> class.
        /// </summary>
        public BetaMonetaryAmount()
        {
        }

    }
}