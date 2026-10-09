
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An agent that has no Agent resource, and so no `id` or `version`. It is defined inline, in a workflow run's plan or when a session thread is spawned, and is not saved.<br/>
    /// Example: {"type":"inline","name":"pdf-reader-3","description":null,"model":{"id":"claude-opus-5","speed":"standard"},"system":"You extract tables precisely. Output CSV only.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_allow"}},"configs":[]}],"mcp_servers":[],"skills":[]}
    /// </summary>
    public sealed partial class BetaManagedAgentsInlineAgent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"inline"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "inline";

        /// <summary>
        /// The name that the agent's definition gave, or one that the server assigned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Model identifier and configuration.<br/>
        /// Example: {"id":"claude-opus-5","speed":"standard"}
        /// </summary>
        /// <example>{"id":"claude-opus-5","speed":"standard"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsModelConfig Model { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_servers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer> McpServers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill> Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInlineAgent" /> class.
        /// </summary>
        /// <param name="name">
        /// The name that the agent's definition gave, or one that the server assigned.
        /// </param>
        /// <param name="model">
        /// Model identifier and configuration.<br/>
        /// Example: {"id":"claude-opus-5","speed":"standard"}
        /// </param>
        /// <param name="tools"></param>
        /// <param name="mcpServers"></param>
        /// <param name="skills"></param>
        /// <param name="description"></param>
        /// <param name="system"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsInlineAgent(
            string name,
            global::Anthropic.BetaManagedAgentsModelConfig model,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool> tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer> mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill> skills,
            string? description,
            string? system,
            string type = "inline")
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.System = system;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.McpServers = mcpServers ?? throw new global::System.ArgumentNullException(nameof(mcpServers));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInlineAgent" /> class.
        /// </summary>
        public BetaManagedAgentsInlineAgent()
        {
        }

    }
}