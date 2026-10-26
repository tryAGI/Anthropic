
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Indicates the agent has paused and is awaiting user input.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionStatusIdleEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"session.status_idle"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session.status_idle";

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp of status change.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Structured information about why the session stopped. `null` when there is nothing more to report.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_details")]
        public global::Anthropic.BetaManagedAgentsSessionStopDetails? StopDetails { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionStatusIdleEventStopReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason StopReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionStatusIdleEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp of status change.
        /// </param>
        /// <param name="stopReason"></param>
        /// <param name="stopDetails">
        /// Structured information about why the session stopped. `null` when there is nothing more to report.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionStatusIdleEvent(
            string id,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsSessionStatusIdleEventStopReason stopReason,
            global::Anthropic.BetaManagedAgentsSessionStopDetails? stopDetails,
            string type = "session.status_idle")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.StopDetails = stopDetails;
            this.StopReason = stopReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionStatusIdleEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionStatusIdleEvent()
        {
        }

    }
}