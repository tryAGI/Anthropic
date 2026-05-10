
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Tombstone returned by [Delete a memory](/en/api/beta/memory_stores/memories/delete). The memory's version history persists and remains listable via [List memory versions](/en/api/beta/memory_stores/memory_versions/list) until the store itself is deleted.
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