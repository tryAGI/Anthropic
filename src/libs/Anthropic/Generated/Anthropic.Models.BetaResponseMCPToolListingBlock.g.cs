
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tool listing the server fetched from an MCP server while producing<br/>
    /// this response. Send the assistant message back unchanged, this block<br/>
    /// included, so later requests use this listing instead of asking the MCP<br/>
    /// server again.
    /// </summary>
    public sealed partial class BetaResponseMCPToolListingBlock
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaResponseMCPTool> Tools { get; set; }

        /// <summary>
        /// Default Value: mcp_tool_listing
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
        /// Initializes a new instance of the <see cref="BetaResponseMCPToolListingBlock" /> class.
        /// </summary>
        /// <param name="mcpServerName"></param>
        /// <param name="tools"></param>
        /// <param name="type">
        /// Default Value: mcp_tool_listing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseMCPToolListingBlock(
            string mcpServerName,
            global::System.Collections.Generic.IList<global::Anthropic.BetaResponseMCPTool> tools,
            string type = "mcp_tool_listing")
        {
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseMCPToolListingBlock" /> class.
        /// </summary>
        public BetaResponseMCPToolListingBlock()
        {
        }

    }
}