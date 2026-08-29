
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The default destination: the job creates a new output memory store as a clone of the memory_store input and writes the consolidated memories into it. The input store is never mutated.
    /// </summary>
    public sealed partial class BetaOutputBehaviorCreateNew
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaOutputBehaviorCreateNewTypeJsonConverter))]
        public global::Anthropic.BetaOutputBehaviorCreateNewType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputBehaviorCreateNew" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOutputBehaviorCreateNew(
            global::Anthropic.BetaOutputBehaviorCreateNewType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOutputBehaviorCreateNew" /> class.
        /// </summary>
        public BetaOutputBehaviorCreateNew()
        {
        }

    }
}