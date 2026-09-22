
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A compaction block containing summary of previous context.<br/>
    /// Users should round-trip these blocks from responses to subsequent requests<br/>
    /// to maintain context across compaction boundaries.<br/>
    /// When content is None, the block represents a failed compaction. The server<br/>
    /// treats these as no-ops. Empty string content is not allowed.
    /// </summary>
    public sealed partial class BetaRequestCompactionBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant122? CacheControl { get; set; }

        /// <summary>
        /// Summary of previously compacted content, or null if compaction failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Opaque metadata from prior compaction, to be round-tripped verbatim
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// The block's signature as returned, to be sent back verbatim
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// The tool changes of the compacted range, as the server returned them on this block: the `tool_addition` and `tool_removal` entries that take the request's `tools` to the tool set in effect at the end of the range. Send them back unchanged with the block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_changes")]
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? ToolChanges { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compaction";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCompactionBlock" /> class.
        /// </summary>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="content">
        /// Summary of previously compacted content, or null if compaction failed
        /// </param>
        /// <param name="encryptedContent">
        /// Opaque metadata from prior compaction, to be round-tripped verbatim
        /// </param>
        /// <param name="signature">
        /// The block's signature as returned, to be sent back verbatim
        /// </param>
        /// <param name="toolChanges">
        /// The tool changes of the compacted range, as the server returned them on this block: the `tool_addition` and `tool_removal` entries that take the request's `tools` to the tool set in effect at the end of the range. Send them back unchanged with the block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestCompactionBlock(
            global::Anthropic.CacheControlVariant122? cacheControl,
            string? content,
            string? encryptedContent,
            string? signature,
            global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item>? toolChanges,
            string type = "compaction")
        {
            this.CacheControl = cacheControl;
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Signature = signature;
            this.ToolChanges = toolChanges;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCompactionBlock" /> class.
        /// </summary>
        public BetaRequestCompactionBlock()
        {
        }

    }
}