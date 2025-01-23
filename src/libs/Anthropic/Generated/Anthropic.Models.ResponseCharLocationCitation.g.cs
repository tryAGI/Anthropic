
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseCharLocationCitation
    {
        /// <summary>
        /// Default Value: char_location
        /// </summary>
        /// <default>global::Anthropic.ResponseCharLocationCitationType.CharLocation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResponseCharLocationCitationTypeJsonConverter))]
        public global::Anthropic.ResponseCharLocationCitationType Type { get; set; } = global::Anthropic.ResponseCharLocationCitationType.CharLocation;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cited_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CitedText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DocumentIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DocumentTitle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_char_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartCharIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_char_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndCharIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCharLocationCitation" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: char_location
        /// </param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startCharIndex"></param>
        /// <param name="endCharIndex"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ResponseCharLocationCitation(
            string citedText,
            int documentIndex,
            string? documentTitle,
            int startCharIndex,
            int endCharIndex,
            global::Anthropic.ResponseCharLocationCitationType type = global::Anthropic.ResponseCharLocationCitationType.CharLocation)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle ?? throw new global::System.ArgumentNullException(nameof(documentTitle));
            this.StartCharIndex = startCharIndex;
            this.EndCharIndex = endCharIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCharLocationCitation" /> class.
        /// </summary>
        public ResponseCharLocationCitation()
        {
        }
    }
}