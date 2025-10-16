
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseContextManagement
    {
        /// <summary>
        /// List of context management edits that were applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("applied_edits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaResponseClearToolUses20250919Edit> AppliedEdits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseContextManagement" /> class.
        /// </summary>
        /// <param name="appliedEdits">
        /// List of context management edits that were applied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseContextManagement(
            global::System.Collections.Generic.IList<global::Anthropic.BetaResponseClearToolUses20250919Edit> appliedEdits)
        {
            this.AppliedEdits = appliedEdits ?? throw new global::System.ArgumentNullException(nameof(appliedEdits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseContextManagement" /> class.
        /// </summary>
        public BetaResponseContextManagement()
        {
        }
    }
}