
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseBashCodeExecutionToolResultError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaBashCodeExecutionToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaBashCodeExecutionToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: bash_code_execution_tool_result_error
        /// </summary>
        /// <default>global::Anthropic.BetaResponseBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseBashCodeExecutionToolResultErrorTypeJsonConverter))]
        public global::Anthropic.BetaResponseBashCodeExecutionToolResultErrorType Type { get; set; } = global::Anthropic.BetaResponseBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBashCodeExecutionToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type">
        /// Default Value: bash_code_execution_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseBashCodeExecutionToolResultError(
            global::Anthropic.BetaBashCodeExecutionToolResultErrorCode errorCode,
            global::Anthropic.BetaResponseBashCodeExecutionToolResultErrorType type = global::Anthropic.BetaResponseBashCodeExecutionToolResultErrorType.BashCodeExecutionToolResultError)
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBashCodeExecutionToolResultError" /> class.
        /// </summary>
        public BetaResponseBashCodeExecutionToolResultError()
        {
        }
    }
}