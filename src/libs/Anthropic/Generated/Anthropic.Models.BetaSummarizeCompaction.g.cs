
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Compact the whole conversation and return a signed `compaction` block,<br/>
    /// alone, that a later request sends back first in `messages`, in place of<br/>
    /// the messages it summarizes. There is no trigger and no pause flag: sending<br/>
    /// the parameter compacts, and nothing is sampled after the block.<br/>
    /// The summarization prompt is the server's own unless `instructions` are<br/>
    /// given, which then replace it for this request; a value that is empty or<br/>
    /// only whitespace counts as absent.
    /// </summary>
    public sealed partial class BetaSummarizeCompaction
    {
        /// <summary>
        /// Replaces the server's default summarization prompt for this request. An empty or whitespace-only value counts as absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"summarize"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "summarize";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSummarizeCompaction" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Replaces the server's default summarization prompt for this request. An empty or whitespace-only value counts as absent.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSummarizeCompaction(
            string? instructions,
            string type = "summarize")
        {
            this.Instructions = instructions;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSummarizeCompaction" /> class.
        /// </summary>
        public BetaSummarizeCompaction()
        {
        }

    }
}