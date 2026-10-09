
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved multiagent configuration with three members, each enabled or disabled on its own.<br/>
    /// Example: {"type":"multiagent_20261001","workflows":{"type":"enabled","inline_agents":{"type":"enabled"},"predefined_agents":[]},"subagents":{"type":"enabled","inline_agents":{"type":"enabled"},"predefined_agents":[{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1}]},"advisor":{"type":"disabled"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagent20261001
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentWorkflowsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMultiagentWorkflows Workflows { get; set; }

        /// <summary>
        /// Whether the agent can spawn session threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentSubagentsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMultiagentSubagents Subagents { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagent20261001" /> class.
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
        public BetaManagedAgentsMultiagent20261001(
            global::Anthropic.BetaManagedAgentsMultiagentWorkflows workflows,
            global::Anthropic.BetaManagedAgentsMultiagentSubagents subagents,
            global::Anthropic.BetaManagedAgentsMultiagentAdvisor advisor,
            string type = "multiagent_20261001")
        {
            this.Type = type;
            this.Workflows = workflows;
            this.Subagents = subagents;
            this.Advisor = advisor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagent20261001" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagent20261001()
        {
        }

    }
}