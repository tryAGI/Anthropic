
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A block containing a web search result.
    /// </summary>
    public sealed partial class BetaManagedAgentsSearchResultBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSearchResultBlockTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSearchResultBlockType Type { get; set; }

        /// <summary>
        /// The URL source of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// The title of the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Array of text content blocks from the search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent> Content { get; set; }

        /// <summary>
        /// Citation settings for this search result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsSearchResultCitations Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSearchResultBlock" /> class.
        /// </summary>
        /// <param name="source">
        /// The URL source of the search result.
        /// </param>
        /// <param name="title">
        /// The title of the search result.
        /// </param>
        /// <param name="content">
        /// Array of text content blocks from the search result.
        /// </param>
        /// <param name="citations">
        /// Citation settings for this search result.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSearchResultBlock(
            string source,
            string title,
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSearchResultContent> content,
            global::Anthropic.BetaManagedAgentsSearchResultCitations citations,
            global::Anthropic.BetaManagedAgentsSearchResultBlockType type)
        {
            this.Type = type;
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSearchResultBlock" /> class.
        /// </summary>
        public BetaManagedAgentsSearchResultBlock()
        {
        }

    }
}