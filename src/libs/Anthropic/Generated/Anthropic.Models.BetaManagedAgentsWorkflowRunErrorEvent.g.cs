
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A workflow run met an error, or an error kept a run from being created. A run that ends with a `result.type` of `error` emits this event before its `workflow_run.status_ended`, with the same `error`.<br/>
    /// Example: {"type":"workflow_run.error","id":"sevt_01JQ8ZB7T3X5Z7C9E1G3J5L7","processed_at":"2026-10-01T18:05:02.301Z","workflow_run_id":"wrun_011CZm5tR2nHw6Jc9Ys4PdKf","error":{"type":"program_error","message":"The workflow run\u0027s plan failed."}}
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkflowRunErrorEvent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workflow_run.error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workflow_run.error";

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
        /// Identifier of the run that met the error, or `null` when the error kept a run from being created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_run_id")]
        public string? WorkflowRunId { get; set; }

        /// <summary>
        /// Why the run did not finish, or was not created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsWorkflowRunErrorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsWorkflowRunError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunErrorEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when this event was processed.
        /// </param>
        /// <param name="error">
        /// Why the run did not finish, or was not created.
        /// </param>
        /// <param name="workflowRunId">
        /// Identifier of the run that met the error, or `null` when the error kept a run from being created.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkflowRunErrorEvent(
            string id,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsWorkflowRunError error,
            string? workflowRunId,
            string type = "workflow_run.error")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProcessedAt = processedAt;
            this.WorkflowRunId = workflowRunId;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkflowRunErrorEvent" /> class.
        /// </summary>
        public BetaManagedAgentsWorkflowRunErrorEvent()
        {
        }

    }
}