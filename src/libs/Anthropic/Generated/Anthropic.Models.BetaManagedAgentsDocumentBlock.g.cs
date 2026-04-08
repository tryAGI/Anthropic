
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Document content, either specified directly as base64 data, as text, or as a reference via a URL.
    /// </summary>
    public sealed partial class BetaManagedAgentsDocumentBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentBlockTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsDocumentBlockType Type { get; set; }

        /// <summary>
        /// The source of the document data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsDocumentSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsDocumentSource Source { get; set; }

        /// <summary>
        /// The title of the document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// Additional context about the document for the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context")]
        public string? Context { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDocumentBlock" /> class.
        /// </summary>
        /// <param name="source">
        /// The source of the document data.
        /// </param>
        /// <param name="type"></param>
        /// <param name="title">
        /// The title of the document.
        /// </param>
        /// <param name="context">
        /// Additional context about the document for the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsDocumentBlock(
            global::Anthropic.BetaManagedAgentsDocumentSource source,
            global::Anthropic.BetaManagedAgentsDocumentBlockType type,
            string? title,
            string? context)
        {
            this.Type = type;
            this.Source = source;
            this.Title = title;
            this.Context = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsDocumentBlock" /> class.
        /// </summary>
        public BetaManagedAgentsDocumentBlock()
        {
        }
    }
}