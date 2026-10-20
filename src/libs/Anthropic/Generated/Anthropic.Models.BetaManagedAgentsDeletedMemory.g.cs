
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The confirmation that [Delete a Memory](https://platform.claude.com/docs/en/api/beta/memory_stores/memories/delete) returns.<br/>
    /// Deleting a memory doesn't delete its versions. [List Memory Versions](https://platform.claude.com/docs/en/api/beta/memory_stores/memory_versions/list) returns them while they are retained: each version is kept for at least the version retention period after it was written, unless the store itself is deleted.<br/>
    /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#audit-memory-changes) to learn more about how long versions are kept.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeletedMemory
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDeletedMemoryTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDeletedMemoryType Type { get; set; }

        /// <summary>
        /// ID of the deleted memory (a `mem_...` value).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedMemory" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted memory (a `mem_...` value).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedMemory(
            string id,
            global::Anthropic.BetaManagedAgentsDeletedMemoryType type)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedMemory" /> class.
        /// </summary>
        public BetaManagedAgentsDeletedMemory()
        {
        }

    }
}