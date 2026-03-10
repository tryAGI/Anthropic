
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Files to upload for the skill.<br/>
    /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
    /// </summary>
    public sealed partial class BodyCreateSkillV1SkillsPostFiles
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}