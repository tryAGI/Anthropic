
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseWebFetchToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaWebFetchToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWebFetchToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: web_fetch_tool_result_error
        /// </summary>
        /// <default>global::Anthropic.BetaResponseWebFetchToolResultErrorType.WebFetchToolResultError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseWebFetchToolResultErrorTypeJsonConverter))]
        public global::Anthropic.BetaResponseWebFetchToolResultErrorType Type { get; set; } = global::Anthropic.BetaResponseWebFetchToolResultErrorType.WebFetchToolResultError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebFetchToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type">
        /// Default Value: web_fetch_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseWebFetchToolResultError(
            global::Anthropic.BetaWebFetchToolResultErrorCode errorCode,
            global::Anthropic.BetaResponseWebFetchToolResultErrorType type = global::Anthropic.BetaResponseWebFetchToolResultErrorType.WebFetchToolResultError)
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWebFetchToolResultError" /> class.
        /// </summary>
        public BetaResponseWebFetchToolResultError()
        {
        }
    }
}