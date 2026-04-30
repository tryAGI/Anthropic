
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for [Create a memory](/en/api/beta/memory_stores/memories/create). The path must be unoccupied: if a memory already exists at the path, or the path is an ancestor or descendant of an existing memory's path, the request returns `memory_path_conflict_error` (HTTP 409). Create never overwrites; to modify an existing memory, use [Update a memory](/en/api/beta/memory_stores/memories/update).
    /// </summary>
    public sealed partial class BetaManagedAgentsCreateMemoryParams
    {
        /// <summary>
        /// Hierarchical path for the new memory, e.g. `/projects/foo/notes.md`. Must start with `/`, contain at least one non-empty segment, and be at most 1,024 bytes. Must not contain empty segments, `.` or `..` segments, control or format characters, and must be NFC-normalized. Paths are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// UTF-8 text content for the new memory. Maximum 100 kB (102,400 bytes). Required; pass `""` explicitly to create an empty memory.
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
        /// Hierarchical path for the new memory, e.g. `/projects/foo/notes.md`. Must start with `/`, contain at least one non-empty segment, and be at most 1,024 bytes. Must not contain empty segments, `.` or `..` segments, control or format characters, and must be NFC-normalized. Paths are case-sensitive.
        /// </param>
        /// <param name="content">
        /// UTF-8 text content for the new memory. Maximum 100 kB (102,400 bytes). Required; pass `""` explicitly to create an empty memory.
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