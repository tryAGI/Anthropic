
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Input payload for the `write` tool. Writes (overwriting) the<br/>
    /// entire file contents.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401WriteInput
    {
        /// <summary>
        /// Path of the file to write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FilePath { get; set; }

        /// <summary>
        /// Full file contents to write.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401WriteInput" /> class.
        /// </summary>
        /// <param name="filePath">
        /// Path of the file to write.
        /// </param>
        /// <param name="content">
        /// Full file contents to write.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401WriteInput(
            string filePath,
            string content)
        {
            this.FilePath = filePath ?? throw new global::System.ArgumentNullException(nameof(filePath));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401WriteInput" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401WriteInput()
        {
        }

    }
}