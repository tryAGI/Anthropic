
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Write the result into the input memory store instead of a new memory store.<br/>
    /// The credential must be allowed to write memory stores, or the request returns a 403 error. While another `update_existing` dream on the same memory store hasn't fully stopped, the request returns a 409 error.
    /// </summary>
    public sealed partial class BetaOutputBehaviorUpdateExisting
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOutputBehaviorUpdateExistingTypeJsonConverter))]
        public global::Anthropic.BetaOutputBehaviorUpdateExistingType Type { get; set; }

        /// <summary>
        /// The ID of the memory store for the dream to write its result to (`memstore_...`). It must be the memory store in the `memory_store` entry of `inputs`.
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
        /// Initializes a new instance of the <see cref="BetaOutputBehaviorUpdateExisting" /> class.
        /// </summary>
        /// <param name="memoryStoreId">
        /// The ID of the memory store for the dream to write its result to (`memstore_...`). It must be the memory store in the `memory_store` entry of `inputs`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOutputBehaviorUpdateExisting(
            string memoryStoreId,
            global::Anthropic.BetaOutputBehaviorUpdateExistingType type)
        {
            this.Type = type;
            this.MemoryStoreId = memoryStoreId ?? throw new global::System.ArgumentNullException(nameof(memoryStoreId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputBehaviorUpdateExisting" /> class.
        /// </summary>
        public BetaOutputBehaviorUpdateExisting()
        {
        }

    }
}