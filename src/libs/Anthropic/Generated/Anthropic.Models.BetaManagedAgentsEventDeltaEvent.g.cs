
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An incremental update to an event that is still being streamed. Deltas are best-effort and may stop early; when the buffered event with id == event_id is produced it carries the complete content. A model request that ends early (an error or interrupt) produces no buffered event — its terminal span.model_request_end closes the preview. Only sent on stream connections that opt in via event_deltas; never appears in event history.
    /// </summary>
    public sealed partial class BetaManagedAgentsEventDeltaEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventDeltaEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsEventDeltaEventType Type { get; set; }

        /// <summary>
        /// The id of the event being previewed. Matches event.id on the corresponding event_start and the buffered event that reconciles the preview.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// One fragment of the previewed event. The delta type is named for the previewed event's field it streams into: agent.message events stream content_delta fragments, each a partial element of the content array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsEventDeltaEventDeltaJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsEventDeltaEventDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventDeltaEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The id of the event being previewed. Matches event.id on the corresponding event_start and the buffered event that reconciles the preview.
        /// </param>
        /// <param name="delta">
        /// One fragment of the previewed event. The delta type is named for the previewed event's field it streams into: agent.message events stream content_delta fragments, each a partial element of the content array.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsEventDeltaEvent(
            string eventId,
            global::Anthropic.BetaManagedAgentsEventDeltaEventDelta delta,
            global::Anthropic.BetaManagedAgentsEventDeltaEventType type)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsEventDeltaEvent" /> class.
        /// </summary>
        public BetaManagedAgentsEventDeltaEvent()
        {
        }

    }
}