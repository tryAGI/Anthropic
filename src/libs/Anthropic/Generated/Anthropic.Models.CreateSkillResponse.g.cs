
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSkillResponse
    {
        /// <summary>
        /// ISO 8601 timestamp of when the skill was created.<br/>
        /// Example: 2024-10-30T23:58:27.427722Z
        /// </summary>
        /// <example>2024-10-30T23:58:27.427722Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Display title for the skill.<br/>
        /// This is a human-readable label that is not included in the prompt sent to the model.<br/>
        /// Example: My Custom Skill
        /// </summary>
        /// <example>My Custom Skill</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? DisplayTitle { get; set; }

        /// <summary>
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: skill_01JAbcdefghijklmnopqrstuvw
        /// </summary>
        /// <example>skill_01JAbcdefghijklmnopqrstuvw</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The latest version identifier for the skill.<br/>
        /// This represents the most recent version of the skill that has been created.<br/>
        /// Example: 1759178010641129
        /// </summary>
        /// <example>1759178010641129</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? LatestVersion { get; set; }

        /// <summary>
        /// Source of the skill.<br/>
        /// This may be one of the following values:<br/>
        /// * `"custom"`: the skill was created by a user<br/>
        /// * `"anthropic"`: the skill was created by Anthropic<br/>
        /// Example: custom
        /// </summary>
        /// <example>custom</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Skills, this is always `"skill"`.<br/>
        /// Default Value: skill
        /// </summary>
        /// <default>"skill"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "skill";

        /// <summary>
        /// ISO 8601 timestamp of when the skill was last updated.<br/>
        /// Example: 2024-10-30T23:58:27.427722Z
        /// </summary>
        /// <example>2024-10-30T23:58:27.427722Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillResponse" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the skill was created.<br/>
        /// Example: 2024-10-30T23:58:27.427722Z
        /// </param>
        /// <param name="displayTitle">
        /// Display title for the skill.<br/>
        /// This is a human-readable label that is not included in the prompt sent to the model.<br/>
        /// Example: My Custom Skill
        /// </param>
        /// <param name="id">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.<br/>
        /// Example: skill_01JAbcdefghijklmnopqrstuvw
        /// </param>
        /// <param name="latestVersion">
        /// The latest version identifier for the skill.<br/>
        /// This represents the most recent version of the skill that has been created.<br/>
        /// Example: 1759178010641129
        /// </param>
        /// <param name="source">
        /// Source of the skill.<br/>
        /// This may be one of the following values:<br/>
        /// * `"custom"`: the skill was created by a user<br/>
        /// * `"anthropic"`: the skill was created by Anthropic<br/>
        /// Example: custom
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Skills, this is always `"skill"`.<br/>
        /// Default Value: skill
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the skill was last updated.<br/>
        /// Example: 2024-10-30T23:58:27.427722Z
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSkillResponse(
            string createdAt,
            string? displayTitle,
            string id,
            string? latestVersion,
            string source,
            string type,
            string updatedAt)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.DisplayTitle = displayTitle ?? throw new global::System.ArgumentNullException(nameof(displayTitle));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersion = latestVersion ?? throw new global::System.ArgumentNullException(nameof(latestVersion));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSkillResponse" /> class.
        /// </summary>
        public CreateSkillResponse()
        {
        }
    }
}