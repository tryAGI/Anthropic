
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An error event in a streaming conversation.
    /// </summary>
    public sealed partial class ErrorEvent
    {
        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.MessageStreamEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.MessageStreamEventType Type { get; set; }

        /// <summary>
        /// An error object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Error Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        /// <param name="error">
        /// An error object.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ErrorEvent(
            global::Anthropic.MessageStreamEventType type,
            global::Anthropic.Error error)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorEvent" /> class.
        /// </summary>
        public ErrorEvent()
        {
        }
    }
}