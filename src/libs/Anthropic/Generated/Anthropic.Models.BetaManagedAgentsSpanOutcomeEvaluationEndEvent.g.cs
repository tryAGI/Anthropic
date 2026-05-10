
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Emitted when an outcome evaluation cycle completes. Carries the verdict and aggregate token usage. A verdict of `needs_revision` means another evaluation cycle follows; `satisfied`, `max_iterations_reached`, `failed`, or `interrupted` are terminal — no further evaluation cycles follow.<br/>
    /// Example: {"type":"span.outcome_evaluation_end","id":"sevt_011CZkZUVz5nHiv9qfWYomas","processed_at":"2026-03-15T10:02:31Z","outcome_evaluation_start_id":"sevt_011CZkZTUy4mGhu8peVXnlzr","iteration":0,"result":"satisfied","explanation":"All five sections present with inline citations.","usage":{"input_tokens":1842,"output_tokens":213,"cache_creation_input_tokens":0,"cache_read_input_tokens":1536},"outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP"}
    /// </summary>
    public sealed partial class BetaManagedAgentsSpanOutcomeEvaluationEndEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSpanOutcomeEvaluationEndEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when outcome evaluation ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// The id of the corresponding `span.outcome_evaluation_start` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome_evaluation_start_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutcomeEvaluationStartId { get; set; }

        /// <summary>
        /// 0-indexed revision cycle, matching the corresponding `span.outcome_evaluation_start`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iteration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Iteration { get; set; }

        /// <summary>
        /// Evaluation verdict. 'satisfied': criteria met, session goes idle. 'needs_revision': criteria not met, another revision cycle follows. 'max_iterations_reached': evaluation budget exhausted with criteria still unmet — one final acknowledgment turn follows before the session goes idle, but no further evaluation runs. 'failed': grader determined the rubric does not apply to the deliverables. 'interrupted': user sent an interrupt while evaluation was in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// Human-readable explanation of the verdict. For `needs_revision`, describes which criteria failed and why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Explanation { get; set; }

        /// <summary>
        /// Aggregate token usage for this evaluation cycle. Sums across all grader model requests within the cycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSpanModelUsage Usage { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanOutcomeEvaluationEndEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when outcome evaluation ended.
        /// </param>
        /// <param name="outcomeEvaluationStartId">
        /// The id of the corresponding `span.outcome_evaluation_start` event.
        /// </param>
        /// <param name="iteration">
        /// 0-indexed revision cycle, matching the corresponding `span.outcome_evaluation_start`.
        /// </param>
        /// <param name="result">
        /// Evaluation verdict. 'satisfied': criteria met, session goes idle. 'needs_revision': criteria not met, another revision cycle follows. 'max_iterations_reached': evaluation budget exhausted with criteria still unmet — one final acknowledgment turn follows before the session goes idle, but no further evaluation runs. 'failed': grader determined the rubric does not apply to the deliverables. 'interrupted': user sent an interrupt while evaluation was in progress.
        /// </param>
        /// <param name="explanation">
        /// Human-readable explanation of the verdict. For `needs_revision`, describes which criteria failed and why.
        /// </param>
        /// <param name="usage">
        /// Aggregate token usage for this evaluation cycle. Sums across all grader model requests within the cycle.
        /// </param>
        /// <param name="outcomeId">
        /// The `outc_` ID of the outcome being evaluated.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSpanOutcomeEvaluationEndEvent(
            string id,
            global::System.DateTime processedAt,
            string outcomeEvaluationStartId,
            int iteration,
            string result,
            string explanation,
            global::Anthropic.BetaManagedAgentsSpanModelUsage usage,
            string outcomeId,
            global::Anthropic.BetaManagedAgentsSpanOutcomeEvaluationEndEventType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.OutcomeEvaluationStartId = outcomeEvaluationStartId ?? throw new global::System.ArgumentNullException(nameof(outcomeEvaluationStartId));
            this.Iteration = iteration;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Explanation = explanation ?? throw new global::System.ArgumentNullException(nameof(explanation));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.OutcomeId = outcomeId ?? throw new global::System.ArgumentNullException(nameof(outcomeId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSpanOutcomeEvaluationEndEvent" /> class.
        /// </summary>
        public BetaManagedAgentsSpanOutcomeEvaluationEndEvent()
        {
        }

    }
}