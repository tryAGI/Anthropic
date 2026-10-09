
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `messages` holds more than one `compaction` block with content. Send only the block the conversation returned last.
    /// </summary>
    public sealed partial class CompactionBlockAmbiguousErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_block_ambiguous"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_block_ambiguous";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionBlockAmbiguousErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionBlockAmbiguousErrorDetails(
            string errorCode = "compaction_block_ambiguous")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionBlockAmbiguousErrorDetails" /> class.
        /// </summary>
        public CompactionBlockAmbiguousErrorDetails()
        {
        }

    }
}