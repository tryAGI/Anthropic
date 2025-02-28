
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model will not be allowed to use tools.
    /// </summary>
    public sealed partial class BetaToolChoiceNone
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaToolChoiceNoneTypeJsonConverter))]
        public global::Anthropic.BetaToolChoiceNoneType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceNone" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaToolChoiceNone(
            global::Anthropic.BetaToolChoiceNoneType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaToolChoiceNone" /> class.
        /// </summary>
        public BetaToolChoiceNone()
        {
        }
    }
}