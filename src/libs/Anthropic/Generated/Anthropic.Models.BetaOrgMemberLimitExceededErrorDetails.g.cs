
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has reached the member limit that Anthropic set for it. Pending invites count toward the limit.
    /// </summary>
    public sealed partial class BetaOrgMemberLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"org_member_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "org_member_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrgMemberLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrgMemberLimitExceededErrorDetails(
            string errorCode = "org_member_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrgMemberLimitExceededErrorDetails" /> class.
        /// </summary>
        public BetaOrgMemberLimitExceededErrorDetails()
        {
        }

    }
}