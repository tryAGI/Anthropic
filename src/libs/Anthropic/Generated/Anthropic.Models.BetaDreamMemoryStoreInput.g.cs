
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An input memory store the dream reads from. The dream never mutates this store.
    /// </summary>
    public sealed partial class BetaDreamMemoryStoreInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaDreamMemoryStoreInputTypeJsonConverter))]
        public global::Anthropic.BetaDreamMemoryStoreInputType Type { get; set; }

        /// <summary>
        /// 
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
        /// <param name="memoryStoreId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamMemoryStoreInput(
            string memoryStoreId,
            global::Anthropic.BetaDreamMemoryStoreInputType type)
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

    }
}