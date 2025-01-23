
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestDocumentBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestDocumentBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestDocumentBlockType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Source Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::Anthropic.BetaRequestCitationsConfig? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestDocumentBlock" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="type"></param>
        /// <param name="source"></param>
        /// <param name="title"></param>
        /// <param name="context"></param>
        /// <param name="citations"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaRequestDocumentBlock(
            global::Anthropic.Source source,
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::Anthropic.BetaRequestDocumentBlockType type,
            string? title,
            string? context,
            global::Anthropic.BetaRequestCitationsConfig? citations)
        {
            this.Source = source;
            this.CacheControl = cacheControl;
            this.Type = type;
            this.Title = title;
            this.Context = context;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestDocumentBlock" /> class.
        /// </summary>
        public BetaRequestDocumentBlock()
        {
        }
    }
}