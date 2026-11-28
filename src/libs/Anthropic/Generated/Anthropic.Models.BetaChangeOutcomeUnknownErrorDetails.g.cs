
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Some of the request's changes may have been saved and others not. Send the same request again to finish it; changes already saved aren't repeated.
    /// </summary>
    public sealed partial class BetaChangeOutcomeUnknownErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"change_outcome_unknown"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "change_outcome_unknown";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaChangeOutcomeUnknownErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaChangeOutcomeUnknownErrorDetails(
            string errorCode = "change_outcome_unknown")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaChangeOutcomeUnknownErrorDetails" /> class.
        /// </summary>
        public BetaChangeOutcomeUnknownErrorDetails()
        {
        }

    }
}