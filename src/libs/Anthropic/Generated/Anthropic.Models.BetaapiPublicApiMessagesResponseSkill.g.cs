
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A skill that was loaded in a container (response model).
    /// </summary>
    public sealed partial class BetaapiPublicApiMessagesResponseSkill
    {
        /// <summary>
        /// Skill ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaapiPublicApiMessagesResponseSkillTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaapiPublicApiMessagesResponseSkillType Type { get; set; }

        /// <summary>
        /// Skill version or 'latest' for most recent version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaapiPublicApiMessagesResponseSkill" /> class.
        /// </summary>
        /// <param name="skillId">
        /// Skill ID
        /// </param>
        /// <param name="type">
        /// Type of skill - either 'anthropic' (built-in) or 'custom' (user-defined)
        /// </param>
        /// <param name="version">
        /// Skill version or 'latest' for most recent version
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaapiPublicApiMessagesResponseSkill(
            string skillId,
            global::Anthropic.BetaapiPublicApiMessagesResponseSkillType type,
            string version)
        {
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Type = type;
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaapiPublicApiMessagesResponseSkill" /> class.
        /// </summary>
        public BetaapiPublicApiMessagesResponseSkill()
        {
        }
    }
}