
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
        /// <param name="type">
        /// Default Value: compaction
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCompactionBlock(
            string? content,
            string type = "compaction")
        {
            this.Content = content;
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