
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A `memory` object: a single text document at a hierarchical path inside a memory store. The `content` field is populated when `view=full` and `null` when `view=basic`; the `content_size_bytes` and `content_sha256` fields are always populated so sync clients can diff without fetching content. Memories are addressed by their `mem_...` ID; the path is the create key and can be changed via update.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryType Type { get; set; }

        /// <summary>
        /// Unique identifier for this memory (a `mem_...` value). Stable across renames; use this ID, not the path, to read, update, or delete the memory.
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
        /// The memory's UTF-8 text content. Populated when `view=full`; `null` when `view=basic`. Maximum 100 kB (102,400 bytes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Size of `content` in bytes (the UTF-8 plaintext length). Always populated, regardless of `view`.
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
        /// ID of the `memory_version` representing this memory's current content (a `memver_...` value). This is the authoritative head pointer; `memory_version` objects do not carry an `is_latest` flag, so compare against this field instead. Enumerate the full history via [List memory versions](/en/api/beta/memory_stores/memory_versions/list).
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
        /// When this memory was last modified, in RFC 3339 format. Use this as a cheap freshness signal; for who made the change, look up the head version's `created_by` via [List memory versions](/en/api/beta/memory_stores/memory_versions/list).
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
        /// Unique identifier for this memory (a `mem_...` value). Stable across renames; use this ID, not the path, to read, update, or delete the memory.
        /// </param>
        /// <param name="memoryStoreId">
        /// ID of the memory store this memory belongs to (a `memstore_...` value).
        /// </param>
        /// <param name="path">
        /// Hierarchical path of the memory within the store, e.g. `/projects/foo/notes.md`. Always starts with `/`. Paths are case-sensitive and unique within a store. Maximum 1,024 bytes.
        /// </param>
        /// <param name="contentSizeBytes">
        /// Size of `content` in bytes (the UTF-8 plaintext length). Always populated, regardless of `view`.
        /// </param>
        /// <param name="contentSha256">
        /// Lowercase hex SHA-256 digest of the UTF-8 `content` bytes (64 characters). The server applies no normalization, so clients can compute the same hash locally for staleness checks and as the value for a `content_sha256` precondition on update. Always populated, regardless of `view`.
        /// </param>
        /// <param name="memoryVersionId">
        /// ID of the `memory_version` representing this memory's current content (a `memver_...` value). This is the authoritative head pointer; `memory_version` objects do not carry an `is_latest` flag, so compare against this field instead. Enumerate the full history via [List memory versions](/en/api/beta/memory_stores/memory_versions/list).
        /// </param>
        /// <param name="createdAt">
        /// When this memory was created, in RFC 3339 format.
        /// </param>
        /// <param name="updatedAt">
        /// When this memory was last modified, in RFC 3339 format. Use this as a cheap freshness signal; for who made the change, look up the head version's `created_by` via [List memory versions](/en/api/beta/memory_stores/memory_versions/list).
        /// </param>
        /// <param name="type"></param>
        /// <param name="content">
        /// The memory's UTF-8 text content. Populated when `view=full`; `null` when `view=basic`. Maximum 100 kB (102,400 bytes).
        /// </param>
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
            global::Anthropic.BetaManagedAgentsMemoryType type,
            string? content)
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