
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The compaction request ends on an `assistant` turn that is not finished.
    /// </summary>
    public sealed partial class CompactionIncompleteTurnErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_incomplete_turn"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_incomplete_turn";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionIncompleteTurnErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionIncompleteTurnErrorDetails(
            string errorCode = "compaction_incomplete_turn")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionIncompleteTurnErrorDetails" /> class.
        /// </summary>
        public CompactionIncompleteTurnErrorDetails()
        {
        }

    }
}