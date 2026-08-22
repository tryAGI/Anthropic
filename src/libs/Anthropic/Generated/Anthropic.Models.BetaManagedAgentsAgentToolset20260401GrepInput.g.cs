
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Input payload for the `grep` tool. Searches file contents for<br/>
    /// a regular expression, returning matching lines.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentToolset20260401GrepInput
    {
        /// <summary>
        /// Regular expression to search for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pattern { get; set; }

        /// <summary>
        /// Optional directory root to search under. Defaults to the<br/>
        /// runner's working directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401GrepInput" /> class.
        /// </summary>
        /// <param name="pattern">
        /// Regular expression to search for.
        /// </param>
        /// <param name="path">
        /// Optional directory root to search under. Defaults to the<br/>
        /// runner's working directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentToolset20260401GrepInput(
            string pattern,
            string? path)
        {
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentToolset20260401GrepInput" /> class.
        /// </summary>
        public BetaManagedAgentsAgentToolset20260401GrepInput()
        {
        }

    }
}