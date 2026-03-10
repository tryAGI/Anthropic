
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTextEditorCodeExecutionCreateResultBlock
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
        /// <default>"text_editor_code_execution_create_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "text_editor_code_execution_create_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextEditorCodeExecutionCreateResultBlock" /> class.
        /// </summary>
        /// <param name="isFileUpdate"></param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_create_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseTextEditorCodeExecutionCreateResultBlock(
            bool isFileUpdate,
            string type = "text_editor_code_execution_create_result")
        {
            this.IsFileUpdate = isFileUpdate;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextEditorCodeExecutionCreateResultBlock" /> class.
        /// </summary>
        public ResponseTextEditorCodeExecutionCreateResultBlock()
        {
        }
    }
}