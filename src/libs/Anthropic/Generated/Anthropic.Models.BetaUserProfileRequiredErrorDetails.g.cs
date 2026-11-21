
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request sets `billing_policy.bill_to` to `"user_profile"` but names no user profile. Name the profile to bill in the `anthropic-user-profile-id` header.
    /// </summary>
    public sealed partial class BetaUserProfileRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_profile_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "user_profile_required";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileRequiredErrorDetails(
            string errorCode = "user_profile_required")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileRequiredErrorDetails" /> class.
        /// </summary>
        public BetaUserProfileRequiredErrorDetails()
        {
        }

    }
}