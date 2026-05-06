
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Emitted when an outcome evaluation cycle begins.<br/>
    /// Example: {"type":"span.outcome_evaluation_start","id":"sevt_011CZkZTUy4mGhu8peVXnlzr","processed_at":"2026-03-15T10:02:14Z","iteration":0,"outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP"}
    /// </summary>
    public sealed partial class BetaManagedAgentsSpanOutcomeEvaluationStartEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanOutcomeEvaluationStartEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when outcome evaluation started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// 0-indexed revision cycle. 0 is the first evaluation; 1 is the re-evaluation after the first revision; etc.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanOutcomeEvaluationStartEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when outcome evaluation started.
        /// </param>
        /// <param name="iteration">
        /// 0-indexed revision cycle. 0 is the first evaluation; 1 is the re-evaluation after the first revision; etc.
        /// </param>
        /// <param name="outcomeId">
        /// The `outc_` ID of the outcome being evaluated.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSpanOutcomeEvaluationStartEvent(
            string id,
            global::System.DateTime processedAt,
            int iteration,
            string outcomeId,
            global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationStartEventType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.Iteration = iteration;
            this.OutcomeId = outcomeId ?? throw new global::System.ArgumentNullException(nameof(outcomeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanOutcomeEvaluationStartEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSpanOutcomeEvaluationStartEvent()
        {
        }
    }
}