
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A start event in a streaming conversation.
    /// </summary>
    public sealed partial class MessageStartEvent
    {
        /// <summary>
        /// A message in a chat conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Message Message { get; set; }

        /// <summary>
        /// The type of a streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.MessageStreamEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.MessageStreamEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        /// <param name="message">
        /// A message in a chat conversation.
        /// </param>
        /// <param name="type">
        /// The type of a streaming event.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageStartEvent(
            global::Anthropic.Message message,
            global::Anthropic.MessageStreamEventType type)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStartEvent" /> class.
        /// </summary>
        public MessageStartEvent()
        {
        }
    }
}