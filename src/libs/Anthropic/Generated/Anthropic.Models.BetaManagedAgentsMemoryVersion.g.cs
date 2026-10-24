
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One entry in a memory's history, recording a single change and who made it.<br/>
    /// Every change to a memory adds one version. Only redaction can change a version after that. Versions belong to the memory store and stay after the memory is deleted. Each version is retained for at least the version retention period after it was written, unless the store itself is deleted.<br/>
    /// Retrieving a redacted version succeeds, with `content`, `path`, `content_size_bytes`, and `content_sha256` set to `null`. Check `redacted_at` to find out whether a version was redacted.<br/>
    /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#audit-memory-changes) to learn more about memory versions.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryVersion
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory_version"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_version";

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
        /// The ID of the memory that this version belongs to (`mem_...`).<br/>
        /// The ID stays valid after the memory is deleted. Pass it as `memory_id` to [List Memory Versions](https://platform.claude.com/docs/en/api/beta/memory_stores/memory_versions/list) to get the memory's retained versions, including its `deleted` version while the lineage is retained.
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
        /// Who made this change to the memory, or `null` if the author wasn't recorded.<br/>
        /// Redacting the version doesn't change this field. A `session_actor` here is an agent that wrote through the store's mounted filesystem at `/mnt/memory/`. The version doesn't record the API key that created that session. So the author in `created_by` is who made the change, not who is ultimately responsible for it.<br/>
        /// You can [retrieve the session](https://platform.claude.com/docs/en/api/beta/sessions/retrieve) to learn more about where the change came from.
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
        /// When the version was redacted, in RFC 3339, or `null` if it hasn't been.<br/>
        /// When set, `content`, `path`, `content_size_bytes`, and `content_sha256` are `null`.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#redact-a-version) to learn more about redaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redacted_at")]
        public global::System.DateTime? RedactedAt { get; set; }

        /// <summary>
        /// Who redacted this version, or `null` if it has not been redacted. In practice always an `api_actor`, `user_actor`, or `service_account_actor` (agents do not have a redact capability).
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
        /// The ID of the memory that this version belongs to (`mem_...`).<br/>
        /// The ID stays valid after the memory is deleted. Pass it as `memory_id` to [List Memory Versions](https://platform.claude.com/docs/en/api/beta/memory_stores/memory_versions/list) to get the memory's retained versions, including its `deleted` version while the lineage is retained.
        /// </param>
        /// <param name="operation">
        /// The kind of mutation this version records: `created`, `modified`, or `deleted`.
        /// </param>
        /// <param name="createdAt">
        /// When this version was written, in RFC 3339 format.
        /// </param>
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
        /// Who made this change to the memory, or `null` if the author wasn't recorded.<br/>
        /// Redacting the version doesn't change this field. A `session_actor` here is an agent that wrote through the store's mounted filesystem at `/mnt/memory/`. The version doesn't record the API key that created that session. So the author in `created_by` is who made the change, not who is ultimately responsible for it.<br/>
        /// You can [retrieve the session](https://platform.claude.com/docs/en/api/beta/sessions/retrieve) to learn more about where the change came from.
        /// </param>
        /// <param name="redactedAt">
        /// When the version was redacted, in RFC 3339, or `null` if it hasn't been.<br/>
        /// When set, `content`, `path`, `content_size_bytes`, and `content_sha256` are `null`.<br/>
        /// See the [memory guide](https://platform.claude.com/docs/en/managed-agents/memory#redact-a-version) to learn more about redaction.
        /// </param>
        /// <param name="redactedBy">
        /// Who redacted this version, or `null` if it has not been redacted. In practice always an `api_actor`, `user_actor`, or `service_account_actor` (agents do not have a redact capability).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryVersion(
            string id,
            string memoryStoreId,
            string memoryId,
            global::Anthropic.BetaManagedAgentsMemoryVersionOperation operation,
            global::System.DateTime createdAt,
            string? path,
            string? content,
            int? contentSizeBytes,
            string? contentSha256,
            global::Anthropic.BetaManagedAgentsActor? createdBy,
            global::System.DateTime? redactedAt,
            global::Anthropic.BetaManagedAgentsActor? redactedBy,
            string type = "memory_version")
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