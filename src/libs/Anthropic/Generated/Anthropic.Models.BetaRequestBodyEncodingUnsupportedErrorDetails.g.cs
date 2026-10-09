
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request's `Content-Encoding` is not supported.
    /// </summary>
    public sealed partial class BetaRequestBodyEncodingUnsupportedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"request_body_encoding_unsupported"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "request_body_encoding_unsupported";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestBodyEncodingUnsupportedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestBodyEncodingUnsupportedErrorDetails(
            string errorCode = "request_body_encoding_unsupported")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestBodyEncodingUnsupportedErrorDetails" /> class.
        /// </summary>
        public BetaRequestBodyEncodingUnsupportedErrorDetails()
        {
        }

    }
}