
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The conversation references more distinct tools than a `compaction` block can record.
    /// </summary>
    public sealed partial class CompactionTooManyToolReferencesErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_too_many_tool_references"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_too_many_tool_references";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionTooManyToolReferencesErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactionTooManyToolReferencesErrorDetails(
            string errorCode = "compaction_too_many_tool_references")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactionTooManyToolReferencesErrorDetails" /> class.
        /// </summary>
        public CompactionTooManyToolReferencesErrorDetails()
        {
        }

    }
}