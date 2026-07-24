
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Opens a preview of a buffered event. Carries the previewed event's type and id only. Followed by zero or more event_delta events with the same event id, normally concluded by the buffered event carrying that id. If the producing model request ends without that event (an error or interrupt mid-stream), its terminal span.model_request_end closes the preview. Only sent on stream connections that opt in via event_deltas; never appears in event history.
    /// </summary>
    public sealed partial class BetaManagedAgentsEventStartEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventStartEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEventStartEventType Type { get; set; }

        /// <summary>
        /// The previewed event's type and id. The event type determines which delta types the preview's event_delta events carry: agent.message events stream content_delta fragments; agent.thinking previews are start-only — no deltas follow, and the buffered agent.thinking with the same id concludes them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventStartEventEventJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsEventStartEventEvent Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventStartEvent" /> class.
        /// </summary>
        /// <param name="event">
        /// The previewed event's type and id. The event type determines which delta types the preview's event_delta events carry: agent.message events stream content_delta fragments; agent.thinking previews are start-only — no deltas follow, and the buffered agent.thinking with the same id concludes them.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEventStartEvent(
            global::Anthropic.BetaManagedAgentsEventStartEventEvent @event,
            global::Anthropic.BetaManagedAgentsEventStartEventType type)
        {
            this.Type = type;
            this.Event = @event;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventStartEvent" /> class.
        /// </summary>
        public BetaManagedAgentsEventStartEvent()
        {
        }

    }
}