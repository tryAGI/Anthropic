
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseWebSearchToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.WebSearchToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.WebSearchToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: web_search_tool_result_error
        /// </summary>
        /// <default>global::Anthropic.ResponseWebSearchToolResultErrorType.WebSearchToolResultError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResponseWebSearchToolResultErrorTypeJsonConverter))]
        public global::Anthropic.ResponseWebSearchToolResultErrorType Type { get; set; } = global::Anthropic.ResponseWebSearchToolResultErrorType.WebSearchToolResultError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type">
        /// Default Value: web_search_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseWebSearchToolResultError(
            global::Anthropic.WebSearchToolResultErrorCode errorCode,
            global::Anthropic.ResponseWebSearchToolResultErrorType type = global::Anthropic.ResponseWebSearchToolResultErrorType.WebSearchToolResultError)
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseWebSearchToolResultError" /> class.
        /// </summary>
        public ResponseWebSearchToolResultError()
        {
        }
    }
}