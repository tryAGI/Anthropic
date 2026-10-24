
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation that a `memory_store` was deleted.
    /// </summary>
    public sealed partial class BetaManagedAgentsDeletedMemoryStore
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory_store_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_store_deleted";

        /// <summary>
        /// ID of the deleted memory store (a `memstore_...` identifier). The store and all its memories and versions are no longer retrievable.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedMemoryStore" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted memory store (a `memstore_...` identifier). The store and all its memories and versions are no longer retrievable.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDeletedMemoryStore(
            string id,
            string type = "memory_store_deleted")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDeletedMemoryStore" /> class.
        /// </summary>
        public BetaManagedAgentsDeletedMemoryStore()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsDeletedMemoryStore"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsDeletedMemoryStore FromId(string id)
        {
            return new BetaManagedAgentsDeletedMemoryStore
            {
                Id = id,
            };
        }

    }
}