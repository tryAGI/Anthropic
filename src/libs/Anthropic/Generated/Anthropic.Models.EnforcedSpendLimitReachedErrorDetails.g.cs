
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has crossed the monthly API usage threshold of its API tier.
    /// </summary>
    public sealed partial class EnforcedSpendLimitReachedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enforced_spend_limit_reached"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "enforced_spend_limit_reached";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnforcedSpendLimitReachedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnforcedSpendLimitReachedErrorDetails(
            string errorCode = "enforced_spend_limit_reached")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnforcedSpendLimitReachedErrorDetails" /> class.
        /// </summary>
        public EnforcedSpendLimitReachedErrorDetails()
        {
        }

    }
}