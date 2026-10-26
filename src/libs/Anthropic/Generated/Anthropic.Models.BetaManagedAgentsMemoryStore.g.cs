
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
        /// <default>"memory_store"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_store";

        /// <summary>
        /// The unique ID of the memory store (`memstore_...`). Use it to attach the store to a session.
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
        /// Free-text description of what the store contains, up to 1,024 characters. Included in the agent's system prompt when the store is attached, so word it to be useful to the agent. Empty string when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// When the memory store was created, in RFC 3339.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the memory store was last changed, in RFC 3339.<br/>
        /// Changing its `name`, `description`, or `metadata` updates it. Archiving the store does too. Changes to the store's memories don't.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Key-value pairs for your own use, such as the end user that the store belongs to.<br/>
        /// A store has at most 16 pairs. Keys are 1 to 64 characters long and values at most 512 characters. You can't filter lists by metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// When the memory store was archived, in RFC 3339, or `null` if it hasn't been.<br/>
        /// Archiving can't be undone. An archived store can't be attached to new sessions. You can't create or update its memories or update the store. You can still read and delete its memories, redact their versions, and delete the store.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#archive-a-store) to learn more about archiving.
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
        /// The unique ID of the memory store (`memstore_...`). Use it to attach the store to a session.
        /// </param>
        /// <param name="name">
        /// Human-readable name for the store. 1–255 characters. The store's mount-path slug under `/mnt/memory/` is derived from this name.
        /// </param>
        /// <param name="description">
        /// Free-text description of what the store contains, up to 1,024 characters. Included in the agent's system prompt when the store is attached, so word it to be useful to the agent. Empty string when unset.
        /// </param>
        /// <param name="createdAt">
        /// When the memory store was created, in RFC 3339.
        /// </param>
        /// <param name="updatedAt">
        /// When the memory store was last changed, in RFC 3339.<br/>
        /// Changing its `name`, `description`, or `metadata` updates it. Archiving the store does too. Changes to the store's memories don't.
        /// </param>
        /// <param name="metadata">
        /// Key-value pairs for your own use, such as the end user that the store belongs to.<br/>
        /// A store has at most 16 pairs. Keys are 1 to 64 characters long and values at most 512 characters. You can't filter lists by metadata.
        /// </param>
        /// <param name="archivedAt">
        /// When the memory store was archived, in RFC 3339, or `null` if it hasn't been.<br/>
        /// Archiving can't be undone. An archived store can't be attached to new sessions. You can't create or update its memories or update the store. You can still read and delete its memories, redact their versions, and delete the store.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#archive-a-store) to learn more about archiving.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryStore(
            string id,
            string name,
            string description,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            global::System.DateTime? archivedAt,
            string type = "memory_store")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
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