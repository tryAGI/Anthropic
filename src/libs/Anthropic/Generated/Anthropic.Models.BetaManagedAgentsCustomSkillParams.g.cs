
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user-created custom skill.<br/>
    /// Example: {"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTlx","version":"2"}
    /// </summary>
    public sealed partial class BetaManagedAgentsCustomSkillParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomSkillParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCustomSkillParamsType Type { get; set; }

        /// <summary>
        /// Tagged ID of the custom skill (e.g., "skill_01XJ5...").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// Version to pin. Defaults to latest if omitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomSkillParams" /> class.
        /// </summary>
        /// <param name="skillId">
        /// Tagged ID of the custom skill (e.g., "skill_01XJ5...").
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// Version to pin. Defaults to latest if omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCustomSkillParams(
            string skillId,
            global::Anthropic.BetaManagedAgentsCustomSkillParamsType type,
            string? version)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomSkillParams" /> class.
        /// </summary>
        public BetaManagedAgentsCustomSkillParams()
        {
        }
    }
}