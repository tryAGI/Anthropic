
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A text document at a path inside a memory store.<br/>
    /// `content` is `null` when the response uses `view=basic`. `content_size_bytes` and `content_sha256` are always set, so you can detect changes without fetching the content. To retrieve, update, or delete a memory, pass its ID, which stays the same when its path changes.<br/>
    /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#view-and-edit-memories) to learn more about working with memories.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemory
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory";

        /// <summary>
        /// The unique ID of the memory (`mem_...`). It stays the same when the memory's path changes.<br/>
        /// To retrieve, update, or delete the memory, pass this ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the memory store this memory belongs to (a `memstore_...` value).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryStoreId { get; set; }

        /// <summary>
        /// Hierarchical path of the memory within the store, e.g. `/projects/foo/notes.md`. Always starts with `/`. Paths are case-sensitive and unique within a store. Maximum 1,024 bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The memory's UTF-8 text content, or `null` when the response uses `view=basic`.<br/>
        /// The maximum size is 100 kB (102,400 bytes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// The size of the memory's `content` in UTF-8 bytes. It is set regardless of `view`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentSizeBytes { get; set; }

        /// <summary>
        /// Lowercase hex SHA-256 digest of the UTF-8 `content` bytes (64 characters). The server applies no normalization, so clients can compute the same hash locally for staleness checks and as the value for a `content_sha256` precondition on update. Always populated, regardless of `view`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_sha256")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentSha256 { get; set; }

        /// <summary>
        /// The ID of the memory version that holds the memory's current content (`memver_...`).<br/>
        /// Memory versions don't have a flag that marks the latest one. Compare their IDs with this field instead.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#audit-memory-changes) to learn more about memory versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryVersionId { get; set; }

        /// <summary>
        /// When this memory was created, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When the memory was last changed, in RFC 3339.<br/>
        /// To find out who made the change, look at `created_by` on the memory version that `memory_version_id` references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemory" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the memory (`mem_...`). It stays the same when the memory's path changes.<br/>
        /// To retrieve, update, or delete the memory, pass this ID.
        /// </param>
        /// <param name="memoryStoreId">
        /// ID of the memory store this memory belongs to (a `memstore_...` value).
        /// </param>
        /// <param name="path">
        /// Hierarchical path of the memory within the store, e.g. `/projects/foo/notes.md`. Always starts with `/`. Paths are case-sensitive and unique within a store. Maximum 1,024 bytes.
        /// </param>
        /// <param name="contentSizeBytes">
        /// The size of the memory's `content` in UTF-8 bytes. It is set regardless of `view`.
        /// </param>
        /// <param name="contentSha256">
        /// Lowercase hex SHA-256 digest of the UTF-8 `content` bytes (64 characters). The server applies no normalization, so clients can compute the same hash locally for staleness checks and as the value for a `content_sha256` precondition on update. Always populated, regardless of `view`.
        /// </param>
        /// <param name="memoryVersionId">
        /// The ID of the memory version that holds the memory's current content (`memver_...`).<br/>
        /// Memory versions don't have a flag that marks the latest one. Compare their IDs with this field instead.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#audit-memory-changes) to learn more about memory versions.
        /// </param>
        /// <param name="createdAt">
        /// When this memory was created, in RFC 3339 format.
        /// </param>
        /// <param name="updatedAt">
        /// When the memory was last changed, in RFC 3339.<br/>
        /// To find out who made the change, look at `created_by` on the memory version that `memory_version_id` references.
        /// </param>
        /// <param name="content">
        /// The memory's UTF-8 text content, or `null` when the response uses `view=basic`.<br/>
        /// The maximum size is 100 kB (102,400 bytes).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemory(
            string id,
            string memoryStoreId,
            string path,
            int contentSizeBytes,
            string contentSha256,
            string memoryVersionId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? content,
            string type = "memory")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content;
            this.ContentSizeBytes = contentSizeBytes;
            this.ContentSha256 = contentSha256 ?? throw new global::System.ArgumentNullException(nameof(contentSha256));
            this.MemoryVersionId = memoryVersionId ?? throw new global::System.ArgumentNullException(nameof(memoryVersionId));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemory" /> class.
        /// </summary>
        public BetaManagedAgentsMemory()
        {
        }

    }
}