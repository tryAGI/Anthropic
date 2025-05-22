
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseCodeExecutionToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaCodeExecutionToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCodeExecutionToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: code_execution_tool_result_error
        /// </summary>
        /// <default>global::Anthropic.BetaResponseCodeExecutionToolResultErrorType.CodeExecutionToolResultError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseCodeExecutionToolResultErrorTypeJsonConverter))]
        public global::Anthropic.BetaResponseCodeExecutionToolResultErrorType Type { get; set; } = global::Anthropic.BetaResponseCodeExecutionToolResultErrorType.CodeExecutionToolResultError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeExecutionToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type">
        /// Default Value: code_execution_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCodeExecutionToolResultError(
            global::Anthropic.BetaCodeExecutionToolResultErrorCode errorCode,
            global::Anthropic.BetaResponseCodeExecutionToolResultErrorType type = global::Anthropic.BetaResponseCodeExecutionToolResultErrorType.CodeExecutionToolResultError)
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeExecutionToolResultError" /> class.
        /// </summary>
        public BetaResponseCodeExecutionToolResultError()
        {
        }
    }
}