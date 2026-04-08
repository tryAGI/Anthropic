
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentToolset20260401TypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentToolset20260401Type Type { get; set; }

        /// <summary>
        /// Resolved default configuration for agent tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig DefaultConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("configs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfig> Configs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401" /> class.
        /// </summary>
        /// <param name="defaultConfig">
        /// Resolved default configuration for agent tools.
        /// </param>
        /// <param name="configs"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401(
            global::Anthropic.BetaManagedAgentsAgentToolsetDefaultConfig defaultConfig,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolConfig> configs,
            global::Anthropic.BetaManagedAgentsAgentToolset20260401Type type)
        {
            this.Type = type;
            this.DefaultConfig = defaultConfig ?? throw new global::System.ArgumentNullException(nameof(defaultConfig));
            this.Configs = configs ?? throw new global::System.ArgumentNullException(nameof(configs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401()
        {
        }
    }
}