
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Attribution for a write made by an agent during a session, through the mounted filesystem at `/mnt/memory/`.
    /// </summary>
    public sealed partial class BetaManagedAgentsSessionActor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsSessionActorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsSessionActorType Type { get; set; }

        /// <summary>
        /// ID of the session that performed the write (a `sesn_...` value). Look up the session via [Retrieve a session](/en/api/sessions-retrieve) for further provenance.
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
        /// ID of the session that performed the write (a `sesn_...` value). Look up the session via [Retrieve a session](/en/api/sessions-retrieve) for further provenance.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsSessionActor(
            string sessionId,
            global::Anthropic.BetaManagedAgentsSessionActorType type)
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
    }
}