
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseBashCodeExecutionOutputBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// Default Value: bash_code_execution_output
        /// </summary>
        /// <default>global::Anthropic.BetaResponseBashCodeExecutionOutputBlockType.BashCodeExecutionOutput</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseBashCodeExecutionOutputBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseBashCodeExecutionOutputBlockType Type { get; set; } = global::Anthropic.BetaResponseBashCodeExecutionOutputBlockType.BashCodeExecutionOutput;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBashCodeExecutionOutputBlock" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="type">
        /// Default Value: bash_code_execution_output
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseBashCodeExecutionOutputBlock(
            string fileId,
            global::Anthropic.BetaResponseBashCodeExecutionOutputBlockType type = global::Anthropic.BetaResponseBashCodeExecutionOutputBlockType.BashCodeExecutionOutput)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBashCodeExecutionOutputBlock" /> class.
        /// </summary>
        public BetaResponseBashCodeExecutionOutputBlock()
        {
        }
    }
}