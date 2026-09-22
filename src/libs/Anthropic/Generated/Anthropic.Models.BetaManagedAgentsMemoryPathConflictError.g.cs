
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The error returned with HTTP status 409 when a create or rename targets a path that another memory uses, or a path that overlaps another memory's path.<br/>
    /// Two paths overlap when one is an ancestor of the other, such as `/notes` and `/notes/todo.md`. To free the path, rename or delete the memory that `conflicting_memory_id` references, then retry. To change that memory instead of creating a new one, update it.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryPathConflictError
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryPathConflictErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryPathConflictErrorType Type { get; set; }

        /// <summary>
        /// A human-readable explanation of the conflict. To handle the error in code, use `conflicting_path` and `conflicting_memory_id` instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// The path that blocked the write: the requested path, or the path of a memory that is an ancestor or descendant of it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflicting_path")]
        public string? ConflictingPath { get; set; }

        /// <summary>
        /// The ID of the memory that blocked the write (`mem_...`), or an empty string if that memory can't be identified.<br/>
        /// Retry the request when it is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflicting_memory_id")]
        public string? ConflictingMemoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPathConflictError" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message">
        /// A human-readable explanation of the conflict. To handle the error in code, use `conflicting_path` and `conflicting_memory_id` instead.
        /// </param>
        /// <param name="conflictingPath">
        /// The path that blocked the write: the requested path, or the path of a memory that is an ancestor or descendant of it.
        /// </param>
        /// <param name="conflictingMemoryId">
        /// The ID of the memory that blocked the write (`mem_...`), or an empty string if that memory can't be identified.<br/>
        /// Retry the request when it is empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryPathConflictError(
            global::Anthropic.BetaManagedAgentsMemoryPathConflictErrorType type,
            string? message,
            string? conflictingPath,
            string? conflictingMemoryId)
        {
            this.Type = type;
            this.Message = message;
            this.ConflictingPath = conflictingPath;
            this.ConflictingMemoryId = conflictingMemoryId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryPathConflictError" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryPathConflictError()
        {
        }

    }
}