
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaClearThinking20251015
    {
        /// <summary>
        /// Number of most recent assistant turns to keep thinking blocks for. Older turns will have their thinking blocks removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.KeepVariant1?, global::Anthropic.BetaClearThinking20251015Keep?>))]
        public global::Anthropic.AnyOf<global::Anthropic.KeepVariant1?, global::Anthropic.BetaClearThinking20251015Keep?>? Keep { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaClearThinking20251015TypeJsonConverter))]
        public global::Anthropic.BetaClearThinking20251015Type Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClearThinking20251015" /> class.
        /// </summary>
        /// <param name="keep">
        /// Number of most recent assistant turns to keep thinking blocks for. Older turns will have their thinking blocks removed.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClearThinking20251015(
            global::Anthropic.AnyOf<global::Anthropic.KeepVariant1?, global::Anthropic.BetaClearThinking20251015Keep?>? keep,
            global::Anthropic.BetaClearThinking20251015Type type)
        {
            this.Keep = keep;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClearThinking20251015" /> class.
        /// </summary>
        public BetaClearThinking20251015()
        {
        }
    }
}