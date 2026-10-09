
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `messages` holds no `user` or `assistant` content to summarize or adopt.
    /// </summary>
    public sealed partial class BetaCompactionNothingToSummarizeErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_nothing_to_summarize"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_nothing_to_summarize";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionNothingToSummarizeErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionNothingToSummarizeErrorDetails(
            string errorCode = "compaction_nothing_to_summarize")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionNothingToSummarizeErrorDetails" /> class.
        /// </summary>
        public BetaCompactionNothingToSummarizeErrorDetails()
        {
        }

    }
}