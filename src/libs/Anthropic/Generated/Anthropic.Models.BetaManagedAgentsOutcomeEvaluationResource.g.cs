
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Evaluation state for a single outcome defined via a define_outcome event.<br/>
    /// Example: {"type":"outcome_evaluation","outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP","description":"Produce a 2-page summary as summary.md","result":"satisfied","iteration":0,"completed_at":"2026-03-15T10:02:31Z","explanation":"All five sections present with inline citations."}
    /// </summary>
    public sealed partial class BetaManagedAgentsOutcomeEvaluationResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsOutcomeEvaluationResourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsOutcomeEvaluationResourceType Type { get; set; }

        /// <summary>
        /// Server-generated outc_ ID for this outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutcomeId { get; set; }

        /// <summary>
        /// What the agent should produce.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Current evaluation state. 'pending' before the agent begins work; 'running' while producing or revising; 'evaluating' while the grader scores; 'satisfied'/'max_iterations_reached'/'failed'/'interrupted' are terminal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// 0-indexed revision cycle the outcome is currently on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("iteration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Iteration { get; set; }

        /// <summary>
        /// When the outcome reached a terminal result. Null while pending/running/evaluating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Grader's verdict text from the most recent evaluation. For satisfied, explains why criteria are met; for needs_revision (intermediate), what's missing; for failed, why unrecoverable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explanation")]
        public string? Explanation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsOutcomeEvaluationResource" /> class.
        /// </summary>
        /// <param name="outcomeId">
        /// Server-generated outc_ ID for this outcome.
        /// </param>
        /// <param name="description">
        /// What the agent should produce.
        /// </param>
        /// <param name="result">
        /// Current evaluation state. 'pending' before the agent begins work; 'running' while producing or revising; 'evaluating' while the grader scores; 'satisfied'/'max_iterations_reached'/'failed'/'interrupted' are terminal.
        /// </param>
        /// <param name="iteration">
        /// 0-indexed revision cycle the outcome is currently on.
        /// </param>
        /// <param name="type"></param>
        /// <param name="completedAt">
        /// When the outcome reached a terminal result. Null while pending/running/evaluating.
        /// </param>
        /// <param name="explanation">
        /// Grader's verdict text from the most recent evaluation. For satisfied, explains why criteria are met; for needs_revision (intermediate), what's missing; for failed, why unrecoverable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsOutcomeEvaluationResource(
            string outcomeId,
            string description,
            string result,
            int iteration,
            global::Anthropic.BetaManagedAgentsOutcomeEvaluationResourceType type,
            global::System.DateTime? completedAt,
            string? explanation)
        {
            this.Type = type;
            this.OutcomeId = outcomeId ?? throw new global::System.ArgumentNullException(nameof(outcomeId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Iteration = iteration;
            this.CompletedAt = completedAt;
            this.Explanation = explanation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsOutcomeEvaluationResource" /> class.
        /// </summary>
        public BetaManagedAgentsOutcomeEvaluationResource()
        {
        }

    }
}