
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SkillSource
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SkillSourceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.SkillSourceType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillSource" /> class.
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
        public SkillSource(
            global::Anthropic.SkillSourceType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SkillSource" /> class.
        /// </summary>
        public SkillSource()
        {
        }

    }
}