
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSkillSource
    {
        /// <summary>
        /// Where the Skill comes from.<br/>
        /// Possible values:<br/>
        /// * `"custom"`: authored by the platform user; private to their workspace<br/>
        /// * `"anthropic"`: published by Anthropic; shared and read-only<br/>
        /// * `"anthropic_example"`: Anthropic-published sample Skill<br/>
        /// * `"plugin"`: resolved from an installed plugin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSkillSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSkillSourceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillSource" /> class.
        /// </summary>
        /// <param name="type">
        /// Where the Skill comes from.<br/>
        /// Possible values:<br/>
        /// * `"custom"`: authored by the platform user; private to their workspace<br/>
        /// * `"anthropic"`: published by Anthropic; shared and read-only<br/>
        /// * `"anthropic_example"`: Anthropic-published sample Skill<br/>
        /// * `"plugin"`: resolved from an installed plugin
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSkillSource(
            global::Anthropic.BetaSkillSourceType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillSource" /> class.
        /// </summary>
        public BetaSkillSource()
        {
        }

    }
}