
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextEditorCodeExecutionToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaTextEditorCodeExecutionToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? ErrorMessage { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_tool_result_error
        /// </summary>
        /// <default>global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionToolResultErrorTypeJsonConverter))]
        public global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultErrorType Type { get; set; } = global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseTextEditorCodeExecutionToolResultError(
            global::Anthropic.BetaTextEditorCodeExecutionToolResultErrorCode errorCode,
            string? errorMessage,
            global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultErrorType type = global::Anthropic.BetaResponseTextEditorCodeExecutionToolResultErrorType.TextEditorCodeExecutionToolResultError)
        {
            this.ErrorCode = errorCode;
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionToolResultError" /> class.
        /// </summary>
        public BetaResponseTextEditorCodeExecutionToolResultError()
        {
        }
    }
}