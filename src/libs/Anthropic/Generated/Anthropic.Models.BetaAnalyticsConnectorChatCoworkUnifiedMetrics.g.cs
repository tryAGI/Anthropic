
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A connector's use in Chat and Cowork unified on one day: `chat` holds its<br/>
    /// use in chat conversations and `sessions` its use in Cowork sessions.
    /// </summary>
    public sealed partial class BetaAnalyticsConnectorChatCoworkUnifiedMetrics
    {
        /// <summary>
        /// A connector's use in chat conversations recorded while members had<br/>
        /// Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics Chat { get; set; }

        /// <summary>
        /// A connector's use in Cowork sessions recorded while members had<br/>
        /// Chat and Cowork unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        /// <param name="chat">
        /// A connector's use in chat conversations recorded while members had<br/>
        /// Chat and Cowork unified turned on.
        /// </param>
        /// <param name="sessions">
        /// A connector's use in Cowork sessions recorded while members had<br/>
        /// Chat and Cowork unified turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsConnectorChatCoworkUnifiedMetrics(
            global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedChatMetrics chat,
            global::Anthropic.BetaAnalyticsConnectorChatCoworkUnifiedSessionsMetrics sessions)
        {
            this.Chat = chat ?? throw new global::System.ArgumentNullException(nameof(chat));
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsConnectorChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        public BetaAnalyticsConnectorChatCoworkUnifiedMetrics()
        {
        }

    }
}