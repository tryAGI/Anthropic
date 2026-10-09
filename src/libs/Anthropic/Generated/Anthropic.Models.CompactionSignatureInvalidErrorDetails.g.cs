
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The `compaction` block's `signature` does not verify.
    /// </summary>
    public sealed partial class CompactionSignatureInvalidErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_signature_invalid"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_signature_invalid";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSignatureInvalidErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionSignatureInvalidErrorDetails(
            string errorCode = "compaction_signature_invalid")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionSignatureInvalidErrorDetails" /> class.
        /// </summary>
        public CompactionSignatureInvalidErrorDetails()
        {
        }

    }
}