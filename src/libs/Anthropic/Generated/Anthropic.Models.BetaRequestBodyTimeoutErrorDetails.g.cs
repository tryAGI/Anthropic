
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request body did not finish arriving in time, so nothing was done. Send a smaller body, or send it over a faster connection.
    /// </summary>
    public sealed partial class BetaRequestBodyTimeoutErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"request_body_timeout"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "request_body_timeout";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestBodyTimeoutErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestBodyTimeoutErrorDetails(
            string errorCode = "request_body_timeout")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestBodyTimeoutErrorDetails" /> class.
        /// </summary>
        public BetaRequestBodyTimeoutErrorDetails()
        {
        }

    }
}