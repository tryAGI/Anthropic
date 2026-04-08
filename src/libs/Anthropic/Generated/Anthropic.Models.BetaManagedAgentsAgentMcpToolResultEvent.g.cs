
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Event representing the result of an MCP tool execution.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentMcpToolResultEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentMcpToolResultEventTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentMcpToolResultEventType Type { get; set; }

        /// <summary>
        /// Unique identifier for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The id of the `agent.mcp_tool_use` event this result corresponds to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_tool_use_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpToolUseId { get; set; }

        /// <summary>
        /// The result content returned by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? Content { get; set; }

        /// <summary>
        /// Whether the tool execution resulted in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_error")]
        public bool? IsError { get; set; }

        /// <summary>
        /// Timestamp when this event was processed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processed_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ProcessedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentMcpToolResultEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this event.
        /// </param>
        /// <param name="mcpToolUseId">
        /// The id of the `agent.mcp_tool_use` event this result corresponds to.
        /// </param>
        /// <param name="processedAt">
        /// Timestamp when this event was processed.
        /// </param>
        /// <param name="type"></param>
        /// <param name="content">
        /// The result content returned by the tool.
        /// </param>
        /// <param name="isError">
        /// Whether the tool execution resulted in an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentMcpToolResultEvent(
            string id,
            string mcpToolUseId,
            global::System.DateTime processedAt,
            global::Anthropic.BetaManagedAgentsAgentMcpToolResultEventType type,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsToolResultContentBlock>? content,
            bool? isError)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.McpToolUseId = mcpToolUseId ?? throw new global::System.ArgumentNullException(nameof(mcpToolUseId));
            this.Content = content;
            this.IsError = isError;
            this.ProcessedAt = processedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentMcpToolResultEvent" /> class.
        /// </summary>
        public BetaManagedAgentsAgentMcpToolResultEvent()
        {
        }
    }
}