
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BashCodeExecutionToolResultError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BashCodeExecutionToolResultErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BashCodeExecutionToolResultErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Default Value: bash_code_execution_tool_result_error
        /// </summary>
        /// <default>"bash_code_execution_tool_result_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bash_code_execution_tool_result_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BashCodeExecutionToolResultError" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="type">
        /// Default Value: bash_code_execution_tool_result_error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BashCodeExecutionToolResultError(
            global::Anthropic.BashCodeExecutionToolResultErrorCode errorCode,
            string type = "bash_code_execution_tool_result_error")
        {
            this.ErrorCode = errorCode;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BashCodeExecutionToolResultError" /> class.
        /// </summary>
        public BashCodeExecutionToolResultError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BashCodeExecutionToolResultError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BashCodeExecutionToolResultError FromErrorCode(global::Anthropic.BashCodeExecutionToolResultErrorCode errorCode)
        {
            return new BashCodeExecutionToolResultError
            {
                ErrorCode = errorCode,
            };
        }

    }
}