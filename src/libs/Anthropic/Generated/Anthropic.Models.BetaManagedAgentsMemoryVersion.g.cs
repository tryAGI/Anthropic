
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A `memory_version` object: one immutable, attributed row in a memory's append-only history. Every non-no-op mutation to a memory produces a new version. Versions belong to the store (not the individual memory) and persist after the memory is deleted. Retrieving a redacted version returns 200 with `content`, `path`, `content_size_bytes`, and `content_sha256` set to `null`; branch on `redacted_at`, not HTTP status.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryVersion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryVersionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryVersionType Type { get; set; }

        /// <summary>
        /// Unique identifier for this version (a `memver_...` value).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the memory store this version belongs to (a `memstore_...` value).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryStoreId { get; set; }

        /// <summary>
        /// ID of the memory this version snapshots (a `mem_...` value). Remains valid after the memory is deleted; pass it as `memory_id` to [List memory versions](/en/api/beta/memory_stores/memory_versions/list) to retrieve the full lineage including the `deleted` row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryId { get; set; }

        /// <summary>
        /// The memory's path at the time of this write. `null` if and only if `redacted_at` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// The kind of mutation this version records: `created`, `modified`, or `deleted`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryVersionOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsMemoryVersionOperation Operation { get; set; }

        /// <summary>
        /// The memory's UTF-8 text content as of this version. `null` when `view=basic`, when `operation` is `deleted`, or when `redacted_at` is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Size of `content` in bytes as of this version. `null` when `redacted_at` is set or `operation` is `deleted`. Populated regardless of `view` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_size_bytes")]
        public int? ContentSizeBytes { get; set; }

        /// <summary>
        /// Lowercase hex SHA-256 digest of `content` as of this version (64 characters). `null` when `redacted_at` is set or `operation` is `deleted`. Populated regardless of `view` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_sha256")]
        public string? ContentSha256 { get; set; }

        /// <summary>
        /// Who performed this write: a `session_actor`, `api_actor`, or `user_actor`. Captured at write time and preserved through redaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsActorJsonConverter))]
        public global::Anthropic.BetaManagedAgentsActor? CreatedBy { get; set; }

        /// <summary>
        /// When this version was written, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// When this version was redacted, in RFC 3339 format, or `null` if it has not been redacted. When set, `content`, `path`, `content_size_bytes`, and `content_sha256` are all `null`. See [Redact a memory version](/en/api/beta/memory_stores/memory_versions/redact).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_at")]
        public global::System.DateTime? RedactedAt { get; set; }

        /// <summary>
        /// Who redacted this version, or `null` if it has not been redacted. In practice always an `api_actor` or `user_actor` (agents do not have a redact capability).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsActorJsonConverter))]
        public global::Anthropic.BetaManagedAgentsActor? RedactedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryVersion" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for this version (a `memver_...` value).
        /// </param>
        /// <param name="memoryStoreId">
        /// ID of the memory store this version belongs to (a `memstore_...` value).
        /// </param>
        /// <param name="memoryId">
        /// ID of the memory this version snapshots (a `mem_...` value). Remains valid after the memory is deleted; pass it as `memory_id` to [List memory versions](/en/api/beta/memory_stores/memory_versions/list) to retrieve the full lineage including the `deleted` row.
        /// </param>
        /// <param name="operation">
        /// The kind of mutation this version records: `created`, `modified`, or `deleted`.
        /// </param>
        /// <param name="createdAt">
        /// When this version was written, in RFC 3339 format.
        /// </param>
        /// <param name="type"></param>
        /// <param name="path">
        /// The memory's path at the time of this write. `null` if and only if `redacted_at` is set.
        /// </param>
        /// <param name="content">
        /// The memory's UTF-8 text content as of this version. `null` when `view=basic`, when `operation` is `deleted`, or when `redacted_at` is set.
        /// </param>
        /// <param name="contentSizeBytes">
        /// Size of `content` in bytes as of this version. `null` when `redacted_at` is set or `operation` is `deleted`. Populated regardless of `view` otherwise.
        /// </param>
        /// <param name="contentSha256">
        /// Lowercase hex SHA-256 digest of `content` as of this version (64 characters). `null` when `redacted_at` is set or `operation` is `deleted`. Populated regardless of `view` otherwise.
        /// </param>
        /// <param name="createdBy">
        /// Who performed this write: a `session_actor`, `api_actor`, or `user_actor`. Captured at write time and preserved through redaction.
        /// </param>
        /// <param name="redactedAt">
        /// When this version was redacted, in RFC 3339 format, or `null` if it has not been redacted. When set, `content`, `path`, `content_size_bytes`, and `content_sha256` are all `null`. See [Redact a memory version](/en/api/beta/memory_stores/memory_versions/redact).
        /// </param>
        /// <param name="redactedBy">
        /// Who redacted this version, or `null` if it has not been redacted. In practice always an `api_actor` or `user_actor` (agents do not have a redact capability).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryVersion(
            string id,
            string memoryStoreId,
            string memoryId,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation operation,
            global::System.DateTime createdAt,
            global::Anthropic.BetaManagedAgentsMemoryVersionType type,
            string? path,
            string? content,
            int? contentSizeBytes,
            string? contentSha256,
            global::Anthropic.BetaManagedAgentsActor? createdBy,
            global::System.DateTime? redactedAt,
            global::Anthropic.BetaManagedAgentsActor? redactedBy)
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
            this.MemoryId = memoryId ?? throw new global::System.ArgumentNullException(nameof(memoryId));
            this.Path = path;
            this.Operation = operation;
            this.Content = content;
            this.ContentSizeBytes = contentSizeBytes;
            this.ContentSha256 = contentSha256;
            this.CreatedBy = createdBy;
            this.CreatedAt = createdAt;
            this.RedactedAt = redactedAt;
            this.RedactedBy = redactedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryVersion" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryVersion()
        {
        }
    }
}