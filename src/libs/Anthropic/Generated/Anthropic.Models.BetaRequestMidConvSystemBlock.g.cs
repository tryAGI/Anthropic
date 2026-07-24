
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// System instructions that appear mid-conversation.<br/>
    /// Use this block to provide or update system-level instructions at a specific<br/>
    /// point in the conversation, rather than only via the top-level `system` parameter.
    /// </summary>
    public sealed partial class BetaRequestMidConvSystemBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant125? CacheControl { get; set; }

        /// <summary>
        /// System instruction text blocks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.ContentItem> Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"mid_conv_system"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mid_conv_system";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMidConvSystemBlock" /> class.
        /// </summary>
        /// <param name="content">
        /// System instruction text blocks.
        /// </param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestMidConvSystemBlock(
            global::System.Collections.Generic.IList<global::Anthropic.ContentItem> content,
            global::Anthropic.CacheControlVariant125? cacheControl,
            string type = "mid_conv_system")
        {
            this.CacheControl = cacheControl;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMidConvSystemBlock" /> class.
        /// </summary>
        public BetaRequestMidConvSystemBlock()
        {
        }

    }
}