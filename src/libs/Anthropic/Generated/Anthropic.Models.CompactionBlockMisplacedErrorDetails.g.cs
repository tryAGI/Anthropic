
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `compaction` block is not the first block of the conversation, or is in a `system` message.
    /// </summary>
    public sealed partial class CompactionBlockMisplacedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_block_misplaced"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_block_misplaced";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionBlockMisplacedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionBlockMisplacedErrorDetails(
            string errorCode = "compaction_block_misplaced")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionBlockMisplacedErrorDetails" /> class.
        /// </summary>
        public CompactionBlockMisplacedErrorDetails()
        {
        }

    }
}