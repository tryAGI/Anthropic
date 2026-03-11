
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSkillVersionResponse
    {
        /// <summary>
        /// ISO 8601 timestamp of when the skill version was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Description of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Directory name of the skill version.<br/>
        /// This is the top-level directory name that was extracted from the uploaded files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("directory")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Directory { get; set; } = default!;

        /// <summary>
        /// Unique identifier for the skill version.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Human-readable name of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Identifier for the skill that this version belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string SkillId { get; set; } = default!;

        /// <summary>
        /// Object type.<br/>
        /// For Skill Versions, this is always `"skill_version"`.<br/>
        /// Default Value: skill_version
        /// </summary>
        /// <default>"skill_version"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Type { get; set; } = default!;

        /// <summary>
        /// Version identifier for the skill.<br/>
        /// Each version is identified by a Unix epoch timestamp (e.g., "1759178010641129").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Version { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillVersionResponse" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the skill version was created.
        /// </param>
        /// <param name="description">
        /// Description of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.
        /// </param>
        /// <param name="directory">
        /// Directory name of the skill version.<br/>
        /// This is the top-level directory name that was extracted from the uploaded files.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the skill version.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="name">
        /// Human-readable name of the skill version.<br/>
        /// This is extracted from the SKILL.md file in the skill upload.
        /// </param>
        /// <param name="skillId">
        /// Identifier for the skill that this version belongs to.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Skill Versions, this is always `"skill_version"`.<br/>
        /// Default Value: skill_version
        /// </param>
        /// <param name="version">
        /// Version identifier for the skill.<br/>
        /// Each version is identified by a Unix epoch timestamp (e.g., "1759178010641129").
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