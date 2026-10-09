
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent can spawn session threads.<br/>
    /// Example: {"type":"enabled","inline_agents":{"type":"disabled"},"predefined_agents":[{"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1}]}
    /// </summary>
    public sealed partial class BetaManagedAgentsMultiagentSubagentsEnabled
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "enabled";

        /// <summary>
        /// Whether the agent can define inline agents, which are not saved, when it spawns session threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inline_agents")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMultiagentInlineAgentsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMultiagentInlineAgents InlineAgents { get; set; }

        /// <summary>
        /// Predefined agents, which are saved agents that this agent can spawn as session threads, each resolved to a specific version.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentSubagentsEnabled" /> class.
        /// </summary>
        /// <param name="inlineAgents">
        /// Whether the agent can define inline agents, which are not saved, when it spawns session threads.
        /// </param>
        /// <param name="predefinedAgents">
        /// Predefined agents, which are saved agents that this agent can spawn as session threads, each resolved to a specific version.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMultiagentSubagentsEnabled(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgents inlineAgents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentReference> predefinedAgents,
            string type = "enabled")
        {
            this.Type = type;
            this.InlineAgents = inlineAgents;
            this.PredefinedAgents = predefinedAgents ?? throw new global::System.ArgumentNullException(nameof(predefinedAgents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMultiagentSubagentsEnabled" /> class.
        /// </summary>
        public BetaManagedAgentsMultiagentSubagentsEnabled()
        {
        }

    }
}