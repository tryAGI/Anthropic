
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workflow run ended. Emitted once per run, as the last of the run's `workflow_run.*` events.<br/>
    /// Example: {"type":"workflow_run.status_ended","id":"sevt_01JQ8ZC1V5B7N9M1K3J5H7GA","processed_at":"2026-10-01T18:05:02.337Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","result":{"type":"completed"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunStatusEndedEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workflow_run.status_ended"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workflow_run.status_ended";

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
        /// How the run ended.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsWorkflowRunResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsWorkflowRunResult Result { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunStatusEndedEvent" /> class.
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
        /// <param name="result">
        /// How the run ended.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunStatusEndedEvent(
            string id,
            global::System.DateTime processedAt,
            string workflowRunId,
            global::Anthropic.BetaManagedAgentsWorkflowRunResult result,
            string type = "workflow_run.status_ended")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
            this.Result = result;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunStatusEndedEvent" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunStatusEndedEvent()
        {
        }

    }
}