
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponseComputerToolUseBlockUnionDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseComputerToolUseBlockUnionDiscriminatorNameJsonConverter))]
        public global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseComputerToolUseBlockUnionDiscriminator" /> class.
        /// </summary>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseComputerToolUseBlockUnionDiscriminator(
            global::Anthropic.BetaResponseComputerToolUseBlockUnionDiscriminatorName? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseComputerToolUseBlockUnionDiscriminator" /> class.
        /// </summary>
        public BetaResponseComputerToolUseBlockUnionDiscriminator()
        {
        }

    }
}