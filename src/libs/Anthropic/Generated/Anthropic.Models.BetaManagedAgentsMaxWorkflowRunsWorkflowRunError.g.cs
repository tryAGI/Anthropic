
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No run was created, because the session was at its limit of open workflow runs, which are runs that have not ended. Only `workflow_run.error` carries this type.<br/>
    /// Example: {"type":"max_workflow_runs_error","message":"The session is at its limit of open workflow runs."}
    /// </summary>
    public sealed partial class BetaManagedAgentsMaxWorkflowRunsWorkflowRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"max_workflow_runs_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "max_workflow_runs_error";

        /// <summary>
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMaxWorkflowRunsWorkflowRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Short explanation written by the server. It never contains content from the run or its agents.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMaxWorkflowRunsWorkflowRunError(
            string message,
            string type = "max_workflow_runs_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMaxWorkflowRunsWorkflowRunError" /> class.
        /// </summary>
        public BetaManagedAgentsMaxWorkflowRunsWorkflowRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMaxWorkflowRunsWorkflowRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMaxWorkflowRunsWorkflowRunError FromMessage(string message)
        {
            return new BetaManagedAgentsMaxWorkflowRunsWorkflowRunError
            {
                Message = message,
            };
        }

    }
}