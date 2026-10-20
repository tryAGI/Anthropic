
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request's `Content-Type` header names a charset other than UTF-8, ISO-8859-1 or US-ASCII. Send the request with no charset, or with one of these.
    /// </summary>
    public sealed partial class BetaUnsupportedCharsetErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"unsupported_charset"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "unsupported_charset";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUnsupportedCharsetErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUnsupportedCharsetErrorDetails(
            string errorCode = "unsupported_charset")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUnsupportedCharsetErrorDetails" /> class.
        /// </summary>
        public BetaUnsupportedCharsetErrorDetails()
        {
        }

    }
}