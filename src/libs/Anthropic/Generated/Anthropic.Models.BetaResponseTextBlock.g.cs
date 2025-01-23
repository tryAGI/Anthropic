
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaResponseTextBlock
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        /// <default>global::Anthropic.BetaResponseTextBlockType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseTextBlockTypeJsonConverter))]
        public global::Anthropic.BetaResponseTextBlockType Type { get; set; } = global::Anthropic.BetaResponseTextBlockType.Text;

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.CitationsItem2>? Citations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextBlock" /> class.
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
        public BetaResponseTextBlock(
            string text,
            global::System.Collections.Generic.IList<global::Anthropic.CitationsItem2>? citations,
            global::Anthropic.BetaResponseTextBlockType type = global::Anthropic.BetaResponseTextBlockType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Citations = citations ?? throw new global::System.ArgumentNullException(nameof(citations));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseTextBlock" /> class.
        /// </summary>
        public BetaResponseTextBlock()
        {
        }
    }
}