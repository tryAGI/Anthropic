
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resolved `agent` definition for a single `session_thread`. Snapshot of the agent at thread creation time. The multiagent roster is not repeated here; read it from `Session.agent`.<br/>
    /// Example: {"type":"agent","id":"agent_011CZkYqphY8vELVzwCUpqiQ","version":1,"name":"Researcher","description":"A focused research subagent.","model":{"id":"claude-opus-5-5","speed":"standard"},"system":"You are a research subagent that gathers and summarises sources for the coordinating agent.","tools":[{"type":"agent_toolset_20260401","default_config":{"enabled":true,"permission_policy":{"type":"always_ask"}},"configs":[]}],"mcp_servers":[],"skills":[],"execution_identity":{"type":"service_account"}}
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionThreadAgent
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"agent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent";

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
        /// Example: {"id":"claude-opus-5-5","speed":"standard"}
        /// </summary>
        /// <example>{"id":"claude-opus-5-5","speed":"standard"}</example>
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
        /// Execution principal snapshotted from the agent at session creation. Always present; `{"type": "service_account"}` when runs carry no customer-named principal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_identity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsExecutionIdentityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsExecutionIdentity ExecutionIdentity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadAgent" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="version"></param>
        /// <param name="name"></param>
        /// <param name="model">
        /// Model identifier and configuration.<br/>
        /// Example: {"id":"claude-opus-5-5","speed":"standard"}
        /// </param>
        /// <param name="tools"></param>
        /// <param name="mcpServers"></param>
        /// <param name="skills"></param>
        /// <param name="executionIdentity">
        /// Execution principal snapshotted from the agent at session creation. Always present; `{"type": "service_account"}` when runs carry no customer-named principal.
        /// </param>
        /// <param name="description"></param>
        /// <param name="system"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionThreadAgent(
            string id,
            int version,
            string name,
            global::Anthropic.BetaManagedAgentsModelConfig model,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsAgentTool> tools,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMCPServer> mcpServers,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSkill> skills,
            global::Anthropic.BetaManagedAgentsExecutionIdentity executionIdentity,
            string? description,
            string? system,
            string type = "agent")
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
            this.ExecutionIdentity = executionIdentity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionThreadAgent" /> class.
        /// </summary>
        public BetaManagedAgentsSessionThreadAgent()
        {
        }

    }
}