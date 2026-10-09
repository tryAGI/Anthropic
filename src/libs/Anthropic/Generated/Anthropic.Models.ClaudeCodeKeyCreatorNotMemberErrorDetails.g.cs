
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The API key belongs to the Claude Code workspace, and the user who created it is no longer a member of the organization or of that workspace.
    /// </summary>
    public sealed partial class ClaudeCodeKeyCreatorNotMemberErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"claude_code_key_creator_not_member"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "claude_code_key_creator_not_member";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaudeCodeKeyCreatorNotMemberErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaudeCodeKeyCreatorNotMemberErrorDetails(
            string errorCode = "claude_code_key_creator_not_member")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaudeCodeKeyCreatorNotMemberErrorDetails" /> class.
        /// </summary>
        public ClaudeCodeKeyCreatorNotMemberErrorDetails()
        {
        }

    }
}