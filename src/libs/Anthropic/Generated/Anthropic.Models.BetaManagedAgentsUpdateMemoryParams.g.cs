
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request body for [Update a Memory](https://platform.claude.com/docs/en/api/beta/memory_stores/memories/update). Set `content`, `path`, or both.<br/>
    /// Changing `path` renames the memory and never replaces another one. The request fails with HTTP status 409 if another memory uses the new path, or if the new path is an ancestor or descendant of another memory's path. Delete or rename the other memory first. The request also fails if the memory store is archived.<br/>
    /// If every field you set already matches the memory, nothing changes. The response is the current memory, which doesn't get a new version.<br/>
    /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#update-a-memory) to learn more about updating memories.
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateMemoryParams
    {
        /// <summary>
        /// New UTF-8 text content for the memory. Maximum 100 kB (102,400 bytes). Omit to leave the content unchanged (e.g., for a rename-only update).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The new path of the memory, which renames it. Omit it to keep the current path.<br/>
        /// The memory keeps its `id`. A path starts with `/` and has 1 to 20 segments. A segment can't be empty and can't be `.` or `..`. A path can't contain control characters, format characters, or the line and paragraph separators U+2028 and U+2029. It must be in Unicode Normalization Form C and at most 1,024 bytes long. Paths are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The condition that the memory must meet for the update to apply. Omit it to update unconditionally.<br/>
        /// If the condition fails, the request fails with HTTP status 409.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precondition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsPreconditionJsonConverter))]
        public global::Anthropic.BetaManagedAgentsPrecondition? Precondition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryParams" /> class.
        /// </summary>
        /// <param name="content">
        /// New UTF-8 text content for the memory. Maximum 100 kB (102,400 bytes). Omit to leave the content unchanged (e.g., for a rename-only update).
        /// </param>
        /// <param name="path">
        /// The new path of the memory, which renames it. Omit it to keep the current path.<br/>
        /// The memory keeps its `id`. A path starts with `/` and has 1 to 20 segments. A segment can't be empty and can't be `.` or `..`. A path can't contain control characters, format characters, or the line and paragraph separators U+2028 and U+2029. It must be in Unicode Normalization Form C and at most 1,024 bytes long. Paths are case-sensitive.
        /// </param>
        /// <param name="precondition">
        /// The condition that the memory must meet for the update to apply. Omit it to update unconditionally.<br/>
        /// If the condition fails, the request fails with HTTP status 409.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUpdateMemoryParams(
            string? content,
            string? path,
            global::Anthropic.BetaManagedAgentsPrecondition? precondition)
        {
            this.Content = content;
            this.Path = path;
            this.Precondition = precondition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUpdateMemoryParams" /> class.
        /// </summary>
        public BetaManagedAgentsUpdateMemoryParams()
        {
        }

    }
}