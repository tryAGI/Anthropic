
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The compressed request body exceeds the request size limit once decoded.
    /// </summary>
    public sealed partial class BetaRequestBodyTooLargeAfterDecodingErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"request_body_too_large_after_decoding"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "request_body_too_large_after_decoding";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestBodyTooLargeAfterDecodingErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestBodyTooLargeAfterDecodingErrorDetails(
            string errorCode = "request_body_too_large_after_decoding")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestBodyTooLargeAfterDecodingErrorDetails" /> class.
        /// </summary>
        public BetaRequestBodyTooLargeAfterDecodingErrorDetails()
        {
        }

    }
}