
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageStopEvent
    {
        /// <summary>
        /// Default Value: message_stop
        /// </summary>
        /// <default>global::Anthropic.MessageStopEventType.MessageStop</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.MessageStopEventTypeJsonConverter))]
        public global::Anthropic.MessageStopEventType Type { get; set; } = global::Anthropic.MessageStopEventType.MessageStop;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStopEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: message_stop
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageStopEvent(
            global::Anthropic.MessageStopEventType type = global::Anthropic.MessageStopEventType.MessageStop)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageStopEvent" /> class.
        /// </summary>
        public MessageStopEvent()
        {
        }
    }
}