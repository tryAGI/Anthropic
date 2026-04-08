
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for sending events to a `session`.<br/>
    /// Example: {"events":[{"type":"user.message","content":[{"type":"text","text":"Where is my order #1234?"}]}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsSendSessionEventsParams
    {
        /// <summary>
        /// Events to send to the `session`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("events")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams> Events { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSendSessionEventsParams" /> class.
        /// </summary>
        /// <param name="events">
        /// Events to send to the `session`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSendSessionEventsParams(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsEventParams> events)
        {
            this.Events = events ?? throw new global::System.ArgumentNullException(nameof(events));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSendSessionEventsParams" /> class.
        /// </summary>
        public BetaManagedAgentsSendSessionEventsParams()
        {
        }
    }
}