
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Automatically compact older context when reaching the configured trigger threshold.
    /// </summary>
    public sealed partial class BetaCompact20260112
    {
        /// <summary>
        /// Additional instructions for summarization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Whether to pause after compaction and return the compaction block to the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pause_after_compaction")]
        public bool? PauseAfterCompaction { get; set; }

        /// <summary>
        /// When to trigger compaction. Defaults to 150000 input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger")]
        public global::Anthropic.BetaInputTokensTrigger? Trigger { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"compact_20260112"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "compact_20260112";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompact20260112" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Additional instructions for summarization.
        /// </param>
        /// <param name="pauseAfterCompaction">
        /// Whether to pause after compaction and return the compaction block to the user.
        /// </param>
        /// <param name="trigger">
        /// When to trigger compaction. Defaults to 150000 input tokens.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompact20260112(
            string? instructions,
            bool? pauseAfterCompaction,
            global::Anthropic.BetaInputTokensTrigger? trigger,
            string type = "compact_20260112")
        {
            this.Instructions = instructions;
            this.PauseAfterCompaction = pauseAfterCompaction;
            this.Trigger = trigger;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompact20260112" /> class.
        /// </summary>
        public BetaCompact20260112()
        {
        }
    }
}