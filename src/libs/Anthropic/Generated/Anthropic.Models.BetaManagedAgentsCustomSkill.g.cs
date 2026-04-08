
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A resolved user-created custom skill.<br/>
    /// Example: {"type":"custom","skill_id":"skill_011CZkZFNu9hAbo3jZPRgTlx","version":"2"}
    /// </summary>
    public sealed partial class BetaManagedAgentsCustomSkill
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCustomSkillTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsCustomSkillType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SkillId { get; set; }

        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomSkill" /> class.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="version"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsCustomSkill(
            string skillId,
            string version,
            global::Anthropic.BetaManagedAgentsCustomSkillType type)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsCustomSkill" /> class.
        /// </summary>
        public BetaManagedAgentsCustomSkill()
        {
        }
    }
}