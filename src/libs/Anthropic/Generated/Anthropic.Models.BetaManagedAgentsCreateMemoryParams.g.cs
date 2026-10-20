
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request body for [Create a Memory](https://platform.claude.com/docs/en/api/beta/memory_stores/memories/create).<br/>
    /// Creating a memory never replaces another one. The request fails with HTTP status 409 if a memory already uses `path`, or if `path` is an ancestor or descendant of another memory's path. It also fails, with HTTP status 400, if the memory store is archived or has reached its limit of 10,000 memories. To change an existing memory, update it instead.<br/>
    /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#create-a-memory) to learn more about creating memories.
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateMemoryParams
    {
        /// <summary>
        /// The path of the new memory, such as `/projects/foo/notes.md`. Paths are case-sensitive.<br/>
        /// A path starts with `/` and has 1 to 20 segments. A segment can't be empty and can't be `.` or `..`. A path can't contain control characters, format characters, or the line and paragraph separators U+2028 and U+2029. It must be in Unicode Normalization Form C and at most 1,024 bytes long.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The UTF-8 text content of the new memory. Pass `""` to create an empty memory.<br/>
        /// The maximum size is 100 kB (102,400 bytes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateMemoryParams" /> class.
        /// </summary>
        /// <param name="path">
        /// The path of the new memory, such as `/projects/foo/notes.md`. Paths are case-sensitive.<br/>
        /// A path starts with `/` and has 1 to 20 segments. A segment can't be empty and can't be `.` or `..`. A path can't contain control characters, format characters, or the line and paragraph separators U+2028 and U+2029. It must be in Unicode Normalization Form C and at most 1,024 bytes long.
        /// </param>
        /// <param name="content">
        /// The UTF-8 text content of the new memory. Pass `""` to create an empty memory.<br/>
        /// The maximum size is 100 kB (102,400 bytes).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCreateMemoryParams(
            string path,
            string? content)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCreateMemoryParams" /> class.
        /// </summary>
        public BetaManagedAgentsCreateMemoryParams()
        {
        }

    }
}