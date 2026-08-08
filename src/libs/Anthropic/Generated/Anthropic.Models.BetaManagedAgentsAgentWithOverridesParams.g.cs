
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reference to an `agent` plus optional configuration overrides. Each provided field replaces the agent's value for the caller's use; the agent resource is unchanged.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentWithOverridesParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentWithOverridesParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentWithOverridesParamsType Type { get; set; }

        /// <summary>
        /// The `agent` ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The specific `agent` version to use. Omit to use the latest version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// Replacement model. Accepts the model string, e.g. `claude-opus-4-6`, or a `model_config` object. Omit to use the agent's model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelParamsJsonConverter))]
        public global::Anthropic.BetaManagedAgentsModelParams? Model { get; set; }

        /// <summary>
        /// Replacement system prompt. Up to 100,000 characters. Set to null to clear the agent's system prompt; omit to preserve it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Replacement tool list. Full replacement: the provided array becomes the tool configuration. Send an empty array to clear; omit to preserve the agent's tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Tools { get; set; }

        /// <summary>
        /// Replacement MCP server list. Full replacement: the provided array becomes the MCP servers. Send an empty array to clear; omit to preserve the agent's servers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? McpServers { get; set; }

        /// <summary>
        /// Replacement skill list. Full replacement: the provided array becomes the skills. Send an empty array to clear; omit to preserve the agent's skills.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentWithOverridesParams" /> class.
        /// </summary>
        /// <param name="id">
        /// The `agent` ID.
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// The specific `agent` version to use. Omit to use the latest version.
        /// </param>
        /// <param name="model">
        /// Replacement model. Accepts the model string, e.g. `claude-opus-4-6`, or a `model_config` object. Omit to use the agent's model.
        /// </param>
        /// <param name="system">
        /// Replacement system prompt. Up to 100,000 characters. Set to null to clear the agent's system prompt; omit to preserve it.
        /// </param>
        /// <param name="tools">
        /// Replacement tool list. Full replacement: the provided array becomes the tool configuration. Send an empty array to clear; omit to preserve the agent's tools.
        /// </param>
        /// <param name="mcpServers">
        /// Replacement MCP server list. Full replacement: the provided array becomes the MCP servers. Send an empty array to clear; omit to preserve the agent's servers.
        /// </param>
        /// <param name="skills">
        /// Replacement skill list. Full replacement: the provided array becomes the skills. Send an empty array to clear; omit to preserve the agent's skills.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentWithOverridesParams(
            string id,
            global::Anthropic.BetaManagedAgentsAgentWithOverridesParamsType type,
            int? version,
            global::Anthropic.BetaManagedAgentsModelParams? model,
            string? system,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? skills)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.Model = model;
            this.System = system;
            this.Tools = tools;
            this.McpServers = mcpServers;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentWithOverridesParams" /> class.
        /// </summary>
        public BetaManagedAgentsAgentWithOverridesParams()
        {
        }

    }
}