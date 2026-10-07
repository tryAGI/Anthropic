
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaResponseBrowserToolUseBlockUnionDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaResponseBrowserToolUseBlockUnionDiscriminatorNameJsonConverter))]
        public global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBrowserToolUseBlockUnionDiscriminator" /> class.
        /// </summary>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseBrowserToolUseBlockUnionDiscriminator(
            global::Anthropic.BetaResponseBrowserToolUseBlockUnionDiscriminatorName? name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseBrowserToolUseBlockUnionDiscriminator" /> class.
        /// </summary>
        public BetaResponseBrowserToolUseBlockUnionDiscriminator()
        {
        }

    }
}