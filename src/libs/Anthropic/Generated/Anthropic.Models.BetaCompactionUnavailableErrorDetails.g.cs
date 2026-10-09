
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The compaction could not be completed for a transient server reason. Retry the request.
    /// </summary>
    public sealed partial class BetaCompactionUnavailableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compaction_unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compaction_unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionUnavailableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCompactionUnavailableErrorDetails(
            string errorCode = "compaction_unavailable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCompactionUnavailableErrorDetails" /> class.
        /// </summary>
        public BetaCompactionUnavailableErrorDetails()
        {
        }

    }
}