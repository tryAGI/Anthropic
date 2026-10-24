
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The settings in a request that sets a Slack channel up. A setting left out is not set. A setting sent as null is cleared.
    /// </summary>
    public sealed partial class BetaClaudeTagSettingsCreate
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
        /// The environment Claude's sessions run in: the identifier of an active environment of the organization, starting with `env_`. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// What Claude does in a channel while a Slack guest is in it. Null clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guest_policy")]
        public global::Anthropic.BetaClaudeTagGuestPolicy? GuestPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingsCreate" /> class.
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
        /// The environment Claude's sessions run in: the identifier of an active environment of the organization, starting with `env_`. Null clears it.
        /// </param>
        /// <param name="guestPolicy">
        /// What Claude does in a channel while a Slack guest is in it. Null clears it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSettingsCreate(
            bool? enabled,
            string? instructions,
            string? model,
            string? environmentId,
            global::Anthropic.BetaClaudeTagGuestPolicy? guestPolicy)
        {
            this.Enabled = enabled;
            this.Instructions = instructions;
            this.Model = model;
            this.EnvironmentId = environmentId;
            this.GuestPolicy = guestPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingsCreate" /> class.
        /// </summary>
        public BetaClaudeTagSettingsCreate()
        {
        }

    }
}