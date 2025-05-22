
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseCodeExecutionOutputBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Default Value: code_execution_output
        /// </summary>
        /// <default>global::Anthropic.BetaResponseCodeExecutionOutputBlockType.CodeExecutionOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseCodeExecutionOutputBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseCodeExecutionOutputBlockType Type { get; set; } = global::Anthropic.BetaResponseCodeExecutionOutputBlockType.CodeExecutionOutput;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeExecutionOutputBlock" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="type">
        /// Default Value: code_execution_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseCodeExecutionOutputBlock(
            string fileId,
            global::Anthropic.BetaResponseCodeExecutionOutputBlockType type = global::Anthropic.BetaResponseCodeExecutionOutputBlockType.CodeExecutionOutput)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseCodeExecutionOutputBlock" /> class.
        /// </summary>
        public BetaResponseCodeExecutionOutputBlock()
        {
        }
    }
}