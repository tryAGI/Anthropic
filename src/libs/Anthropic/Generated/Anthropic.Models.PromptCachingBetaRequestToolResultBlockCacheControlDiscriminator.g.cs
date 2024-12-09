
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.PromptCachingBetaRequestToolResultBlockCacheControlDiscriminatorTypeJsonConverter))]
        public global::Anthropic.PromptCachingBetaRequestToolResultBlockCacheControlDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator(
            global::Anthropic.PromptCachingBetaRequestToolResultBlockCacheControlDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator" /> class.
        /// </summary>
        public PromptCachingBetaRequestToolResultBlockCacheControlDiscriminator()
        {
        }
    }
}