
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `compaction` block's `content` differs from the text its `signature` recorded.
    /// </summary>
    public sealed partial class BetaCompactionContentMismatchErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_content_mismatch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_content_mismatch";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionContentMismatchErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionContentMismatchErrorDetails(
            string errorCode = "compaction_content_mismatch")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionContentMismatchErrorDetails" /> class.
        /// </summary>
        public BetaCompactionContentMismatchErrorDetails()
        {
        }

    }
}