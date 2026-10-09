
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workflow run's plan left a phase, or the run's end closed it. Emitted once for every `workflow_run.phase_started` event, before the run's `workflow_run.status_ended` event. The event does not say whether the plan finished the phase's work, or why it left.<br/>
    /// Example: {"type":"workflow_run.phase_ended","id":"sevt_01JQ8ZB9W2Y4A6C8E1G2J4L6","processed_at":"2026-10-01T18:04:47.905Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","workflow_run_phase_id":"wrph_011CZm4Kq7RtY2Wn8Vx3LbHd","phase_started_id":"sevt_01JQ8Z7M3P5R7T9V1X3Z5B7D"}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunPhaseEndedEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workflow_run.phase_ended"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workflow_run.phase_ended";

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Timestamp when this event was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Identifier of the run. The same value is on all of the run's `workflow_run.*` events.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowRunId { get; set; }

        /// <summary>
        /// Identifier of the phase, as in `phases` on the run's `workflow_run.created` event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_phase_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkflowRunPhaseId { get; set; }

        /// <summary>
        /// Identifier of the `workflow_run.phase_started` event that opened the phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase_started_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PhaseStartedId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunPhaseEndedEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when this event was processed.
        /// </param>
        /// <param name="workflowRunId">
        /// Identifier of the run. The same value is on all of the run's `workflow_run.*` events.
        /// </param>
        /// <param name="workflowRunPhaseId">
        /// Identifier of the phase, as in `phases` on the run's `workflow_run.created` event.
        /// </param>
        /// <param name="phaseStartedId">
        /// Identifier of the `workflow_run.phase_started` event that opened the phase.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunPhaseEndedEvent(
            string id,
            global::System.DateTime processedAt,
            string workflowRunId,
            string workflowRunPhaseId,
            string phaseStartedId,
            string type = "workflow_run.phase_ended")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
            this.WorkflowRunPhaseId = workflowRunPhaseId ?? throw new global::System.ArgumentNullException(nameof(workflowRunPhaseId));
            this.PhaseStartedId = phaseStartedId ?? throw new global::System.ArgumentNullException(nameof(phaseStartedId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunPhaseEndedEvent" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunPhaseEndedEvent()
        {
        }

    }
}