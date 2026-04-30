
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for [Update a memory](/en/api/beta/memory_stores/memories/update). At least one of `content` or `path` must be provided. Renaming onto a path occupied by a different memory returns `memory_path_conflict_error` (HTTP 409). Rename never overwrites; delete or rename the blocking memory first. An update where every supplied field already matches the stored value is a no-op: it returns 200 with the existing memory and writes no new version.
    /// </summary>
    public sealed partial class BetaManagedAgentsUpdateMemoryParams
    {
        /// <summary>
        /// New UTF-8 text content for the memory. Maximum 100 kB (102,400 bytes). Omit to leave the content unchanged (e.g., for a rename-only update).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// New path for the memory (a rename). Must start with `/`, contain at least one non-empty segment, and be at most 1,024 bytes. Must not contain empty segments, `.` or `..` segments, control or format characters, and must be NFC-normalized. Paths are case-sensitive. The memory's `id` is preserved across renames. Omit to leave the path unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Optional optimistic-concurrency precondition. When supplied, the update applies only if the memory's current state matches; on mismatch the request returns `memory_precondition_failed_error` (HTTP 409). When omitted, the update is unconditional.
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
        /// New path for the memory (a rename). Must start with `/`, contain at least one non-empty segment, and be at most 1,024 bytes. Must not contain empty segments, `.` or `..` segments, control or format characters, and must be NFC-normalized. Paths are case-sensitive. The memory's `id` is preserved across renames. Omit to leave the path unchanged.
        /// </param>
        /// <param name="precondition">
        /// Optional optimistic-concurrency precondition. When supplied, the update applies only if the memory's current state matches; on mismatch the request returns `memory_precondition_failed_error` (HTTP 409). When omitted, the update is unconditional.
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