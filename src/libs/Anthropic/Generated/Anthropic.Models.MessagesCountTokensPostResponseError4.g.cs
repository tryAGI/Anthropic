
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesCountTokensPostResponseError4
    {
        /// <summary>
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.CompactionUnavailableErrorDetails? Details { get; set; }

        /// <summary>
        /// Default Value: Overloaded
        /// </summary>
        /// <default>"Overloaded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Overloaded";

        /// <summary>
        /// Default Value: overloaded_error
        /// </summary>
        /// <default>"overloaded_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "overloaded_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesCountTokensPostResponseError4" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Overloaded
        /// </param>
        /// <param name="details">
        /// Machine-readable detail about the cause of the error. `error_code` names the cause; branch on it rather than on `message`. Absent when the error has no code. Treat an unrecognized `error_code` as the bare `type`.
        /// </param>
        /// <param name="type">
        /// Default Value: overloaded_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesCountTokensPostResponseError4(
            string message,
            global::Anthropic.CompactionUnavailableErrorDetails? details,
            string type = "overloaded_error")
        {
            this.Details = details;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesCountTokensPostResponseError4" /> class.
        /// </summary>
        public MessagesCountTokensPostResponseError4()
        {
        }

    }
}