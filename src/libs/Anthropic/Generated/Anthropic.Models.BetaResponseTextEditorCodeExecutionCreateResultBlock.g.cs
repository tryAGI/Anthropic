
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextEditorCodeExecutionCreateResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_file_update")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsFileUpdate { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_create_result
        /// </summary>
        /// <default>global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextEditorCodeExecutionCreateResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlockType Type { get; set; } = global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionCreateResultBlock" /> class.
        /// </summary>
        /// <param name="isFileUpdate"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_create_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseTextEditorCodeExecutionCreateResultBlock(
            bool isFileUpdate,
            global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlockType type = global::Anthropic.BetaResponseTextEditorCodeExecutionCreateResultBlockType.TextEditorCodeExecutionCreateResult)
        {
            this.IsFileUpdate = isFileUpdate;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionCreateResultBlock" /> class.
        /// </summary>
        public BetaResponseTextEditorCodeExecutionCreateResultBlock()
        {
        }
    }
}