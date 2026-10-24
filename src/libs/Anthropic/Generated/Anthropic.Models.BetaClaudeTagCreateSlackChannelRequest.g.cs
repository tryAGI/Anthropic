
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagCreateSlackChannelRequest
    {
        /// <summary>
        /// Slack's own identifiers for the channel to set up. The organization must own the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeTagSlackChannelIdentifiers Slack { get; set; }

        /// <summary>
        /// Settings to store on the channel, applied as Update Slack Channel applies them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        public global::Anthropic.BetaClaudeTagSettingsCreate? Settings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagCreateSlackChannelRequest" /> class.
        /// </summary>
        /// <param name="slack">
        /// Slack's own identifiers for the channel to set up. The organization must own the workspace.
        /// </param>
        /// <param name="settings">
        /// Settings to store on the channel, applied as Update Slack Channel applies them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagCreateSlackChannelRequest(
            global::Anthropic.BetaClaudeTagSlackChannelIdentifiers slack,
            global::Anthropic.BetaClaudeTagSettingsCreate? settings)
        {
            this.Slack = slack ?? throw new global::System.ArgumentNullException(nameof(slack));
            this.Settings = settings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagCreateSlackChannelRequest" /> class.
        /// </summary>
        public BetaClaudeTagCreateSlackChannelRequest()
        {
        }

    }
}