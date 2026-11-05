
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request would exceed a ramp limit, which caps how fast usage can grow. Retry after the time in the `retry-after` header.
    /// </summary>
    public sealed partial class RampLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ramp_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "ramp_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RampLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RampLimitExceededErrorDetails(
            string errorCode = "ramp_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RampLimitExceededErrorDetails" /> class.
        /// </summary>
        public RampLimitExceededErrorDetails()
        {
        }

    }
}