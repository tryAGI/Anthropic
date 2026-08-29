
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The job writes the consolidated memories into this existing memory store instead of creating one. In EAP the store must be the job's own memory_store input, so the job consolidates the store in place.
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
        /// Initializes a new instance of the <see cref="BetaOutputBehaviorUpdateExisting" /> class.
        /// </summary>
        /// <param name="memoryStoreId"></param>
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