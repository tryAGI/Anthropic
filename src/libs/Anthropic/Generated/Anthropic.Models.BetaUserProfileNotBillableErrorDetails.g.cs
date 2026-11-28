
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request's user profile cannot be billed. The response gives no more specific error code and does not say what the reason is.
    /// </summary>
    public sealed partial class BetaUserProfileNotBillableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_profile_not_billable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "user_profile_not_billable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileNotBillableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileNotBillableErrorDetails(
            string errorCode = "user_profile_not_billable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileNotBillableErrorDetails" /> class.
        /// </summary>
        public BetaUserProfileNotBillableErrorDetails()
        {
        }

    }
}