
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationsDelta
    {
        /// <summary>
        /// Default Value: citations_delta
        /// </summary>
        /// <default>global::Anthropic.CitationsDeltaType.CitationsDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CitationsDeltaTypeJsonConverter))]
        public global::Anthropic.CitationsDeltaType Type { get; set; } = global::Anthropic.CitationsDeltaType.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Citation2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Citation2 Citation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationsDelta" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
        /// <param name="citation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CitationsDelta(
            global::Anthropic.Citation2 citation,
            global::Anthropic.CitationsDeltaType type = global::Anthropic.CitationsDeltaType.CitationsDelta)
        {
            this.Citation = citation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationsDelta" /> class.
        /// </summary>
        public CitationsDelta()
        {
        }
    }
}