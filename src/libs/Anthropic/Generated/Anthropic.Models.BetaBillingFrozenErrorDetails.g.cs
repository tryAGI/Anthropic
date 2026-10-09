
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has temporarily disabled billing changes for the user account the credential belongs to. Contact support.
    /// </summary>
    public sealed partial class BetaBillingFrozenErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"billing_frozen"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "billing_frozen";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBillingFrozenErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBillingFrozenErrorDetails(
            string errorCode = "billing_frozen")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBillingFrozenErrorDetails" /> class.
        /// </summary>
        public BetaBillingFrozenErrorDetails()
        {
        }

    }
}