
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool as an MCP server lists it: its name on that server, its<br/>
    /// description, and its input schema.
    /// </summary>
    public sealed partial class BetaMCPTool
    {
        /// <summary>
        /// The tool's description as the MCP server lists it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The tool's input schema as the MCP server lists it, verbatim.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// The tool's name as the MCP server lists it (not prefixed with the server name).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPTool" /> class.
        /// </summary>
        /// <param name="inputSchema">
        /// The tool's input schema as the MCP server lists it, verbatim.
        /// </param>
        /// <param name="name">
        /// The tool's name as the MCP server lists it (not prefixed with the server name).
        /// </param>
        /// <param name="description">
        /// The tool's description as the MCP server lists it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMCPTool(
            object inputSchema,
            string name,
            string? description)
        {
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMCPTool" /> class.
        /// </summary>
        public BetaMCPTool()
        {
        }

    }
}