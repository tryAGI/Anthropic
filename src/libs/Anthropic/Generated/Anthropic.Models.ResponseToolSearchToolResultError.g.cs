
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseToolSearchToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ToolSearchToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ToolSearchToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Default Value: tool_search_tool_result_error
        /// </summary>
        /// <default>"tool_search_tool_result_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tool_search_tool_result_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolSearchToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: tool_search_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseToolSearchToolResultError(
            global::Anthropic.ToolSearchToolResultErrorCode errorCode,
            string? errorMessage,
            string type = "tool_search_tool_result_error")
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseToolSearchToolResultError" /> class.
        /// </summary>
        public ResponseToolSearchToolResultError()
        {
        }
    }
}