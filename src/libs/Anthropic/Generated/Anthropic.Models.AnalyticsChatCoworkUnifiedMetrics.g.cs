
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Activity in Chat and Cowork unified for one user on one day: `chat` holds<br/>
    /// chat activity and `sessions` holds Cowork session activity.
    /// </summary>
    public sealed partial class AnalyticsChatCoworkUnifiedMetrics
    {
        /// <summary>
        /// Chat activity recorded while members had Chat and Cowork unified turned<br/>
        /// on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnalyticsChatCoworkUnifiedChatMetrics Chat { get; set; }

        /// <summary>
        /// Cowork session activity recorded while members had Chat and Cowork<br/>
        /// unified turned on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sessions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.AnalyticsChatCoworkUnifiedSessionsMetrics Sessions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        /// <param name="chat">
        /// Chat activity recorded while members had Chat and Cowork unified turned<br/>
        /// on.
        /// </param>
        /// <param name="sessions">
        /// Cowork session activity recorded while members had Chat and Cowork<br/>
        /// unified turned on.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnalyticsChatCoworkUnifiedMetrics(
            global::Anthropic.AnalyticsChatCoworkUnifiedChatMetrics chat,
            global::Anthropic.AnalyticsChatCoworkUnifiedSessionsMetrics sessions)
        {
            this.Chat = chat ?? throw new global::System.ArgumentNullException(nameof(chat));
            this.Sessions = sessions ?? throw new global::System.ArgumentNullException(nameof(sessions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsChatCoworkUnifiedMetrics" /> class.
        /// </summary>
        public AnalyticsChatCoworkUnifiedMetrics()
        {
        }

    }
}