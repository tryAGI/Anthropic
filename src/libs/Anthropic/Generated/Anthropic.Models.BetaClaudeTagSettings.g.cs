
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Claude Tag settings. Without `include_inherited`, a setting that is null is not set on the settings level and is inherited. With it, `enabled` and `guest_policy` are never null, and `instructions`, `model` and `environment_id` are null when no settings level sets them.
    /// </summary>
    public sealed partial class BetaClaudeTagSettings
    {
        /// <summary>
        /// Whether Claude is on. The nearest settings level that sets it decides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Instructions for Claude. Instructions add up: the text of every settings level that sets it is joined, broadest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// The model Claude uses: a model identifier or the name of a model line. The nearest settings level that sets it decides. When none does, Claude uses the product's default model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The environment Claude's sessions run in, starting with `env_`, or the identifier of a self-hosted runner pool, starting with `ccpool_`. The nearest settings level that sets it decides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// What Claude does in a channel while a Slack guest is in it. The nearest settings level that sets it decides.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guest_policy")]
        public global::Anthropic.BetaClaudeTagGuestPolicy? GuestPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettings" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether Claude is on. The nearest settings level that sets it decides.
        /// </param>
        /// <param name="instructions">
        /// Instructions for Claude. Instructions add up: the text of every settings level that sets it is joined, broadest first.
        /// </param>
        /// <param name="model">
        /// The model Claude uses: a model identifier or the name of a model line. The nearest settings level that sets it decides. When none does, Claude uses the product's default model.
        /// </param>
        /// <param name="environmentId">
        /// The environment Claude's sessions run in, starting with `env_`, or the identifier of a self-hosted runner pool, starting with `ccpool_`. The nearest settings level that sets it decides.
        /// </param>
        /// <param name="guestPolicy">
        /// What Claude does in a channel while a Slack guest is in it. The nearest settings level that sets it decides.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSettings(
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
        /// Initializes a new instance of the <see cref="BetaClaudeTagSettings" /> class.
        /// </summary>
        public BetaClaudeTagSettings()
        {
        }

    }
}