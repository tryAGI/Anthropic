
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for attaching a memory store to an agent session.
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryStoreResourceParam
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMemoryStoreResourceParamTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParamType Type { get; set; }

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
        /// Per-attachment guidance for the agent on how to use this store. Rendered into the memory section of the system prompt. Max 4096 chars.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStoreResourceParam" /> class.
        /// </summary>
        /// <param name="memoryStoreId">
        /// The memory store ID (memstore_...). Must belong to the caller's organization and workspace.
        /// </param>
        /// <param name="type"></param>
        /// <param name="access">
        /// Access mode for the mounted store. Defaults to read_write. read_only mounts the store as a read-only filesystem.
        /// </param>
        /// <param name="instructions">
        /// Per-attachment guidance for the agent on how to use this store. Rendered into the memory section of the system prompt. Max 4096 chars.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMemoryStoreResourceParam(
            string memoryStoreId,
            global::Anthropic.BetaManagedAgentsMemoryStoreResourceParamType type,
            global::Anthropic.BetaManagedAgentsMountMode? access,
            string? instructions)
        {
            this.Type = type;
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
            this.Access = access;
            this.Instructions = instructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMemoryStoreResourceParam" /> class.
        /// </summary>
        public BetaManagedAgentsMemoryStoreResourceParam()
        {
        }
    }
}