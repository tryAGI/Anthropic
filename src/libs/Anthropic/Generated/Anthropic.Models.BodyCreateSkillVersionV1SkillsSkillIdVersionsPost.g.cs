
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateSkillVersionV1SkillsSkillIdVersionsPost
    {
        /// <summary>
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public global::System.Collections.Generic.IList<byte[]>? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateSkillVersionV1SkillsSkillIdVersionsPost" /> class.
        /// </summary>
        /// <param name="files">
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateSkillVersionV1SkillsSkillIdVersionsPost(
            global::System.Collections.Generic.IList<byte[]>? files)
        {
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateSkillVersionV1SkillsSkillIdVersionsPost" /> class.
        /// </summary>
        public BodyCreateSkillVersionV1SkillsSkillIdVersionsPost()
        {
        }
    }
}