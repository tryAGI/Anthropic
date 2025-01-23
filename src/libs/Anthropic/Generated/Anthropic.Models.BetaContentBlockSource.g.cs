
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaContentBlockSourceTypeJsonConverter))]
        public global::Anthropic.BetaContentBlockSourceType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="content"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaContentBlockSource(
            global::Anthropic.AnyOf<string, global::System.Collections.Generic.IList<global::Anthropic.ContentVariant2Item>> content,
            global::Anthropic.BetaContentBlockSourceType type)
        {
            this.Content = content;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockSource" /> class.
        /// </summary>
        public BetaContentBlockSource()
        {
        }
    }
}