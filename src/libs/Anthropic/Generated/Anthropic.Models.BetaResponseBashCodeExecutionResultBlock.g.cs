
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseBashCodeExecutionResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ReturnCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stderr { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Stdout { get; set; }

        /// <summary>
        /// Default Value: bash_code_execution_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseBashCodeExecutionResultBlockType.BashCodeExecutionResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseBashCodeExecutionResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseBashCodeExecutionResultBlockType Type { get; set; } = global::Anthropic.BetaResponseBashCodeExecutionResultBlockType.BashCodeExecutionResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBashCodeExecutionResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="returnCode"></param>
        /// <param name="stderr"></param>
        /// <param name="stdout"></param>
        /// <param name="type">
        /// Default Value: bash_code_execution_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseBashCodeExecutionResultBlock(
            global::System.Collections.Generic.IList<global::Anthropic.BetaResponseBashCodeExecutionOutputBlock> content,
            int returnCode,
            string stderr,
            string stdout,
            global::Anthropic.BetaResponseBashCodeExecutionResultBlockType type = global::Anthropic.BetaResponseBashCodeExecutionResultBlockType.BashCodeExecutionResult)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.ReturnCode = returnCode;
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Stdout = stdout ?? throw new global::System.ArgumentNullException(nameof(stdout));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBashCodeExecutionResultBlock" /> class.
        /// </summary>
        public BetaResponseBashCodeExecutionResultBlock()
        {
        }
    }
}