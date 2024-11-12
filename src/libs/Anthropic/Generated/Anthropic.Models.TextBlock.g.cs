
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A block of text content.
    /// </summary>
    public sealed partial class TextBlock
    {
        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: text
        /// </summary>
        /// <default>global::Anthropic.TextBlockType.Text</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.TextBlockTypeJsonConverter))]
        public global::Anthropic.TextBlockType Type { get; set; } = global::Anthropic.TextBlockType.Text;

        /// <summary>
        /// The cache control settings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBlock" /> class.
        /// </summary>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: text
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TextBlock(
            string text,
            global::Anthropic.CacheControlEphemeral? cacheControl,
            global::Anthropic.TextBlockType type = global::Anthropic.TextBlockType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextBlock" /> class.
        /// </summary>
        public TextBlock()
        {
        }
    }
}