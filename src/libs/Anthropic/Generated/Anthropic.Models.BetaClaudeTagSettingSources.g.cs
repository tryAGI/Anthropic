
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// For each setting, the settings level its value in `settings` comes from. Without `include_inherited`, a setting the channel or workspace stores has a source that names the channel or workspace itself, and one it does not store has null, or an empty list for `instructions`. With `include_inherited=true` no member is null: a value that no settings level sets has the source `default`.
    /// </summary>
    public sealed partial class BetaClaudeTagSettingSources
    {
        /// <summary>
        /// The settings level `enabled` comes from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public global::Anthropic.BetaClaudeTagSettingSource? Enabled { get; set; }

        /// <summary>
        /// Every settings level that contributes text to `instructions`, broadest first, in the order their text is joined. Empty when none does.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSettingSource> Instructions { get; set; }

        /// <summary>
        /// The settings level `model` comes from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::Anthropic.BetaClaudeTagSettingSource? Model { get; set; }

        /// <summary>
        /// The settings level `environment_id` comes from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public global::Anthropic.BetaClaudeTagSettingSource? EnvironmentId { get; set; }

        /// <summary>
        /// The settings level `guest_policy` comes from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guest_policy")]
        public global::Anthropic.BetaClaudeTagSettingSource? GuestPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingSources" /> class.
        /// </summary>
        /// <param name="instructions">
        /// Every settings level that contributes text to `instructions`, broadest first, in the order their text is joined. Empty when none does.
        /// </param>
        /// <param name="enabled">
        /// The settings level `enabled` comes from.
        /// </param>
        /// <param name="model">
        /// The settings level `model` comes from.
        /// </param>
        /// <param name="environmentId">
        /// The settings level `environment_id` comes from.
        /// </param>
        /// <param name="guestPolicy">
        /// The settings level `guest_policy` comes from.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSettingSources(
            global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagSettingSource> instructions,
            global::Anthropic.BetaClaudeTagSettingSource? enabled,
            global::Anthropic.BetaClaudeTagSettingSource? model,
            global::Anthropic.BetaClaudeTagSettingSource? environmentId,
            global::Anthropic.BetaClaudeTagSettingSource? guestPolicy)
        {
            this.Enabled = enabled;
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Model = model;
            this.EnvironmentId = environmentId;
            this.GuestPolicy = guestPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettingSources" /> class.
        /// </summary>
        public BetaClaudeTagSettingSources()
        {
        }

    }
}