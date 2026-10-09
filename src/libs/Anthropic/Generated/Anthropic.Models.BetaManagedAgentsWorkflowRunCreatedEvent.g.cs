
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workflow run was created. A workflow run is background work that the session's agent starts. Emitted once per run, before the run's other `workflow_run.*` events.<br/>
    /// Example: {"type":"workflow_run.created","id":"sevt_01JQ8Z6X8K2N4V7T9B3C5D1E","processed_at":"2026-10-01T18:02:11.412Z","workflow_run_id":"wrun_011CZm3vQ8pKx2Lr7Nq9TbYd","name":"Compare the vendors","description":"Reads each vendor\u0027s pricing page and tabulates the plans.","phases":[{"id":"wrph_011CZm4Kq7RtY2Wn8Vx3LbHd","name":"Collect the sources","description":null}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunCreatedEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workflow_run.created"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workflow_run.created";

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
        /// Name that the agent gave the run, passed on as written, or a name that the server assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description that the agent gave the run, passed on as written, or `null` if it gave none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The phases that the run's plan declares, in the plan's order. Can be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase> Phases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunCreatedEvent" /> class.
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
        /// <param name="name">
        /// Name that the agent gave the run, passed on as written, or a name that the server assigned.
        /// </param>
        /// <param name="phases">
        /// The phases that the run's plan declares, in the plan's order. Can be empty.
        /// </param>
        /// <param name="description">
        /// Description that the agent gave the run, passed on as written, or `null` if it gave none.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunCreatedEvent(
            string id,
            global::System.DateTime processedAt,
            string workflowRunId,
            string name,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsWorkflowRunPhase> phases,
            string? description,
            string type = "workflow_run.created")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.WorkflowRunId = workflowRunId ?? throw new global::System.ArgumentNullException(nameof(workflowRunId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Phases = phases ?? throw new global::System.ArgumentNullException(nameof(phases));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunCreatedEvent" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunCreatedEvent()
        {
        }

    }
}