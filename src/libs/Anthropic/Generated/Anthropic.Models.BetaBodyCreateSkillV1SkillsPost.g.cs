
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaBodyCreateSkillV1SkillsPost
    {
        /// <summary>
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<byte[]> Files { get; set; }

        /// <summary>
        /// Human-readable, single-line label for the Skill. Maximum 255 characters.<br/>
        /// Always set: derived from the SKILL.md frontmatter `name` when omitted at<br/>
        /// creation. Not unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBodyCreateSkillV1SkillsPost" /> class.
        /// </summary>
        /// <param name="files">
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </param>
        /// <param name="displayName">
        /// Human-readable, single-line label for the Skill. Maximum 255 characters.<br/>
        /// Always set: derived from the SKILL.md frontmatter `name` when omitted at<br/>
        /// creation. Not unique.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBodyCreateSkillV1SkillsPost(
            global::System.Collections.Generic.IList<byte[]> files,
            string? displayName)
        {
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBodyCreateSkillV1SkillsPost" /> class.
        /// </summary>
        public BetaBodyCreateSkillV1SkillsPost()
        {
        }

    }
}