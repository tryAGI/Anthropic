
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A resolved Anthropic-managed skill.<br/>
    /// Example: {"type":"anthropic","skill_id":"xlsx","version":"1"}
    /// </summary>
    public sealed partial class BetaManagedAgentsAnthropicSkill
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAnthropicSkillTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAnthropicSkillType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAnthropicSkill" /> class.
        /// </summary>
        /// <param name="skillId"></param>
        /// <param name="version"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAnthropicSkill(
            string skillId,
            string version,
            global::Anthropic.BetaManagedAgentsAnthropicSkillType type)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAnthropicSkill" /> class.
        /// </summary>
        public BetaManagedAgentsAnthropicSkill()
        {
        }
    }
}