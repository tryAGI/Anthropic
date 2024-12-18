
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageBatchIndividualResponseResultDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.MessageBatchIndividualResponseResultDiscriminatorTypeJsonConverter))]
        public global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchIndividualResponseResultDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public MessageBatchIndividualResponseResultDiscriminator(
            global::Anthropic.MessageBatchIndividualResponseResultDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageBatchIndividualResponseResultDiscriminator" /> class.
        /// </summary>
        public MessageBatchIndividualResponseResultDiscriminator()
        {
        }
    }
}