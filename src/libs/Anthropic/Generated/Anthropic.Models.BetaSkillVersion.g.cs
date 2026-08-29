
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSkillVersion
    {
        /// <summary>
        /// ISO 8601 timestamp of when the skill was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Description of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Unique identifier for this Skill Version. The id addresses the version in<br/>
        /// paths and pins it in references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Skill's immutable kebab-case slug, set at creation from the first<br/>
        /// upload's SKILL.md frontmatter `name` (or its enclosing directory). Every<br/>
        /// later upload must resolve to the same value. Also the top-level directory<br/>
        /// of the Skill's mounted files and the base name of a downloaded archive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Skill Versions, this is always `"skill_version"`.<br/>
        /// Default Value: skill_version
        /// </summary>
        /// <default>"skill_version"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "skill_version";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillVersion" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the skill was created.
        /// </param>
        /// <param name="description">
        /// Description of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.
        /// </param>
        /// <param name="id">
        /// Unique identifier for this Skill Version. The id addresses the version in<br/>
        /// paths and pins it in references.
        /// </param>
        /// <param name="name">
        /// The Skill's immutable kebab-case slug, set at creation from the first<br/>
        /// upload's SKILL.md frontmatter `name` (or its enclosing directory). Every<br/>
        /// later upload must resolve to the same value. Also the top-level directory<br/>
        /// of the Skill's mounted files and the base name of a downloaded archive.
        /// </param>
        /// <param name="skillId">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Skill Versions, this is always `"skill_version"`.<br/>
        /// Default Value: skill_version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSkillVersion(
            global::System.DateTime createdAt,
            string description,
            string id,
            string name,
            string skillId,
            string type = "skill_version")
        {
            this.CreatedAt = createdAt;
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillVersion" /> class.
        /// </summary>
        public BetaSkillVersion()
        {
        }

    }
}