
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization restricts invites to an allowed list of email domains, and the list is empty or does not include the email address's domain.
    /// </summary>
    public sealed partial class EmailDomainNotAllowedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"email_domain_not_allowed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "email_domain_not_allowed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDomainNotAllowedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmailDomainNotAllowedErrorDetails(
            string errorCode = "email_domain_not_allowed")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDomainNotAllowedErrorDetails" /> class.
        /// </summary>
        public EmailDomainNotAllowedErrorDetails()
        {
        }

    }
}