
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A skill's use in Chat and Cowork unified on one day: `chat` holds its use<br/>
    /// in chat conversations and `sessions` its use in Cowork sessions.
    /// </summary>
    public sealed partial class BetaAnalyticsSkillChatCoworkUnifiedMetrics
    {
        /// <summary>
        /// A skill's use in chat conversations recorded while members had<br/>
        /// Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics Chat { get; set; }

        /// <summary>
        /// A skill's use in Cowork sessions recorded while members had Chat<br/>
        /// and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        /// <param name="chat">
        /// A skill's use in chat conversations recorded while members had<br/>
        /// Chat and Cowork unified turned on.
        /// </param>
        /// <param name="sessions">
        /// A skill's use in Cowork sessions recorded while members had Chat<br/>
        /// and Cowork unified turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsSkillChatCoworkUnifiedMetrics(
            global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedChatMetrics chat,
            global::Anthropic.BetaAnalyticsSkillChatCoworkUnifiedSessionsMetrics sessions)
        {
            this.Chat = chat ?? throw new global::System.ArgumentNullException(nameof(chat));
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsSkillChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        public BetaAnalyticsSkillChatCoworkUnifiedMetrics()
        {
        }

    }
}