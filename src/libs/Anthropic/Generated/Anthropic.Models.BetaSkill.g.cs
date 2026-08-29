
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSkill
    {
        /// <summary>
        /// ISO 8601 timestamp of when the skill was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Human-readable, single-line label for the Skill. Maximum 255 characters.<br/>
        /// Always set: derived from the SKILL.md frontmatter `name` when omitted at<br/>
        /// creation. Not unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the newest Skill Version — what `latest` references resolve to. Always set: a Skill holds at least one version.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LatestVersionId { get; set; }

        /// <summary>
        /// Where the Skill comes from.<br/>
        /// Possible values:<br/>
        /// * `"custom"`: authored by the platform user; private to their workspace<br/>
        /// * `"anthropic"`: published by Anthropic; shared and read-only<br/>
        /// * `"anthropic_example"`: Anthropic-published sample Skill<br/>
        /// * `"plugin"`: resolved from an installed plugin
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSkillSource Source { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Skills, this is always `"skill"`.<br/>
        /// Default Value: skill
        /// </summary>
        /// <default>"skill"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "skill";

        /// <summary>
        /// ISO 8601 timestamp of when the skill was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkill" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the skill was created.
        /// </param>
        /// <param name="displayName">
        /// Human-readable, single-line label for the Skill. Maximum 255 characters.<br/>
        /// Always set: derived from the SKILL.md frontmatter `name` when omitted at<br/>
        /// creation. Not unique.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="latestVersionId">
        /// ID of the newest Skill Version — what `latest` references resolve to. Always set: a Skill holds at least one version.
        /// </param>
        /// <param name="source">
        /// Where the Skill comes from.<br/>
        /// Possible values:<br/>
        /// * `"custom"`: authored by the platform user; private to their workspace<br/>
        /// * `"anthropic"`: published by Anthropic; shared and read-only<br/>
        /// * `"anthropic_example"`: Anthropic-published sample Skill<br/>
        /// * `"plugin"`: resolved from an installed plugin
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the skill was last updated.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Skills, this is always `"skill"`.<br/>
        /// Default Value: skill
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSkill(
            global::System.DateTime createdAt,
            string displayName,
            string id,
            string latestVersionId,
            global::Anthropic.BetaSkillSource source,
            global::System.DateTime updatedAt,
            string type = "skill")
        {
            this.CreatedAt = createdAt;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.LatestVersionId = latestVersionId ?? throw new global::System.ArgumentNullException(nameof(latestVersionId));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkill" /> class.
        /// </summary>
        public BetaSkill()
        {
        }

    }
}