
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for creating an `agent`.<br/>
    /// Example: {"name":"My First Agent","model":"claude-sonnet-4-6","description":"A general-purpose starter agent.","system":"You are a general-purpose agent that can research, write code, run commands, and use connected tools to complete the user\u0027s task end to end.","tools":[{"type":"agent_toolset_20260401"}],"metadata":{"foo":"bar"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateAgentParams
    {
        /// <summary>
        /// Human-readable name for the agent. 1-256 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Model identifier. Accepts the [model string](https://platform.claude.com/docs/en/about-claude/models/overview#latest-models-comparison), e.g. `claude-opus-4-6`, or a `model_config` object for additional configuration control
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsModelParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsModelParams Model { get; set; }

        /// <summary>
        /// Description of what the agent does. Up to 2048 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// System prompt for the agent. Up to 100,000 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Tool configurations available to the agent. Maximum of 128 tools across all toolsets allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? Tools { get; set; }

        /// <summary>
        /// MCP servers this agent connects to. Maximum 20. Names must be unique within the array.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? McpServers { get; set; }

        /// <summary>
        /// Skills available to the agent. Maximum 20.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? Skills { get; set; }

        /// <summary>
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateAgentParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the agent. 1-256 characters.
        /// </param>
        /// <param name="model">
        /// Model identifier. Accepts the [model string](https://platform.claude.com/docs/en/about-claude/models/overview#latest-models-comparison), e.g. `claude-opus-4-6`, or a `model_config` object for additional configuration control
        /// </param>
        /// <param name="description">
        /// Description of what the agent does. Up to 2048 characters.
        /// </param>
        /// <param name="system">
        /// System prompt for the agent. Up to 100,000 characters.
        /// </param>
        /// <param name="tools">
        /// Tool configurations available to the agent. Maximum of 128 tools across all toolsets allowed.
        /// </param>
        /// <param name="mcpServers">
        /// MCP servers this agent connects to. Maximum 20. Names must be unique within the array.
        /// </param>
        /// <param name="skills">
        /// Skills available to the agent. Maximum 20.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value metadata. Maximum 16 pairs, keys up to 64 chars, values up to 512 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateAgentParams(
            string name,
            global::Anthropic.BetaManagedAgentsModelParams model,
            string? description,
            string? system,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentToolParams>? tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServerParams>? mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkillParams>? skills,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Model = model;
            this.Description = description;
            this.System = system;
            this.Tools = tools;
            this.McpServers = mcpServers;
            this.Skills = skills;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateAgentParams" /> class.
        /// </summary>
        public BetaManagedAgentsCreateAgentParams()
        {
        }
    }
}