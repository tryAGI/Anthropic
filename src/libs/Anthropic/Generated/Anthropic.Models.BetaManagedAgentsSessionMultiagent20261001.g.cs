
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved multiagent configuration with three members, as copied to the `session` at creation.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionMultiagent20261001
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"multiagent_20261001"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "multiagent_20261001";

        /// <summary>
        /// Whether the agent can start workflow runs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionMultiagentWorkflowsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows Workflows { get; set; }

        /// <summary>
        /// Whether the agent can spawn session threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionMultiagentSubagentsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents Subagents { get; set; }

        /// <summary>
        /// Whether the session's primary thread can consult an advisor model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisor")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentAdvisorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMultiagentAdvisor Advisor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagent20261001" /> class.
        /// </summary>
        /// <param name="workflows">
        /// Whether the agent can start workflow runs.
        /// </param>
        /// <param name="subagents">
        /// Whether the agent can spawn session threads.
        /// </param>
        /// <param name="advisor">
        /// Whether the session's primary thread can consult an advisor model.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionMultiagent20261001(
            global::Anthropic.BetaManagedAgentsSessionMultiagentWorkflows workflows,
            global::Anthropic.BetaManagedAgentsSessionMultiagentSubagents subagents,
            global::Anthropic.BetaManagedAgentsMultiagentAdvisor advisor,
            string type = "multiagent_20261001")
        {
            this.Type = type;
            this.Workflows = workflows;
            this.Subagents = subagents;
            this.Advisor = advisor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagent20261001" /> class.
        /// </summary>
        public BetaManagedAgentsSessionMultiagent20261001()
        {
        }

    }
}