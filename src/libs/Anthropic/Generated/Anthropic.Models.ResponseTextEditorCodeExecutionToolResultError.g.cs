
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTextEditorCodeExecutionToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.TextEditorCodeExecutionToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.TextEditorCodeExecutionToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_tool_result_error
        /// </summary>
        /// <default>"text_editor_code_execution_tool_result_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text_editor_code_execution_tool_result_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextEditorCodeExecutionToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextEditorCodeExecutionToolResultError(
            global::Anthropic.TextEditorCodeExecutionToolResultErrorCode errorCode,
            string? errorMessage,
            string type = "text_editor_code_execution_tool_result_error")
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextEditorCodeExecutionToolResultError" /> class.
        /// </summary>
        public ResponseTextEditorCodeExecutionToolResultError()
        {
        }
    }
}