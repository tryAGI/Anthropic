
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Periodic heartbeat emitted while an outcome evaluation cycle is in progress. Distinguishes 'evaluation is actively running' from 'evaluation is stuck' between the corresponding `span.outcome_evaluation_start` and `span.outcome_evaluation_end` events.<br/>
    /// Example: {"type":"span.outcome_evaluation_ongoing","id":"sevt_011CZkZbCG2uOpc6xmDfvTzh","processed_at":"2026-03-15T10:02:14Z","iteration":0,"outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP"}
    /// </summary>
    public sealed partial class BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanOutcomeEvaluationOngoingEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when this heartbeat was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// 0-indexed revision cycle, matching the corresponding `span.outcome_evaluation_start`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iteration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Iteration { get; set; }

        /// <summary>
        /// The `outc_` ID of the outcome being evaluated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutcomeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when this heartbeat was emitted.
        /// </param>
        /// <param name="iteration">
        /// 0-indexed revision cycle, matching the corresponding `span.outcome_evaluation_start`.
        /// </param>
        /// <param name="outcomeId">
        /// The `outc_` ID of the outcome being evaluated.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent(
            string id,
            global::System.DateTime processedAt,
            int iteration,
            string outcomeId,
            global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationOngoingEventType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.Iteration = iteration;
            this.OutcomeId = outcomeId ?? throw new global::System.ArgumentNullException(nameof(outcomeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSpanOutcomeEvaluationOngoingEvent()
        {
        }

    }
}