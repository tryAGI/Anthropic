
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Reference to a single tool the caller declared directly in<br/>
    /// ``tools[]``. Does not accept the composed ``{server}_{name}`` form the<br/>
    /// server assigns to MCP-resolved tools — use ``mcp_tool_reference`` or<br/>
    /// ``mcp_toolset_reference`` for those.
    /// </summary>
    public sealed partial class BetaToolChangeToolReference
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"tool_reference"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_reference";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChangeToolReference" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolChangeToolReference(
            string name,
            string type = "tool_reference")
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChangeToolReference" /> class.
        /// </summary>
        public BetaToolChangeToolReference()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaToolChangeToolReference"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaToolChangeToolReference FromName(string name)
        {
            return new BetaToolChangeToolReference
            {
                Name = name,
            };
        }

    }
}