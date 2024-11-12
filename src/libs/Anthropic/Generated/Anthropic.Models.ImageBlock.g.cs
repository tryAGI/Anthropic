
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A block of image content.
    /// </summary>
    public sealed partial class ImageBlock
    {
        /// <summary>
        /// The source of an image block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.ImageBlockSource Source { get; set; }

        /// <summary>
        /// The type of content block.<br/>
        /// Default Value: image
        /// </summary>
        /// <default>global::Anthropic.ImageBlockType.Image</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ImageBlockTypeJsonConverter))]
        public global::Anthropic.ImageBlockType Type { get; set; } = global::Anthropic.ImageBlockType.Image;

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
        /// Initializes a new instance of the <see cref="ImageBlock" /> class.
        /// </summary>
        /// <param name="source">
        /// The source of an image block.
        /// </param>
        /// <param name="type">
        /// The type of content block.<br/>
        /// Default Value: image
        /// </param>
        /// <param name="cacheControl">
        /// The cache control settings.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageBlock(
            global::Anthropic.ImageBlockSource source,
            global::Anthropic.CacheControlEphemeral? cacheControl,
            global::Anthropic.ImageBlockType type = global::Anthropic.ImageBlockType.Image)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
            this.CacheControl = cacheControl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageBlock" /> class.
        /// </summary>
        public ImageBlock()
        {
        }
    }
}