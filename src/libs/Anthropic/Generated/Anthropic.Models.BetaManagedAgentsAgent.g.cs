
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Managed Agents `agent`.<br/>
    /// Example: {"type":"agent","id":"agent_011CZkYpogX7uDKUyvBTophP","version":1,"name":"My First Agent","description":"A general-purpose starter agent.","model":{"id":"claude-sonnet-4-6","speed":"standard"},"system":"You are a general-purpose agent that can research, write code, run commands, and use connected tools to complete the user\u0027s task end to end.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[{"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}],"skills":[{"type":"anthropic","skill_id":"xlsx","version":"1"},{"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTlx","version":"2"}],"metadata":{"foo":"bar"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null}
    /// </summary>
    public sealed partial class BetaManagedAgentsAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The agent's current version. Starts at 1 and increments when the agent is modified.
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// A timestamp in RFC 3339 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// When the agent was archived. Null if not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version">
        /// The agent's current version. Starts at 1 and increments when the agent is modified.
        /// </param>
        /// <param name="name"></param>
        /// <param name="model">
        /// Model identifier and configuration.<br/>
        /// Example: {"id":"claude-opus-4-6","speed":"standard"}
        /// </param>
        /// <param name="tools"></param>
        /// <param name="mcpServers"></param>
        /// <param name="skills"></param>
        /// <param name="metadata"></param>
        /// <param name="createdAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="updatedAt">
        /// A timestamp in RFC 3339 format
        /// </param>
        /// <param name="type"></param>
        /// <param name="description"></param>
        /// <param name="system"></param>
        /// <param name="archivedAt">
        /// When the agent was archived. Null if not archived.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgent(
            string id,
            int version,
            string name,
            global::Anthropic.BetaManagedAgentsModelConfig model,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool> tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer> mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill> skills,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsAgentType type,
            string? description,
            string? system,
            global::System.DateTime? archivedAt)
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
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgent" /> class.
        /// </summary>
        public BetaManagedAgentsAgent()
        {
        }
    }
}