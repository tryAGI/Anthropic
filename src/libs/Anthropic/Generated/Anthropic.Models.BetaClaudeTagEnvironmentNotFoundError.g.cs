
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Returned with status 404 when `settings.environment_id` names no Environment within the organization's reach. It says nothing about the `id` in the path.
    /// </summary>
    public sealed partial class BetaClaudeTagEnvironmentNotFoundError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"not_found_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "not_found_error";

        /// <summary>
        /// A human-readable explanation of the refusal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.BetaClaudeTagEnvironmentNotFoundErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagEnvironmentNotFoundError" /> class.
        /// </summary>
        /// <param name="message">
        /// A human-readable explanation of the refusal.
        /// </param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagEnvironmentNotFoundError(
            string? message,
            global::Anthropic.BetaClaudeTagEnvironmentNotFoundErrorDetails? details,
            string type = "not_found_error")
        {
            this.Type = type;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagEnvironmentNotFoundError" /> class.
        /// </summary>
        public BetaClaudeTagEnvironmentNotFoundError()
        {
        }

    }
}