
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The settings to change. A setting left out is unchanged. A setting sent as null is cleared, so it is inherited.
    /// </summary>
    public sealed partial class BetaClaudeTagSettingsUpdate
    {
        /// <summary>
        /// Whether Claude is on. `true` on a channel turns Claude on in it even when its workspace stores `false`. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Instructions for Claude, up to 8,192 characters after leading and trailing white space is trimmed. Null or blank text clears them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The model Claude uses: the identifier of a model, or the name of a model line, that the organization is entitled to for Claude Tag. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The environment Claude's sessions run in: the identifier of an active environment of the organization, starting with `env_`, or of a self-hosted runner pool of the organization that every member may use, starting with `ccpool_`. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// What Claude does in a channel while a Slack guest is in it. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guest_policy")]
        public global::Anthropic.BetaClaudeTagGuestPolicy? GuestPolicy { get; set; }

        /// <summary>
        /// How Claude takes part in the channel: `automatic`, `mention_only`, `always_awake` or `thread`. Only a channel takes one: an update of a workspace that sends a value is refused, and one that sends null changes nothing. Null never clears it: sent to a channel that stores none it changes nothing, and sent to a channel that stores one it is refused, because a stored reply mode can be changed but never cleared; a caller that wants Claude's default behavior sends `automatic`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reply_mode")]
        public global::Anthropic.BetaClaudeTagReplyMode? ReplyMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingsUpdate" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether Claude is on. `true` on a channel turns Claude on in it even when its workspace stores `false`. Null clears it.
        /// </param>
        /// <param name="instructions">
        /// Instructions for Claude, up to 8,192 characters after leading and trailing white space is trimmed. Null or blank text clears them.
        /// </param>
        /// <param name="model">
        /// The model Claude uses: the identifier of a model, or the name of a model line, that the organization is entitled to for Claude Tag. Null clears it.
        /// </param>
        /// <param name="environmentId">
        /// The environment Claude's sessions run in: the identifier of an active environment of the organization, starting with `env_`, or of a self-hosted runner pool of the organization that every member may use, starting with `ccpool_`. Null clears it.
        /// </param>
        /// <param name="guestPolicy">
        /// What Claude does in a channel while a Slack guest is in it. Null clears it.
        /// </param>
        /// <param name="replyMode">
        /// How Claude takes part in the channel: `automatic`, `mention_only`, `always_awake` or `thread`. Only a channel takes one: an update of a workspace that sends a value is refused, and one that sends null changes nothing. Null never clears it: sent to a channel that stores none it changes nothing, and sent to a channel that stores one it is refused, because a stored reply mode can be changed but never cleared; a caller that wants Claude's default behavior sends `automatic`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSettingsUpdate(
            bool? enabled,
            string? instructions,
            string? model,
            string? environmentId,
            global::Anthropic.BetaClaudeTagGuestPolicy? guestPolicy,
            global::Anthropic.BetaClaudeTagReplyMode? replyMode)
        {
            this.Enabled = enabled;
            this.Instructions = instructions;
            this.Model = model;
            this.EnvironmentId = environmentId;
            this.GuestPolicy = guestPolicy;
            this.ReplyMode = replyMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingsUpdate" /> class.
        /// </summary>
        public BetaClaudeTagSettingsUpdate()
        {
        }

    }
}