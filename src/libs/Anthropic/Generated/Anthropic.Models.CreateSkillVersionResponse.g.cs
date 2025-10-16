
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSkillVersionResponse
    {
        /// <summary>
        /// ISO 8601 timestamp of when the skill version was created.<br/>
        /// Example: 2024-10-30T23:58:27.427722Z
        /// </summary>
        /// <example>2024-10-30T23:58:27.427722Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Description of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.<br/>
        /// Example: A custom skill for doing something useful
        /// </summary>
        /// <example>A custom skill for doing something useful</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Directory name of the skill version.<br/>
        /// This is the top-level directory name that was extracted from the uploaded files.<br/>
        /// Example: my-skill
        /// </summary>
        /// <example>my-skill</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Directory { get; set; }

        /// <summary>
        /// Unique identifier for the skill version.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: skillver_01JAbcdefghijklmnopqrstuvw
        /// </summary>
        /// <example>skillver_01JAbcdefghijklmnopqrstuvw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Human-readable name of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.<br/>
        /// Example: my-skill
        /// </summary>
        /// <example>my-skill</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Identifier for the skill that this version belongs to.<br/>
        /// Example: skill_01JAbcdefghijklmnopqrstuvw
        /// </summary>
        /// <example>skill_01JAbcdefghijklmnopqrstuvw</example>
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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "skill_version";

        /// <summary>
        /// Version identifier for the skill.<br/>
        /// Each version is identified by a Unix epoch timestamp (e.g., "1759178010641129").<br/>
        /// Example: 1759178010641129
        /// </summary>
        /// <example>1759178010641129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillVersionResponse" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the skill version was created.<br/>
        /// Example: 2024-10-30T23:58:27.427722Z
        /// </param>
        /// <param name="description">
        /// Description of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.<br/>
        /// Example: A custom skill for doing something useful
        /// </param>
        /// <param name="directory">
        /// Directory name of the skill version.<br/>
        /// This is the top-level directory name that was extracted from the uploaded files.<br/>
        /// Example: my-skill
        /// </param>
        /// <param name="id">
        /// Unique identifier for the skill version.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: skillver_01JAbcdefghijklmnopqrstuvw
        /// </param>
        /// <param name="name">
        /// Human-readable name of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.<br/>
        /// Example: my-skill
        /// </param>
        /// <param name="skillId">
        /// Identifier for the skill that this version belongs to.<br/>
        /// Example: skill_01JAbcdefghijklmnopqrstuvw
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Skill Versions, this is always `"skill_version"`.<br/>
        /// Default Value: skill_version
        /// </param>
        /// <param name="version">
        /// Version identifier for the skill.<br/>
        /// Each version is identified by a Unix epoch timestamp (e.g., "1759178010641129").<br/>
        /// Example: 1759178010641129
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillVersionResponse(
            string createdAt,
            string description,
            string directory,
            string id,
            string name,
            string skillId,
            string type,
            string version)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Directory = directory ?? throw new global::System.ArgumentNullException(nameof(directory));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillVersionResponse" /> class.
        /// </summary>
        public CreateSkillVersionResponse()
        {
        }
    }
}