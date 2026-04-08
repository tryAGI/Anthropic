
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved `agent` definition for a `session`. Snapshot of the `agent` at `session` creation time.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionAgentTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionAgentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// 
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
        /// Example: {"id":"claude-opus-4-6","speed":"standard"}
        /// </summary>
        /// <example>{"id":"claude-opus-4-6","speed":"standard"}</example>
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionAgent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="name"></param>
        /// <param name="model">
        /// Model identifier and configuration.<br/>
        /// Example: {"id":"claude-opus-4-6","speed":"standard"}
        /// </param>
        /// <param name="tools"></param>
        /// <param name="mcpServers"></param>
        /// <param name="skills"></param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="system"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionAgent(
            string id,
            int version,
            string name,
            global::Anthropic.BetaManagedAgentsModelConfig model,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool> tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer> mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill> skills,
            global::Anthropic.BetaManagedAgentsSessionAgentType type,
            string? description,
            string? system)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Version = version;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.System = system;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.McpServers = mcpServers ?? throw new global::System.ArgumentNullException(nameof(mcpServers));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionAgent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionAgent()
        {
        }
    }
}