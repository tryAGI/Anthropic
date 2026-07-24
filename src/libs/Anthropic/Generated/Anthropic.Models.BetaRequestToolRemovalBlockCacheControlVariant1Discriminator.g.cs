
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestToolRemovalBlockCacheControlVariant1Discriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorTypeJsonConverter))]
        public global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolRemovalBlockCacheControlVariant1Discriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestToolRemovalBlockCacheControlVariant1Discriminator(
            global::Anthropic.BetaRequestToolRemovalBlockCacheControlVariant1DiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestToolRemovalBlockCacheControlVariant1Discriminator" /> class.
        /// </summary>
        public BetaRequestToolRemovalBlockCacheControlVariant1Discriminator()
        {
        }

    }
}