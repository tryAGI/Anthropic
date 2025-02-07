
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestTextBlock
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.BetaCacheControlEphemeral? CacheControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citations")]
        public global::System.Collections.Generic.IList<global::Anthropic.CitationsItem>? Citations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestTextBlockTypeJsonConverter))]
        public global::Anthropic.BetaRequestTextBlockType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextBlock" /> class.
        /// </summary>
        /// <param name="cacheControl"></param>
        /// <param name="citations"></param>
        /// <param name="text"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestTextBlock(
            string text,
            global::Anthropic.BetaCacheControlEphemeral? cacheControl,
            global::System.Collections.Generic.IList<global::Anthropic.CitationsItem>? citations,
            global::Anthropic.BetaRequestTextBlockType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CacheControl = cacheControl;
            this.Citations = citations;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestTextBlock" /> class.
        /// </summary>
        public BetaRequestTextBlock()
        {
        }
    }
}