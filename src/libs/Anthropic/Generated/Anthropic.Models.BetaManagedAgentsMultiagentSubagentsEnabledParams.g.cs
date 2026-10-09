
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent can spawn session threads. Each thread runs a predefined agent, which is a saved agent in `predefined_agents`, or an inline agent, which the agent defines when it spawns the thread and which is not saved. If `inline_agents` is disabled, `predefined_agents` must name at least one agent.<br/>
    /// Example: {"type":"enabled","inline_agents":{"type":"disabled"},"predefined_agents":["agent_011CZkYqphY8vELVzwCUpqiQ",{"type":"self"}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentSubagentsEnabledParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Whether the agent can define inline agents when it spawns session threads. Defaults to enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_agents")]
        public global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? InlineAgents { get; set; }

        /// <summary>
        /// Predefined agents that this agent can spawn as session threads. At most 20. Defaults to null. Null and an empty list both mean no predefined agents. This list is separate from `workflows.predefined_agents`, and an agent in one list is not added to the other.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined_agents")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? PredefinedAgents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentSubagentsEnabledParams" /> class.
        /// </summary>
        /// <param name="inlineAgents">
        /// Whether the agent can define inline agents when it spawns session threads. Defaults to enabled.
        /// </param>
        /// <param name="predefinedAgents">
        /// Predefined agents that this agent can spawn as session threads. At most 20. Defaults to null. Null and an empty list both mean no predefined agents. This list is separate from `workflows.predefined_agents`, and an agent in one list is not added to the other.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentSubagentsEnabledParams(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgentsParams? inlineAgents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMultiagentPredefinedAgentParams>? predefinedAgents,
            string type = "enabled")
        {
            this.Type = type;
            this.InlineAgents = inlineAgents;
            this.PredefinedAgents = predefinedAgents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentSubagentsEnabledParams" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentSubagentsEnabledParams()
        {
        }

    }
}