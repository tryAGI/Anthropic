
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Returned with status 409 when something else changed the resource while this request ran, or it was removed. Nothing of this request's settings was stored. Read the resource again, then send the change again if it is still needed.
    /// </summary>
    public sealed partial class BetaClaudeTagSettingsConflictError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"conflict_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "conflict_error";

        /// <summary>
        /// A human-readable explanation of the conflict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Set only when the request had set a channel up before the conflict.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.BetaClaudeTagSettingsConflictErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingsConflictError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the conflict.
        /// </param>
        /// <param name="details">
        /// Set only when the request had set a channel up before the conflict.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSettingsConflictError(
            string? message,
            global::Anthropic.BetaClaudeTagSettingsConflictErrorDetails? details,
            string type = "conflict_error")
        {
            this.Type = type;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingsConflictError" /> class.
        /// </summary>
        public BetaClaudeTagSettingsConflictError()
        {
        }

    }
}