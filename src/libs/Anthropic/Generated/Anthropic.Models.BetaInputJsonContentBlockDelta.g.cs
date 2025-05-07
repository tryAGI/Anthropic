
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaInputJsonContentBlockDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_json")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PartialJson { get; set; }

        /// <summary>
        /// Default Value: input_json_delta
        /// </summary>
        /// <default>global::Anthropic.BetaInputJsonContentBlockDeltaType.InputJsonDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaInputJsonContentBlockDeltaTypeJsonConverter))]
        public global::Anthropic.BetaInputJsonContentBlockDeltaType Type { get; set; } = global::Anthropic.BetaInputJsonContentBlockDeltaType.InputJsonDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputJsonContentBlockDelta" /> class.
        /// </summary>
        /// <param name="partialJson"></param>
        /// <param name="type">
        /// Default Value: input_json_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputJsonContentBlockDelta(
            string partialJson,
            global::Anthropic.BetaInputJsonContentBlockDeltaType type = global::Anthropic.BetaInputJsonContentBlockDeltaType.InputJsonDelta)
        {
            this.PartialJson = partialJson ?? throw new global::System.ArgumentNullException(nameof(partialJson));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputJsonContentBlockDelta" /> class.
        /// </summary>
        public BetaInputJsonContentBlockDelta()
        {
        }
    }
}