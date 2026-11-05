
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The member is a membership admin, and the person the API key or token belongs to is not allowed to sign out membership admins.
    /// </summary>
    public sealed partial class BetaCannotSignOutMembershipAdminErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_sign_out_membership_admin"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_sign_out_membership_admin";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutMembershipAdminErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCannotSignOutMembershipAdminErrorDetails(
            string errorCode = "cannot_sign_out_membership_admin")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutMembershipAdminErrorDetails" /> class.
        /// </summary>
        public BetaCannotSignOutMembershipAdminErrorDetails()
        {
        }

    }
}