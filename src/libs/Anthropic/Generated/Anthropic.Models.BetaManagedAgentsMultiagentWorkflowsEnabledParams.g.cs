
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent can start workflow runs. Each run follows a plan, a program that the agent writes. A plan can use predefined agents, which are the saved agents in `predefined_agents`, and inline agents, which it defines itself and which are not saved. If `inline_agents` is disabled, `predefined_agents` must name at least one agent.<br/>
    /// Example: {"type":"enabled","inline_agents":{"type":"disabled"},"predefined_agents":[{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentWorkflowsEnabledParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Whether a run's plan can define inline agents. Defaults to enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_agents")]
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? InlineAgents { get; set; }

        /// <summary>
        /// Predefined agents that a run's plan can use. At most 20. Defaults to null. Null and an empty list both mean no predefined agents. This list is separate from `subagents.predefined_agents`, and an agent in one list is not added to the other.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined_agents")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? PredefinedAgents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentWorkflowsEnabledParams" /> class.
        /// </summary>
        /// <param name="inlineAgents">
        /// Whether a run's plan can define inline agents. Defaults to enabled.
        /// </param>
        /// <param name="predefinedAgents">
        /// Predefined agents that a run's plan can use. At most 20. Defaults to null. Null and an empty list both mean no predefined agents. This list is separate from `subagents.predefined_agents`, and an agent in one list is not added to the other.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentWorkflowsEnabledParams(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? inlineAgents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? predefinedAgents,
            string type = "enabled")
        {
            this.Type = type;
            this.InlineAgents = inlineAgents;
            this.PredefinedAgents = predefinedAgents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentWorkflowsEnabledParams" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentWorkflowsEnabledParams()
        {
        }

    }
}