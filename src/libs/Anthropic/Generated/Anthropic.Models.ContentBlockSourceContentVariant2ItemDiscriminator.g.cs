
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentBlockSourceContentVariant2ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ContentBlockSourceContentVariant2ItemDiscriminatorTypeJsonConverter))]
        public global::Anthropic.ContentBlockSourceContentVariant2ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockSourceContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ContentBlockSourceContentVariant2ItemDiscriminator(
            global::Anthropic.ContentBlockSourceContentVariant2ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentBlockSourceContentVariant2ItemDiscriminator" /> class.
        /// </summary>
        public ContentBlockSourceContentVariant2ItemDiscriminator()
        {
        }
    }
}