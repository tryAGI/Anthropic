
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The customer that the request's user profile represents has not authorized the caller to bill them, or the authorization that the request's credential uses has ended. The response does not say which applies.
    /// </summary>
    public sealed partial class UserProfileBillingNotAuthorizedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_profile_billing_not_authorized"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "user_profile_billing_not_authorized";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileBillingNotAuthorizedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserProfileBillingNotAuthorizedErrorDetails(
            string errorCode = "user_profile_billing_not_authorized")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileBillingNotAuthorizedErrorDetails" /> class.
        /// </summary>
        public UserProfileBillingNotAuthorizedErrorDetails()
        {
        }

    }
}