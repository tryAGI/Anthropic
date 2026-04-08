
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Event emitted when the agent invokes a tool provided by an MCP server.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentMcpToolUseEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMcpToolUseEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentMcpToolUseEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the MCP tool being used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Name of the MCP server providing the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Input parameters for the tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsStruct Input { get; set; }

        /// <summary>
        /// Timestamp when this event was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// The evaluated permission policy for this tool invocation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluated_permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentEvaluatedPermissionJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? EvaluatedPermission { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentMcpToolUseEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="name">
        /// Name of the MCP tool being used.
        /// </param>
        /// <param name="mcpServerName">
        /// Name of the MCP server providing the tool.
        /// </param>
        /// <param name="input">
        /// Input parameters for the tool call.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when this event was processed.
        /// </param>
        /// <param name="type"></param>
        /// <param name="evaluatedPermission">
        /// The evaluated permission policy for this tool invocation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentMcpToolUseEvent(
            string id,
            string name,
            string mcpServerName,
            global::Anthropic.BetaManagedAgentsStruct input,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsAgentMcpToolUseEventType type,
            global::Anthropic.BetaManagedAgentsAgentEvaluatedPermission? evaluatedPermission)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.ProcessedAt = processedAt;
            this.EvaluatedPermission = evaluatedPermission;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentMcpToolUseEvent" /> class.
        /// </summary>
        public BetaManagedAgentsAgentMcpToolUseEvent()
        {
        }
    }
}