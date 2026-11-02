
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request combines `thread` with a request field or an organization setting that Threads do not support; `unsupported`, when present, names it. Send the full conversation without `thread`, or change that field.
    /// </summary>
    public sealed partial class BetaThreadUnsupportedRequestErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread_unsupported_request"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "thread_unsupported_request";

        /// <summary>
        /// Each entry names a request field or an organization setting that Threads do not support. On a value you do not recognize, send the full conversation without `thread`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unsupported")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? Unsupported { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadUnsupportedRequestErrorDetails" /> class.
        /// </summary>
        /// <param name="unsupported">
        /// Each entry names a request field or an organization setting that Threads do not support. On a value you do not recognize, send the full conversation without `thread`.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThreadUnsupportedRequestErrorDetails(
            global::System.Collections.Generic.IList<global::Anthropic.BetaThreadUnsupportedRequestErrorDetailsUnsupportedVariant1Item>? unsupported,
            string errorCode = "thread_unsupported_request")
        {
            this.ErrorCode = errorCode;
            this.Unsupported = unsupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadUnsupportedRequestErrorDetails" /> class.
        /// </summary>
        public BetaThreadUnsupportedRequestErrorDetails()
        {
        }

    }
}