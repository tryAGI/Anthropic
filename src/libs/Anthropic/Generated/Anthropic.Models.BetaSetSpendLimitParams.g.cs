
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSetSpendLimitParams
    {
        /// <summary>
        /// Limit amount as a non-negative integer decimal string in the minor unit of the organization's billing currency (cents for USD): "50000" is $500.00. `null` sets an explicit no-limit override for this scope and `period` only — each period resolves independently, so caps for other periods still apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        public string? Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSetSpendLimitParamsPeriodJsonConverter))]
        public global::Anthropic.BetaSetSpendLimitParamsPeriod? Period { get; set; }

        /// <summary>
        /// Scope selecting a single member of the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaUserScope Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSetSpendLimitParams" /> class.
        /// </summary>
        /// <param name="scope">
        /// Scope selecting a single member of the organization.
        /// </param>
        /// <param name="amount">
        /// Limit amount as a non-negative integer decimal string in the minor unit of the organization's billing currency (cents for USD): "50000" is $500.00. `null` sets an explicit no-limit override for this scope and `period` only — each period resolves independently, so caps for other periods still apply.
        /// </param>
        /// <param name="period"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSetSpendLimitParams(
            global::Anthropic.BetaUserScope scope,
            string? amount,
            global::Anthropic.BetaSetSpendLimitParamsPeriod? period)
        {
            this.Amount = amount;
            this.Period = period;
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSetSpendLimitParams" /> class.
        /// </summary>
        public BetaSetSpendLimitParams()
        {
        }

    }
}