
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorTypeJsonConverter))]
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminator(
            global::Anthropic.BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminator" /> class.
        /// </summary>
        public BetaRequestCodeExecutionToolResultBlockCacheControlDiscriminator()
        {
        }
    }
}