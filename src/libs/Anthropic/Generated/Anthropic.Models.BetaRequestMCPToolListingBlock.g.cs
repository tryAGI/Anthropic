
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tool listing an MCP server returned while an earlier response was<br/>
    /// produced, as that response carried it. Send the assistant message back<br/>
    /// unchanged, this block included, and the server uses this listing for the<br/>
    /// matching `mcp_toolset` instead of asking the MCP server again.
    /// </summary>
    public sealed partial class BetaRequestMCPToolListingBlock
    {
        /// <summary>
        /// The name of the MCP server this listing came from, as `mcp_servers` declares it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// The server's tools, exactly as the response listed them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"mcp_tool_listing"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_tool_listing";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMCPToolListingBlock" /> class.
        /// </summary>
        /// <param name="mcpServerName">
        /// The name of the MCP server this listing came from, as `mcp_servers` declares it.
        /// </param>
        /// <param name="tools">
        /// The server's tools, exactly as the response listed them.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestMCPToolListingBlock(
            string mcpServerName,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMCPTool> tools,
            string type = "mcp_tool_listing")
        {
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMCPToolListingBlock" /> class.
        /// </summary>
        public BetaRequestMCPToolListingBlock()
        {
        }

    }
}