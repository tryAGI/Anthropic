
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Code execution result with encrypted stdout for PFC + web_search results.
    /// </summary>
    public sealed partial class RequestEncryptedCodeExecutionResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock> Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_stdout")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string EncryptedStdout { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int ReturnCode { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stderr")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Stderr { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        /// <default>"encrypted_code_execution_result"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "encrypted_code_execution_result";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestEncryptedCodeExecutionResultBlock" /> class.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="encryptedStdout"></param>
        /// <param name="returnCode"></param>
        /// <param name="stderr"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestEncryptedCodeExecutionResultBlock(
            global::System.Collections.Generic.IList<global::Anthropic.RequestCodeExecutionOutputBlock> content,
            string encryptedStdout,
            int returnCode,
            string stderr,
            string type = "encrypted_code_execution_result")
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.EncryptedStdout = encryptedStdout ?? throw new global::System.ArgumentNullException(nameof(encryptedStdout));
            this.ReturnCode = returnCode;
            this.Stderr = stderr ?? throw new global::System.ArgumentNullException(nameof(stderr));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestEncryptedCodeExecutionResultBlock" /> class.
        /// </summary>
        public RequestEncryptedCodeExecutionResultBlock()
        {
        }
    }
}