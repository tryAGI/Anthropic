
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Returned with status 400 when the request set the channel up and `settings` was then refused. The channel stays set up with every setting unset.
    /// </summary>
    public sealed partial class BetaClaudeTagSetUpSettingsRefusedError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"invalid_request_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "invalid_request_error";

        /// <summary>
        /// A human-readable explanation of what in `settings` was refused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.BetaClaudeTagSetUpSettingsRefusedErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSetUpSettingsRefusedError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of what in `settings` was refused.
        /// </param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSetUpSettingsRefusedError(
            string? message,
            global::Anthropic.BetaClaudeTagSetUpSettingsRefusedErrorDetails? details,
            string type = "invalid_request_error")
        {
            this.Type = type;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSetUpSettingsRefusedError" /> class.
        /// </summary>
        public BetaClaudeTagSetUpSettingsRefusedError()
        {
        }

    }
}