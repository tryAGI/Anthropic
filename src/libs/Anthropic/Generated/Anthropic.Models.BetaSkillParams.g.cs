
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Specification for a skill to be loaded in a container (request model).
    /// </summary>
    public sealed partial class BetaSkillParams
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSkillParamsTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaSkillParamsType Type { get; set; }

        /// <summary>
        /// Skill version or 'latest' for most recent version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillParams" /> class.
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
        public BetaSkillParams(
            string skillId,
            global::Anthropic.BetaSkillParamsType type,
            string? version)
        {
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Type = type;
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSkillParams" /> class.
        /// </summary>
        public BetaSkillParams()
        {
        }
    }
}