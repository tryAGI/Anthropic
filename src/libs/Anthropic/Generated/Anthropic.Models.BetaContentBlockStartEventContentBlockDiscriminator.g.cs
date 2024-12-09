
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaContentBlockStartEventContentBlockDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaContentBlockStartEventContentBlockDiscriminatorTypeJsonConverter))]
        public global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStartEventContentBlockDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public BetaContentBlockStartEventContentBlockDiscriminator(
            global::Anthropic.BetaContentBlockStartEventContentBlockDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContentBlockStartEventContentBlockDiscriminator" /> class.
        /// </summary>
        public BetaContentBlockStartEventContentBlockDiscriminator()
        {
        }
    }
}