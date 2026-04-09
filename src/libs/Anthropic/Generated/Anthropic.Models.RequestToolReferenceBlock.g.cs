
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Tool reference block that can be included in tool_result content.
    /// </summary>
    public sealed partial class RequestToolReferenceBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant161? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

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
        /// Initializes a new instance of the <see cref="RequestToolReferenceBlock" /> class.
        /// </summary>
        /// <param name="toolName"></param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestToolReferenceBlock(
            string toolName,
            global::Anthropic.CacheControlVariant161? cacheControl,
            string type = "tool_reference")
        {
            this.CacheControl = cacheControl;
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestToolReferenceBlock" /> class.
        /// </summary>
        public RequestToolReferenceBlock()
        {
        }
    }
}