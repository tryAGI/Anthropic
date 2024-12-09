
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorTypeJsonConverter))]
        public global::Anthropic.PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminator(
            global::Anthropic.PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public PromptCachingBetaRequestToolResultBlockContentVariant2ItemDiscriminator()
        {
        }
    }
}