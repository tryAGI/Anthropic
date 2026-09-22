
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A compaction block returned when autocompact is triggered.<br/>
    /// When content is None, it indicates the compaction failed to produce a valid<br/>
    /// summary (e.g., malformed output from the model). Clients may round-trip<br/>
    /// compaction blocks with null content; the server treats them as no-ops.
    /// </summary>
    public sealed partial class BetaResponseCompactionBlock
    {
        /// <summary>
        /// Summary of compacted content, or null if compaction failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Opaque metadata from prior compaction, to be round-tripped verbatim<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// Signature over the summary, to be sent back with the block verbatim
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// The tool changes of the compacted range: the `tool_addition` and `tool_removal` blocks that take the request's `tools` to the tool set in effect at the end of the range, or `[]` when the range changed no tool. Absent when the server did not compute them. Send the block back unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_changes")]
        public global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item2>? ToolChanges { get; set; }

        /// <summary>
        /// Default Value: compaction
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
        /// Initializes a new instance of the <see cref="BetaResponseCompactionBlock" /> class.
        /// </summary>
        /// <param name="content">
        /// Summary of compacted content, or null if compaction failed
        /// </param>
        /// <param name="encryptedContent">
        /// Opaque metadata from prior compaction, to be round-tripped verbatim<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="signature">
        /// Signature over the summary, to be sent back with the block verbatim
        /// </param>
        /// <param name="toolChanges">
        /// The tool changes of the compacted range: the `tool_addition` and `tool_removal` blocks that take the request's `tools` to the tool set in effect at the end of the range, or `[]` when the range changed no tool. Absent when the server did not compute them. Send the block back unchanged.
        /// </param>
        /// <param name="type">
        /// Default Value: compaction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCompactionBlock(
            string? content,
            string? encryptedContent,
            string? signature,
            global::System.Collections.Generic.IList<global::Anthropic.ToolChangesVariant1Item2>? toolChanges,
            string type = "compaction")
        {
            this.Content = content;
            this.EncryptedContent = encryptedContent;
            this.Signature = signature;
            this.ToolChanges = toolChanges;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCompactionBlock" /> class.
        /// </summary>
        public BetaResponseCompactionBlock()
        {
        }

    }
}