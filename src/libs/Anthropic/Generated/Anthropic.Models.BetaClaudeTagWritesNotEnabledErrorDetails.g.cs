
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Changes through the Claude Tag API are not enabled for the organization.
    /// </summary>
    public sealed partial class BetaClaudeTagWritesNotEnabledErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"claude_tag_writes_not_enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "claude_tag_writes_not_enabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagWritesNotEnabledErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagWritesNotEnabledErrorDetails(
            string errorCode = "claude_tag_writes_not_enabled")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagWritesNotEnabledErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagWritesNotEnabledErrorDetails()
        {
        }

    }
}