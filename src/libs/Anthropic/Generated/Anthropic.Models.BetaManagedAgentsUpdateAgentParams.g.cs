
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for updating an `agent`. Omit a field to preserve its current value.<br/>
    /// Example: {"version":1,"system":"You are a general-purpose agent that can research, write code, run commands, and use connected tools to complete the user\u0027s task end to end."}
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateAgentParams
    {
        /// <summary>
        /// The agent's current version, used to prevent concurrent overwrites. Obtain this value from a create or retrieve response. The request fails if this does not match the server's current version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Human-readable name. 1-256 characters. Omit to preserve. Cannot be cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description. Up to 2048 characters. Omit to preserve; send empty string or null to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Model identifier. Accepts the [model string](https://platform.claude.com/docs/en/about-claude/models/overview#latest-models-comparison), e.g. `claude-opus-4-6`, or a `model_config` object for additional configuration control. Omit to preserve. Cannot be cleared.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelParamsJsonConverter))]
        public global::Anthropic.BetaManagedAgentsModelParams? Model { get; set; }

        /// <summary>
        /// System prompt. Up to 100,000 characters. Omit to preserve; send empty string or null to clear.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Tool configurations available to the agent. Full replacement. Omit to preserve; send empty array or null to clear. Maximum of 128 tools across all toolsets allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Tools { get; set; }

        /// <summary>
        /// MCP servers. Full replacement. Omit to preserve; send empty array or null to clear. Names must be unique. Maximum 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? McpServers { get; set; }

        /// <summary>
        /// Skills. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Skills { get; set; }

        /// <summary>
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string?>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateAgentParams" /> class.
        /// </summary>
        /// <param name="version">
        /// The agent's current version, used to prevent concurrent overwrites. Obtain this value from a create or retrieve response. The request fails if this does not match the server's current version.
        /// </param>
        /// <param name="name">
        /// Human-readable name. 1-256 characters. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="description">
        /// Description. Up to 2048 characters. Omit to preserve; send empty string or null to clear.
        /// </param>
        /// <param name="model">
        /// Model identifier. Accepts the [model string](https://platform.claude.com/docs/en/about-claude/models/overview#latest-models-comparison), e.g. `claude-opus-4-6`, or a `model_config` object for additional configuration control. Omit to preserve. Cannot be cleared.
        /// </param>
        /// <param name="system">
        /// System prompt. Up to 100,000 characters. Omit to preserve; send empty string or null to clear.
        /// </param>
        /// <param name="tools">
        /// Tool configurations available to the agent. Full replacement. Omit to preserve; send empty array or null to clear. Maximum of 128 tools across all toolsets allowed.
        /// </param>
        /// <param name="mcpServers">
        /// MCP servers. Full replacement. Omit to preserve; send empty array or null to clear. Names must be unique. Maximum 20.
        /// </param>
        /// <param name="skills">
        /// Skills. Full replacement. Omit to preserve; send empty array or null to clear. Maximum 20.
        /// </param>
        /// <param name="metadata">
        /// Metadata patch. Set a key to a string to upsert it, or to null to delete it. Omit the field to preserve. The stored bag is limited to 16 keys (up to 64 chars each) with values up to 512 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateAgentParams(
            int version,
            string? name,
            string? description,
            global::Anthropic.BetaManagedAgentsModelParams? model,
            string? system,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? skills,
            global::System.Collections.Generic.Dictionary<string, string?>? metadata)
        {
            this.Version = version;
            this.Name = name;
            this.Description = description;
            this.Model = model;
            this.System = system;
            this.Tools = tools;
            this.McpServers = mcpServers;
            this.Skills = skills;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateAgentParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateAgentParams()
        {
        }
    }
}