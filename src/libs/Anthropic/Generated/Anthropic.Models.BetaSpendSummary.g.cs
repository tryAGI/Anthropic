
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Per-member effective-limit report row (`GET /spend_limits/effective`).
    /// </summary>
    public sealed partial class BetaSpendSummary
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Actor2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Actor2 Actor { get; set; }

        /// <summary>
        /// Effective limit amount as a non-negative integer decimal string in the minor unit of `currency` (cents for USD). `null` means no limit applies for this row's `period` — each period resolves independently, so another period may still cap this member.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        /// ISO 4217 code of the organization's billing currency; the unit for `amount` and `period_to_date_spend`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Period this row's effective limit and spend are reported for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSpendSummaryPeriodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSpendSummaryPeriod Period { get; set; }

        /// <summary>
        /// The member's spend so far in the current period, as a non-negative decimal string in the minor unit of `currency` (cents for USD). May carry fractional minor units up to three decimal places (e.g. `"12050.5"`) — metered usage is not rounded to whole cents. Reads as `"0"` when the spend reading is temporarily unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period_to_date_spend")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PeriodToDateSpend { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Scope4JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Scope4 Scope { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Source7JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Source7 Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpendLimitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendSummary" /> class.
        /// </summary>
        /// <param name="actor"></param>
        /// <param name="currency">
        /// ISO 4217 code of the organization's billing currency; the unit for `amount` and `period_to_date_spend`.
        /// </param>
        /// <param name="period">
        /// Period this row's effective limit and spend are reported for.
        /// </param>
        /// <param name="periodToDateSpend">
        /// The member's spend so far in the current period, as a non-negative decimal string in the minor unit of `currency` (cents for USD). May carry fractional minor units up to three decimal places (e.g. `"12050.5"`) — metered usage is not rounded to whole cents. Reads as `"0"` when the spend reading is temporarily unavailable.
        /// </param>
        /// <param name="scope"></param>
        /// <param name="source"></param>
        /// <param name="spendLimitId"></param>
        /// <param name="amount">
        /// Effective limit amount as a non-negative integer decimal string in the minor unit of `currency` (cents for USD). `null` means no limit applies for this row's `period` — each period resolves independently, so another period may still cap this member.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSpendSummary(
            global::Anthropic.Actor2 actor,
            string currency,
            global::Anthropic.BetaSpendSummaryPeriod period,
            string periodToDateSpend,
            global::Anthropic.Scope4 scope,
            global::Anthropic.Source7 source,
            string spendLimitId,
            string? amount)
        {
            this.Actor = actor;
            this.Amount = amount;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
            this.Period = period;
            this.PeriodToDateSpend = periodToDateSpend ?? throw new global::System.ArgumentNullException(nameof(periodToDateSpend));
            this.Scope = scope;
            this.Source = source;
            this.SpendLimitId = spendLimitId ?? throw new global::System.ArgumentNullException(nameof(spendLimitId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendSummary" /> class.
        /// </summary>
        public BetaSpendSummary()
        {
        }

    }
}