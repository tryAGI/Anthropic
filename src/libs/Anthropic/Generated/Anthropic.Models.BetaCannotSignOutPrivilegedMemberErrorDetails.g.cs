
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// This OAuth token cannot sign out a membership admin or a member whose roles grant owner, user management, or identity and access management.
    /// </summary>
    public sealed partial class BetaCannotSignOutPrivilegedMemberErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_sign_out_privileged_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_sign_out_privileged_member";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutPrivilegedMemberErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCannotSignOutPrivilegedMemberErrorDetails(
            string errorCode = "cannot_sign_out_privileged_member")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCannotSignOutPrivilegedMemberErrorDetails" /> class.
        /// </summary>
        public BetaCannotSignOutPrivilegedMemberErrorDetails()
        {
        }

    }
}