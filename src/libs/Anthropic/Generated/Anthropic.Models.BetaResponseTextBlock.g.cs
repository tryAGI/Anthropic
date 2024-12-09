
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaResponseTextBlock(
            string text,
            global::Anthropic.BetaResponseTextBlockType type = global::Anthropic.BetaResponseTextBlockType.Text)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
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