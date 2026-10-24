
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The memory store that holds a dream's result, as an entry in `outputs`.
    /// </summary>
    public sealed partial class BetaDreamMemoryStoreOutput
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"memory_store"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "memory_store";

        /// <summary>
        /// The ID of the memory store that the dream writes its result to (`memstore_...`).<br/>
        /// With `output_behavior` set to `create_new`, this is a new memory store. With `update_existing`, it is the input memory store.
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
        /// Initializes a new instance of the <see cref="BetaDreamMemoryStoreOutput" /> class.
        /// </summary>
        /// <param name="memoryStoreId">
        /// The ID of the memory store that the dream writes its result to (`memstore_...`).<br/>
        /// With `output_behavior` set to `create_new`, this is a new memory store. With `update_existing`, it is the input memory store.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamMemoryStoreOutput(
            string memoryStoreId,
            string type = "memory_store")
        {
            this.Type = type;
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamMemoryStoreOutput" /> class.
        /// </summary>
        public BetaDreamMemoryStoreOutput()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDreamMemoryStoreOutput"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDreamMemoryStoreOutput FromMemoryStoreId(string memoryStoreId)
        {
            return new BetaDreamMemoryStoreOutput
            {
                MemoryStoreId = memoryStoreId,
            };
        }

    }
}