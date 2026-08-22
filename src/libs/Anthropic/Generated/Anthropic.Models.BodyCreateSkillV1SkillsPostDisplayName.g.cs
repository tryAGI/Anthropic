
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Human-readable, single-line label for the Skill. Maximum 255 characters.<br/>
    /// Always set: derived from the SKILL.md frontmatter `name` when omitted at<br/>
    /// creation. Not unique.
    /// </summary>
    public sealed partial class BodyCreateSkillV1SkillsPostDisplayName
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}