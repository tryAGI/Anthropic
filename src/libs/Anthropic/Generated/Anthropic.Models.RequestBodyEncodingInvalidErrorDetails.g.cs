
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request body is not valid for its `Content-Encoding`.
    /// </summary>
    public sealed partial class RequestBodyEncodingInvalidErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"request_body_encoding_invalid"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "request_body_encoding_invalid";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBodyEncodingInvalidErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestBodyEncodingInvalidErrorDetails(
            string errorCode = "request_body_encoding_invalid")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBodyEncodingInvalidErrorDetails" /> class.
        /// </summary>
        public RequestBodyEncodingInvalidErrorDetails()
        {
        }

    }
}