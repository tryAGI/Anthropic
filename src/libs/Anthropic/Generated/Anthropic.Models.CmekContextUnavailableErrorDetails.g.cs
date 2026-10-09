
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request's workspace encryption context could not be resolved, so the request was refused. Retry in a few minutes.
    /// </summary>
    public sealed partial class CmekContextUnavailableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cmek_context_unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cmek_context_unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CmekContextUnavailableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CmekContextUnavailableErrorDetails(
            string errorCode = "cmek_context_unavailable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CmekContextUnavailableErrorDetails" /> class.
        /// </summary>
        public CmekContextUnavailableErrorDetails()
        {
        }

    }
}