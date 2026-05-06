
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Echo of a `user.define_outcome` input event. Carries the server-generated `outcome_id` that subsequent `span.outcome_evaluation_*` events reference.<br/>
    /// Example: {"type":"user.define_outcome","id":"sevt_011CZkZSTx3lFgt7odUWmkyq","processed_at":"2026-03-15T10:02:14Z","outcome_id":"outc_011CZkZRSw2kEfs6ncTVljxP","description":"Produce a 2-page summary as summary.md","max_iterations":3,"rubric":{"type":"text","content":"Must cover all five sections; cite sources inline."}}
    /// </summary>
    public sealed partial class BetaManagedAgentsUserDefineOutcomeEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsUserDefineOutcomeEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when the outcome was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Server-generated `outc_` ID for this outcome. Referenced by `span.outcome_evaluation_*` events and the session's `outcome_evaluations` list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OutcomeId { get; set; }

        /// <summary>
        /// What the agent should produce. Copied from the input event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Evaluate-then-revise cycles before giving up. Default 3, max 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_iterations")]
        public int? MaxIterations { get; set; }

        /// <summary>
        /// How to grade the outcome. File rubrics are currently resolved to their text content; clients should handle both variants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rubric")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRubricJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRubric Rubric { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserDefineOutcomeEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when the outcome was accepted.
        /// </param>
        /// <param name="outcomeId">
        /// Server-generated `outc_` ID for this outcome. Referenced by `span.outcome_evaluation_*` events and the session's `outcome_evaluations` list.
        /// </param>
        /// <param name="description">
        /// What the agent should produce. Copied from the input event.
        /// </param>
        /// <param name="rubric">
        /// How to grade the outcome. File rubrics are currently resolved to their text content; clients should handle both variants.
        /// </param>
        /// <param name="type"></param>
        /// <param name="maxIterations">
        /// Evaluate-then-revise cycles before giving up. Default 3, max 20.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserDefineOutcomeEvent(
            string id,
            global::System.DateTime processedAt,
            string outcomeId,
            string description,
            global::Anthropic.BetaManagedAgentsRubric rubric,
            global::Anthropic.BetaManagedAgentsUserDefineOutcomeEventType type,
            int? maxIterations)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.OutcomeId = outcomeId ?? throw new global::System.ArgumentNullException(nameof(outcomeId));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.MaxIterations = maxIterations;
            this.Rubric = rubric;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserDefineOutcomeEvent" /> class.
        /// </summary>
        public BetaManagedAgentsUserDefineOutcomeEvent()
        {
        }
    }
}