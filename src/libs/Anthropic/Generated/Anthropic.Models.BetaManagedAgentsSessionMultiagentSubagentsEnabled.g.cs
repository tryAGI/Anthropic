
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent can spawn session threads.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionMultiagentSubagentsEnabled
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
        /// Full `agent` definitions of the predefined agents, which are saved agents that this agent can spawn as session threads.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined_agents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent> PredefinedAgents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagentSubagentsEnabled" /> class.
        /// </summary>
        /// <param name="inlineAgents">
        /// Whether the agent can define inline agents, which are not saved, when it spawns session threads.
        /// </param>
        /// <param name="predefinedAgents">
        /// Full `agent` definitions of the predefined agents, which are saved agents that this agent can spawn as session threads.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionMultiagentSubagentsEnabled(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgents inlineAgents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent> predefinedAgents,
            string type = "enabled")
        {
            this.Type = type;
            this.InlineAgents = inlineAgents;
            this.PredefinedAgents = predefinedAgents ?? throw new global::System.ArgumentNullException(nameof(predefinedAgents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagentSubagentsEnabled" /> class.
        /// </summary>
        public BetaManagedAgentsSessionMultiagentSubagentsEnabled()
        {
        }

    }
}