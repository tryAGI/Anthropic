
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An agent acting during a session, for example through the session's mounted filesystem. It names the session itself, not the user or API key that started the session.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionActor
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"session_actor"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session_actor";

        /// <summary>
        /// ID of the session (a `sesn_...` value). Look up the session via [Retrieve a session](/en/api/beta/sessions/retrieve) for further provenance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionActor" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the session (a `sesn_...` value). Look up the session via [Retrieve a session](/en/api/beta/sessions/retrieve) for further provenance.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionActor(
            string sessionId,
            string type = "session_actor")
        {
            this.Type = type;
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsSessionActor" /> class.
        /// </summary>
        public BetaManagedAgentsSessionActor()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsSessionActor"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsSessionActor FromSessionId(string sessionId)
        {
            return new BetaManagedAgentsSessionActor
            {
                SessionId = sessionId,
            };
        }

    }
}