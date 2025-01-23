
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseContentBlockLocationCitation
    {
        /// <summary>
        /// Default Value: content_block_location
        /// </summary>
        /// <default>global::Anthropic.BetaResponseContentBlockLocationCitationType.ContentBlockLocation</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseContentBlockLocationCitationTypeJsonConverter))]
        public global::Anthropic.BetaResponseContentBlockLocationCitationType Type { get; set; } = global::Anthropic.BetaResponseContentBlockLocationCitationType.ContentBlockLocation;

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
        [global::System.Text.Json.Serialization.JsonPropertyName("start_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartBlockIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_block_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndBlockIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseContentBlockLocationCitation" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: content_block_location
        /// </param>
        /// <param name="citedText"></param>
        /// <param name="documentIndex"></param>
        /// <param name="documentTitle"></param>
        /// <param name="startBlockIndex"></param>
        /// <param name="endBlockIndex"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaResponseContentBlockLocationCitation(
            string citedText,
            int documentIndex,
            string? documentTitle,
            int startBlockIndex,
            int endBlockIndex,
            global::Anthropic.BetaResponseContentBlockLocationCitationType type = global::Anthropic.BetaResponseContentBlockLocationCitationType.ContentBlockLocation)
        {
            this.CitedText = citedText ?? throw new global::System.ArgumentNullException(nameof(citedText));
            this.DocumentIndex = documentIndex;
            this.DocumentTitle = documentTitle ?? throw new global::System.ArgumentNullException(nameof(documentTitle));
            this.StartBlockIndex = startBlockIndex;
            this.EndBlockIndex = endBlockIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseContentBlockLocationCitation" /> class.
        /// </summary>
        public BetaResponseContentBlockLocationCitation()
        {
        }
    }
}