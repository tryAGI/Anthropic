
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseTextBlock
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        /// <default>global::Anthropic.ResponseTextBlockType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResponseTextBlockTypeJsonConverter))]
        public global::Anthropic.ResponseTextBlockType Type { get; set; } = global::Anthropic.ResponseTextBlockType.Text;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Citations supporting the text block.<br/>
        /// The type of citation returned will depend on the type of document being cited. Citing a PDF results in `page_location`, plain text results in `char_location`, and content document results in `content_block_location`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsItem4>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="text"></param>
        /// <param name="citations">
        /// Citations supporting the text block.<br/>
        /// The type of citation returned will depend on the type of document being cited. Citing a PDF results in `page_location`, plain text results in `char_location`, and content document results in `content_block_location`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ResponseTextBlock(
            string text,
            global::System.Collections.Generic.IList<global::Anthropic.CitationsItem4>? citations,
            global::Anthropic.ResponseTextBlockType type = global::Anthropic.ResponseTextBlockType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.Citations = citations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseTextBlock" /> class.
        /// </summary>
        public ResponseTextBlock()
        {
        }
    }
}