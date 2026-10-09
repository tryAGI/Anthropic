
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The agent can start workflow runs.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionMultiagentWorkflowsEnabled
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
        /// Full `agent` definitions of the predefined agents, which are saved agents that a run's plan can use.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagentWorkflowsEnabled" /> class.
        /// </summary>
        /// <param name="inlineAgents">
        /// Whether a run's plan can define inline agents, which are not saved.
        /// </param>
        /// <param name="predefinedAgents">
        /// Full `agent` definitions of the predefined agents, which are saved agents that a run's plan can use.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionMultiagentWorkflowsEnabled(
            global::Anthropic.BetaManagedAgentsMultiagentInlineAgents inlineAgents,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionThreadAgent> predefinedAgents,
            string type = "enabled")
        {
            this.Type = type;
            this.InlineAgents = inlineAgents;
            this.PredefinedAgents = predefinedAgents ?? throw new global::System.ArgumentNullException(nameof(predefinedAgents));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionMultiagentWorkflowsEnabled" /> class.
        /// </summary>
        public BetaManagedAgentsSessionMultiagentWorkflowsEnabled()
        {
        }

    }
}