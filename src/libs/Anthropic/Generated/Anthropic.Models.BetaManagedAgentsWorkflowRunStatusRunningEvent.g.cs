
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workflow run is running. Emitted when the run starts to execute, and each time it resumes after being idle. A run that starts idle emits `workflow_run.status_idle` first.<br/>
    /// Example: {"type":"workflow_run.status_running","id":"sevt_01JQ8Z6Y1M3P5R7T9V1X3Z5B","processed_at":"2026-10-01T18:02:11.430Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd"}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunStatusRunningEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workflow_run.status_running"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workflow_run.status_running";

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunStatusRunningEvent" /> class.
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
        public BetaManagedAgentsWorkflowRunStatusRunningEvent(
            string id,
            global::System.DateTime processedAt,
            string workflowRunId,
            string type = "workflow_run.status_running")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunStatusRunningEvent" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunStatusRunningEvent()
        {
        }

    }
}