
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApproveSpendLimitIncreaseRequestParams
    {
        /// <summary>
        /// New per-user spend limit as a non-negative integer decimal string (minor units).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("amount")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Amount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod? Period { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suppress_notification")]
        public bool? SuppressNotification { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApproveSpendLimitIncreaseRequestParams" /> class.
        /// </summary>
        /// <param name="amount">
        /// New per-user spend limit as a non-negative integer decimal string (minor units).
        /// </param>
        /// <param name="period"></param>
        /// <param name="suppressNotification"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApproveSpendLimitIncreaseRequestParams(
            string amount,
            global::Anthropic.BetaApproveSpendLimitIncreaseRequestParamsPeriod? period,
            bool? suppressNotification)
        {
            this.Amount = amount ?? throw new global::System.ArgumentNullException(nameof(amount));
            this.Period = period;
            this.SuppressNotification = suppressNotification;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApproveSpendLimitIncreaseRequestParams" /> class.
        /// </summary>
        public BetaApproveSpendLimitIncreaseRequestParams()
        {
        }

    }
}