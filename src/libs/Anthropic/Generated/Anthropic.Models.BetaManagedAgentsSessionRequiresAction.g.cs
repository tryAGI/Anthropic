
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent is idle waiting on one or more blocking user-input events (tool confirmation, custom tool result, etc.). Resolving all of them transitions the session back to running.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionRequiresAction
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionRequiresActionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionRequiresActionType Type { get; set; }

        /// <summary>
        /// The ids of events the agent is blocked on. Resolving fewer than all re-emits `session.status_idle` with the remainder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EventIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRequiresAction" /> class.
        /// </summary>
        /// <param name="eventIds">
        /// The ids of events the agent is blocked on. Resolving fewer than all re-emits `session.status_idle` with the remainder.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionRequiresAction(
            global::System.Collections.Generic.IList<string> eventIds,
            global::Anthropic.BetaManagedAgentsSessionRequiresActionType type)
        {
            this.Type = type;
            this.EventIds = eventIds ?? throw new global::System.ArgumentNullException(nameof(eventIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionRequiresAction" /> class.
        /// </summary>
        public BetaManagedAgentsSessionRequiresAction()
        {
        }
    }
}