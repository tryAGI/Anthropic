
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCitationsDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CitationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Citation Citation { get; set; }

        /// <summary>
        /// Default Value: citations_delta
        /// </summary>
        /// <default>global::Anthropic.BetaCitationsDeltaType.CitationsDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaCitationsDeltaTypeJsonConverter))]
        public global::Anthropic.BetaCitationsDeltaType Type { get; set; } = global::Anthropic.BetaCitationsDeltaType.CitationsDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCitationsDelta" /> class.
        /// </summary>
        /// <param name="citation"></param>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCitationsDelta(
            global::Anthropic.Citation citation,
            global::Anthropic.BetaCitationsDeltaType type = global::Anthropic.BetaCitationsDeltaType.CitationsDelta)
        {
            this.Citation = citation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCitationsDelta" /> class.
        /// </summary>
        public BetaCitationsDelta()
        {
        }
    }
}