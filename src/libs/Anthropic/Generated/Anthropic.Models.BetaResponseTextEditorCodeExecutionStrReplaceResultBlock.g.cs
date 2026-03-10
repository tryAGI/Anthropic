
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextEditorCodeExecutionStrReplaceResultBlock
    {
        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string>? Lines { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? NewLines { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? NewStart { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_lines")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OldLines { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("old_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? OldStart { get; set; }

        /// <summary>
        /// Default Value: text_editor_code_execution_str_replace_result
        /// </summary>
        /// <default>"text_editor_code_execution_str_replace_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "text_editor_code_execution_str_replace_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionStrReplaceResultBlock" /> class.
        /// </summary>
        /// <param name="lines">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="newLines">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="newStart">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="oldLines">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="oldStart">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="type">
        /// Default Value: text_editor_code_execution_str_replace_result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseTextEditorCodeExecutionStrReplaceResultBlock(
            global::System.Collections.Generic.IList<string>? lines,
            int? newLines,
            int? newStart,
            int? oldLines,
            int? oldStart,
            string type)
        {
            this.Lines = lines ?? throw new global::System.ArgumentNullException(nameof(lines));
            this.NewLines = newLines ?? throw new global::System.ArgumentNullException(nameof(newLines));
            this.NewStart = newStart ?? throw new global::System.ArgumentNullException(nameof(newStart));
            this.OldLines = oldLines ?? throw new global::System.ArgumentNullException(nameof(oldLines));
            this.OldStart = oldStart ?? throw new global::System.ArgumentNullException(nameof(oldStart));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextEditorCodeExecutionStrReplaceResultBlock" /> class.
        /// </summary>
        public BetaResponseTextEditorCodeExecutionStrReplaceResultBlock()
        {
        }
    }
}