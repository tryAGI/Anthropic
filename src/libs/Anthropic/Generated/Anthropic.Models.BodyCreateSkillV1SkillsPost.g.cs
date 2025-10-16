
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateSkillV1SkillsPost
    {
        /// <summary>
        /// Display title for the skill.<br/>
        /// This is a human-readable label that is not included in the prompt sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_title")]
        public string? DisplayTitle { get; set; }

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
        /// Initializes a new instance of the <see cref="BodyCreateSkillV1SkillsPost" /> class.
        /// </summary>
        /// <param name="displayTitle">
        /// Display title for the skill.<br/>
        /// This is a human-readable label that is not included in the prompt sent to the model.
        /// </param>
        /// <param name="files">
        /// Files to upload for the skill.<br/>
        /// All files must be in the same top-level directory and must include a SKILL.md file at the root of that directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyCreateSkillV1SkillsPost(
            string? displayTitle,
            global::System.Collections.Generic.IList<byte[]>? files)
        {
            this.DisplayTitle = displayTitle;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateSkillV1SkillsPost" /> class.
        /// </summary>
        public BodyCreateSkillV1SkillsPost()
        {
        }
    }
}