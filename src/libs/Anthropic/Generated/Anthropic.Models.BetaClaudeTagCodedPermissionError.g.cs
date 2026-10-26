
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Returned with status 403. `details.error_code` names the cause.
    /// </summary>
    public sealed partial class BetaClaudeTagCodedPermissionError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"permission_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "permission_error";

        /// <summary>
        /// A human-readable explanation of the refusal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.BetaClaudeTagCodedPermissionErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagCodedPermissionError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the refusal.
        /// </param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagCodedPermissionError(
            string? message,
            global::Anthropic.BetaClaudeTagCodedPermissionErrorDetails? details,
            string type = "permission_error")
        {
            this.Type = type;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagCodedPermissionError" /> class.
        /// </summary>
        public BetaClaudeTagCodedPermissionError()
        {
        }

    }
}