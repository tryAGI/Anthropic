
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseDocumentBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaResponseCitationsConfig Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Source3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Source3 Source { get; set; }

        /// <summary>
        /// The title of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Title { get; set; }

        /// <summary>
        /// Default Value: document
        /// </summary>
        /// <default>global::Anthropic.BetaResponseDocumentBlockType.Document</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseDocumentBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseDocumentBlockType Type { get; set; } = global::Anthropic.BetaResponseDocumentBlockType.Document;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseDocumentBlock" /> class.
        /// </summary>
        /// <param name="citations"></param>
        /// <param name="source"></param>
        /// <param name="title">
        /// The title of the document
        /// </param>
        /// <param name="type">
        /// Default Value: document
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseDocumentBlock(
            global::Anthropic.BetaResponseCitationsConfig citations,
            global::Anthropic.Source3 source,
            string? title,
            global::Anthropic.BetaResponseDocumentBlockType type = global::Anthropic.BetaResponseDocumentBlockType.Document)
        {
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.Source = source;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseDocumentBlock" /> class.
        /// </summary>
        public BetaResponseDocumentBlock()
        {
        }
    }
}