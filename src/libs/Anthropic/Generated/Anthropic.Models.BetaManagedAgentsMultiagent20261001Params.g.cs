
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Multiagent configuration with three members, each enabled or disabled on its own. On an update, if the agent's stored `multiagent` also has type `multiagent_20261001`, this configuration is merged into the stored one, level by level, instead of replacing it. A key that the update omits keeps its stored value. A key sent as null takes its default, on create as well, so `"workflows": null` enables workflows. An object sent with a `type` other than the stored one replaces the stored object, and the keys that it omits take their defaults. A `predefined_agents` list that is sent replaces the stored list. Every object that is sent needs its `type`, and an enabled `advisor` needs its `model`. Other validation applies to the merged result.<br/>
    /// Example: {"type":"multiagent_20261001","workflows":{"type":"enabled"},"subagents":{"type":"enabled","predefined_agents":["agent_011CZkYqphY8vELVzwCUpqiQ"]},"advisor":{"type":"disabled"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagent20261001Params
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"multiagent_20261001"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "multiagent_20261001";

        /// <summary>
        /// Whether the agent can start workflow runs. Defaults to enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflows")]
        public global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? Workflows { get; set; }

        /// <summary>
        /// Whether the agent can spawn session threads. Defaults to enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subagents")]
        public global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? Subagents { get; set; }

        /// <summary>
        /// Whether the session's primary thread can consult an advisor model. Defaults to disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("advisor")]
        public global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? Advisor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagent20261001Params" /> class.
        /// </summary>
        /// <param name="workflows">
        /// Whether the agent can start workflow runs. Defaults to enabled.
        /// </param>
        /// <param name="subagents">
        /// Whether the agent can spawn session threads. Defaults to enabled.
        /// </param>
        /// <param name="advisor">
        /// Whether the session's primary thread can consult an advisor model. Defaults to disabled.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagent20261001Params(
            global::Anthropic.BetaManagedAgentsMultiagentWorkflowsParams? workflows,
            global::Anthropic.BetaManagedAgentsMultiagentSubagentsParams? subagents,
            global::Anthropic.BetaManagedAgentsMultiagentAdvisorParams? advisor,
            string type = "multiagent_20261001")
        {
            this.Type = type;
            this.Workflows = workflows;
            this.Subagents = subagents;
            this.Advisor = advisor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagent20261001Params" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagent20261001Params()
        {
        }

    }
}