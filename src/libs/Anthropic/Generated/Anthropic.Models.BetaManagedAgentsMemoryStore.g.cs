
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A `memory_store`: a named container for agent memories, scoped to a workspace. Attach a store to a session via `resources[]` to mount it as a directory the agent can read and write.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryStore
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryStoreType Type { get; set; }

        /// <summary>
        /// Unique identifier for the memory store (a `memstore_...` tagged ID). Use this when attaching the store to a session, or in the `{memory_store_id}` path parameter of subsequent calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name for the store. 1–255 characters. The store's mount-path slug under `/mnt/memory/` is derived from this name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Free-text description of what the store contains, up to 1024 characters. Included in the agent's system prompt when the store is attached, so word it to be useful to the agent. Empty string when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Timestamp when the store was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the store's `name`, `description`, or `metadata` was last modified. Memory writes inside the store do not advance this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Arbitrary key-value tags for your own bookkeeping (such as the end user a store belongs to). Up to 16 pairs; keys 1–64 characters; values up to 512 characters. Returned on retrieve/list but not filterable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Timestamp when the store was archived, or `null` if active. Set once and never cleared; archiving is one-way. Archived stores are read-only and cannot be attached to new sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStore" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the memory store (a `memstore_...` tagged ID). Use this when attaching the store to a session, or in the `{memory_store_id}` path parameter of subsequent calls.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the store. 1–255 characters. The store's mount-path slug under `/mnt/memory/` is derived from this name.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the store was created.
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the store's `name`, `description`, or `metadata` was last modified. Memory writes inside the store do not advance this.
        /// </param>
        /// <param name="type"></param>
        /// <param name="description">
        /// Free-text description of what the store contains, up to 1024 characters. Included in the agent's system prompt when the store is attached, so word it to be useful to the agent. Empty string when unset.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary key-value tags for your own bookkeeping (such as the end user a store belongs to). Up to 16 pairs; keys 1–64 characters; values up to 512 characters. Returned on retrieve/list but not filterable.
        /// </param>
        /// <param name="archivedAt">
        /// Timestamp when the store was archived, or `null` if active. Set once and never cleared; archiving is one-way. Archived stores are read-only and cannot be attached to new sessions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryStore(
            string id,
            string name,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaManagedAgentsMemoryStoreType type,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.DateTime? archivedAt)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStore" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryStore()
        {
        }
    }
}