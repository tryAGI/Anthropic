
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseMCPToolUseBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Input { get; set; }

        /// <summary>
        /// The name of the MCP tool
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The name of the MCP server
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServerName { get; set; }

        /// <summary>
        /// Default Value: mcp_tool_use
        /// </summary>
        /// <default>global::Anthropic.BetaResponseMCPToolUseBlockType.McpToolUse</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseMCPToolUseBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseMCPToolUseBlockType Type { get; set; } = global::Anthropic.BetaResponseMCPToolUseBlockType.McpToolUse;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPToolUseBlock" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="input"></param>
        /// <param name="name">
        /// The name of the MCP tool
        /// </param>
        /// <param name="serverName">
        /// The name of the MCP server
        /// </param>
        /// <param name="type">
        /// Default Value: mcp_tool_use
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseMCPToolUseBlock(
            string id,
            object input,
            string name,
            string serverName,
            global::Anthropic.BetaResponseMCPToolUseBlockType type = global::Anthropic.BetaResponseMCPToolUseBlockType.McpToolUse)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ServerName = serverName ?? throw new global::System.ArgumentNullException(nameof(serverName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPToolUseBlock" /> class.
        /// </summary>
        public BetaResponseMCPToolUseBlock()
        {
        }
    }
}