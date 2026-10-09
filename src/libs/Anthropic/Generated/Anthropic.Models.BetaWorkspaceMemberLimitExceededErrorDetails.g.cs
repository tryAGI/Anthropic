
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The workspace has reached the member limit that Anthropic set for it.
    /// </summary>
    public sealed partial class BetaWorkspaceMemberLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_member_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "workspace_member_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceMemberLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceMemberLimitExceededErrorDetails(
            string errorCode = "workspace_member_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceMemberLimitExceededErrorDetails" /> class.
        /// </summary>
        public BetaWorkspaceMemberLimitExceededErrorDetails()
        {
        }

    }
}