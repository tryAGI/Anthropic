
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CitationsDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Citation2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Citation2 Citation { get; set; }

        /// <summary>
        /// Default Value: citations_delta
        /// </summary>
        /// <default>"citations_delta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "citations_delta";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationsDelta" /> class.
        /// </summary>
        /// <param name="citation"></param>
        /// <param name="type">
        /// Default Value: citations_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CitationsDelta(
            global::Anthropic.Citation2 citation,
            string type = "citations_delta")
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