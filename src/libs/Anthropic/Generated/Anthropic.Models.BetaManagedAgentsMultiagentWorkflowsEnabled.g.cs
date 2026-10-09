
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent can start workflow runs.<br/>
    /// Example: {"type":"enabled","inline_agents":{"type":"disabled"},"predefined_agents":[{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentWorkflowsEnabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Whether a run's plan can define inline agents, which are not saved.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_agents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentInlineAgentsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMultiagentInlineAgents InlineAgents { get; set; }

        /// <summary>
        /// Predefined agents, which are saved agents that a run's plan can use, each resolved to a specific version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference> PredefinedAgents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentWorkflowsEnabled" /> class.
        /// </summary>
        /// <param name="inlineAgents">
        /// Whether a run's plan can define inline agents, which are not saved.
        /// </param>
        /// <param name="predefinedAgents">
        /// Predefined agents, which are saved agents that a run's plan can use, each resolved to a specific version.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentWorkflowsEnabled(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgents inlineAgents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference> predefinedAgents,
            string type = "enabled")
        {
            this.Type = type;
            this.InlineAgents = inlineAgents;
            this.PredefinedAgents = predefinedAgents ?? throw new global::System.ArgumentNullException(nameof(predefinedAgents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentWorkflowsEnabled" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentWorkflowsEnabled()
        {
        }

    }
}