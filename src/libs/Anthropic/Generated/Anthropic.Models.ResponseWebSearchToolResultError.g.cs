
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
        /// <default>"web_search_tool_result_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "web_search_tool_result_error";

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
            string type = "web_search_tool_result_error")
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