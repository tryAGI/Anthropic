
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An Anthropic-managed skill.<br/>
    /// Example: {"type":"anthropic","skill_id":"xlsx","version":"1"}
    /// </summary>
    public sealed partial class BetaManagedAgentsAnthropicSkillParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAnthropicSkillParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAnthropicSkillParamsType Type { get; set; }

        /// <summary>
        /// Identifier of the Anthropic skill (e.g., "xlsx").
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAnthropicSkillParams" /> class.
        /// </summary>
        /// <param name="skillId">
        /// Identifier of the Anthropic skill (e.g., "xlsx").
        /// </param>
        /// <param name="type"></param>
        /// <param name="version">
        /// Version to pin. Defaults to latest if omitted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAnthropicSkillParams(
            string skillId,
            global::Anthropic.BetaManagedAgentsAnthropicSkillParamsType type,
            string? version)
        {
            this.Type = type;
            this.SkillId = skillId ?? throw new global::System.ArgumentNullException(nameof(skillId));
            this.Version = version;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAnthropicSkillParams" /> class.
        /// </summary>
        public BetaManagedAgentsAnthropicSkillParams()
        {
        }
    }
}