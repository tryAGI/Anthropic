
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The email address's domain is not one of the verified domains of the organization's parent organization.
    /// </summary>
    public sealed partial class CannotInviteEmailsWithUnverifiedDomainsErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cannot_invite_emails_with_unverified_domains"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cannot_invite_emails_with_unverified_domains";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CannotInviteEmailsWithUnverifiedDomainsErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CannotInviteEmailsWithUnverifiedDomainsErrorDetails(
            string errorCode = "cannot_invite_emails_with_unverified_domains")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CannotInviteEmailsWithUnverifiedDomainsErrorDetails" /> class.
        /// </summary>
        public CannotInviteEmailsWithUnverifiedDomainsErrorDetails()
        {
        }

    }
}