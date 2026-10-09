
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workflow run is idle. Emitted each time the run goes idle, whatever the cause. If the run ends while idle, no `workflow_run.status_running` comes between this event and its `workflow_run.status_ended`.<br/>
    /// Example: {"type":"workflow_run.status_idle","id":"sevt_01JQ8Z9A4C6E8G1J2L4N6Q8S","processed_at":"2026-10-01T18:03:20.118Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd"}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunStatusIdleEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workflow_run.status_idle"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workflow_run.status_idle";

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunStatusIdleEvent" /> class.
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
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunStatusIdleEvent(
            string id,
            global::System.DateTime processedAt,
            string workflowRunId,
            string type = "workflow_run.status_idle")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunStatusIdleEvent" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunStatusIdleEvent()
        {
        }

    }
}