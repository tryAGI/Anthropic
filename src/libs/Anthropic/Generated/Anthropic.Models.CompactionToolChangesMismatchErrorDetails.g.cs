
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `compaction` block's `tool_changes` differs from what was returned with the block.
    /// </summary>
    public sealed partial class CompactionToolChangesMismatchErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_tool_changes_mismatch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_tool_changes_mismatch";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionToolChangesMismatchErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionToolChangesMismatchErrorDetails(
            string errorCode = "compaction_tool_changes_mismatch")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionToolChangesMismatchErrorDetails" /> class.
        /// </summary>
        public CompactionToolChangesMismatchErrorDetails()
        {
        }

    }
}