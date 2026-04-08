
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for built-in agent tools. Use this to enable or disable groups of tools available to the agent.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401Params
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolset20260401ParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401ParamsType Type { get; set; }

        /// <summary>
        /// Default configuration applied to all tools in this set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_config")]
        public global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? DefaultConfig { get; set; }

        /// <summary>
        /// Per-tool configuration overrides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigParams>? Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401Params" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="defaultConfig">
        /// Default configuration applied to all tools in this set.
        /// </param>
        /// <param name="configs">
        /// Per-tool configuration overrides.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401Params(
            global::Anthropic.BetaManagedAgentsAgentToolset20260401ParamsType type,
            global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfigParams? defaultConfig,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfigParams>? configs)
        {
            this.Type = type;
            this.DefaultConfig = defaultConfig;
            this.Configs = configs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401Params" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401Params()
        {
        }
    }
}