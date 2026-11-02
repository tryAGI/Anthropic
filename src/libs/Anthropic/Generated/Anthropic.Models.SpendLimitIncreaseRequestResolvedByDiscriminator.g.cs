
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpendLimitIncreaseRequestResolvedByDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SpendLimitIncreaseRequestResolvedByDiscriminatorTypeJsonConverter))]
        public global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendLimitIncreaseRequestResolvedByDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SpendLimitIncreaseRequestResolvedByDiscriminator(
            global::Anthropic.SpendLimitIncreaseRequestResolvedByDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpendLimitIncreaseRequestResolvedByDiscriminator" /> class.
        /// </summary>
        public SpendLimitIncreaseRequestResolvedByDiscriminator()
        {
        }

    }
}