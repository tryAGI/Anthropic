
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Skill
    {
        /// <summary>
        /// ISO 8601 timestamp of when the skill was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// Display title for the skill.<br/>
        /// This is a human-readable label that is not included in the prompt sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_title")]
        public string? DisplayTitle { get; set; }

        /// <summary>
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The latest version identifier for the skill.<br/>
        /// This represents the most recent version of the skill that has been created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_version")]
        public string? LatestVersion { get; set; }

        /// <summary>
        /// Source of the skill.<br/>
        /// This may be one of the following values:<br/>
        /// * `"custom"`: the skill was created by a user<br/>
        /// * `"anthropic"`: the skill was created by Anthropic
        /// </summary>
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
        /// ISO 8601 timestamp of when the skill was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// ISO 8601 timestamp of when the skill was created.
        /// </param>
        /// <param name="displayTitle">
        /// Display title for the skill.<br/>
        /// This is a human-readable label that is not included in the prompt sent to the model.
        /// </param>
        /// <param name="id">
        /// Unique identifier for the skill.<br/>
        /// The format and length of IDs may change over time.
        /// </param>
        /// <param name="latestVersion">
        /// The latest version identifier for the skill.<br/>
        /// This represents the most recent version of the skill that has been created.
        /// </param>
        /// <param name="source">
        /// Source of the skill.<br/>
        /// This may be one of the following values:<br/>
        /// * `"custom"`: the skill was created by a user<br/>
        /// * `"anthropic"`: the skill was created by Anthropic
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Skills, this is always `"skill"`.<br/>
        /// Default Value: skill
        /// </param>
        /// <param name="updatedAt">
        /// ISO 8601 timestamp of when the skill was last updated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Skill(
            string createdAt,
            string id,
            string source,
            string type,
            string updatedAt,
            string? displayTitle,
            string? latestVersion)
        {
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
            this.DisplayTitle = displayTitle;
            this.LatestVersion = latestVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Skill" /> class.
        /// </summary>
        public Skill()
        {
        }
    }
}