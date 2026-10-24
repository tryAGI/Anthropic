
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The memory store that a dream reads, given as an entry in `inputs`.<br/>
    /// With `output_behavior` set to `update_existing`, the dream writes its result into this memory store. Otherwise the dream doesn't change it.
    /// </summary>
    public sealed partial class BetaDreamMemoryStoreInput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory_store"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_store";

        /// <summary>
        /// The ID of the memory store for the dream to read (`memstore_...`).<br/>
        /// The memory store must be in the same workspace as the dream and must not be archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_store_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MemoryStoreId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamMemoryStoreInput" /> class.
        /// </summary>
        /// <param name="memoryStoreId">
        /// The ID of the memory store for the dream to read (`memstore_...`).<br/>
        /// The memory store must be in the same workspace as the dream and must not be archived.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamMemoryStoreInput(
            string memoryStoreId,
            string type = "memory_store")
        {
            this.Type = type;
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamMemoryStoreInput" /> class.
        /// </summary>
        public BetaDreamMemoryStoreInput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDreamMemoryStoreInput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDreamMemoryStoreInput FromMemoryStoreId(string memoryStoreId)
        {
            return new BetaDreamMemoryStoreInput
            {
                MemoryStoreId = memoryStoreId,
            };
        }

    }
}