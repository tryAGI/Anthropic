
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request comes from a Claude Code version older than the minimum that the requested model or the organization requires. Update Claude Code, then retry.
    /// </summary>
    public sealed partial class ClaudeCodeVersionTooOldErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"claude_code_version_too_old"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "claude_code_version_too_old";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaudeCodeVersionTooOldErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClaudeCodeVersionTooOldErrorDetails(
            string errorCode = "claude_code_version_too_old")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClaudeCodeVersionTooOldErrorDetails" /> class.
        /// </summary>
        public ClaudeCodeVersionTooOldErrorDetails()
        {
        }

    }
}