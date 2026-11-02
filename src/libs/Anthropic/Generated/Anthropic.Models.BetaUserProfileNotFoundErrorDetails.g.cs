
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request depends on a user profile that does not exist in the organization or is no longer active. The request either names this user profile by ID, or names a resource, such as an External Key, that is bound to it.
    /// </summary>
    public sealed partial class BetaUserProfileNotFoundErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"user_profile_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "user_profile_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUserProfileNotFoundErrorDetails(
            string errorCode = "user_profile_not_found")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUserProfileNotFoundErrorDetails" /> class.
        /// </summary>
        public BetaUserProfileNotFoundErrorDetails()
        {
        }

    }
}