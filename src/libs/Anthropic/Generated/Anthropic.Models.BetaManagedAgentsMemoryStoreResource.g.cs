
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A memory store attached to an agent session.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryStoreResource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreResourceTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceType Type { get; set; }

        /// <summary>
        /// The memory store ID (memstore_...). Must belong to the caller's organization and workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryStoreId { get; set; }

        /// <summary>
        /// Access mode for the mounted store. Defaults to read_write. read_only mounts the store as a read-only filesystem.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMountModeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMountMode? Access { get; set; }

        /// <summary>
        /// Display name of the memory store, snapshotted at attach time. Later edits to the store's name do not propagate to this resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the memory store, snapshotted at attach time. Rendered into the agent's system prompt. Empty string when the store has no description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Per-attachment guidance for the agent on how to use this store. Rendered into the memory section of the system prompt. Max 4096 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Filesystem path where the store is mounted in the session container, e.g. /mnt/memory/user-preferences. Derived from the store's name. Output-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        public string? MountPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStoreResource" /> class.
        /// </summary>
        /// <param name="memoryStoreId">
        /// The memory store ID (memstore_...). Must belong to the caller's organization and workspace.
        /// </param>
        /// <param name="type"></param>
        /// <param name="access">
        /// Access mode for the mounted store. Defaults to read_write. read_only mounts the store as a read-only filesystem.
        /// </param>
        /// <param name="name">
        /// Display name of the memory store, snapshotted at attach time. Later edits to the store's name do not propagate to this resource.
        /// </param>
        /// <param name="description">
        /// Description of the memory store, snapshotted at attach time. Rendered into the agent's system prompt. Empty string when the store has no description.
        /// </param>
        /// <param name="instructions">
        /// Per-attachment guidance for the agent on how to use this store. Rendered into the memory section of the system prompt. Max 4096 chars.
        /// </param>
        /// <param name="mountPath">
        /// Filesystem path where the store is mounted in the session container, e.g. /mnt/memory/user-preferences. Derived from the store's name. Output-only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryStoreResource(
            string memoryStoreId,
            global::Anthropic.BetaManagedAgentsMemoryStoreResourceType type,
            global::Anthropic.BetaManagedAgentsMountMode? access,
            string? name,
            string? description,
            string? instructions,
            string? mountPath)
        {
            this.Type = type;
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
            this.Access = access;
            this.Name = name;
            this.Description = description;
            this.Instructions = instructions;
            this.MountPath = mountPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStoreResource" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryStoreResource()
        {
        }
    }
}