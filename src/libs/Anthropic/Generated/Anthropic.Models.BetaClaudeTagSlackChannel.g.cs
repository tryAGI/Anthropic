
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Slack channel set up for Claude Tag, with the settings it stores or, with `include_inherited`, the settings that apply in it.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackChannel
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_channel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_channel";

        /// <summary>
        /// The channel's identifier. Starts with `slch_`. It does not change for as long as the channel is set up, with one exception: a channel that is not configured gets a new one when claude.ai replaces its record, which happens only while the organization's read-only mode is off. A channel that is removed and set up again also has a new one. The old one keeps returning 404; look the channel up by its Slack identifiers for the new one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Slack's own identifiers for the channel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeTagSlackChannelIdentifiers Slack { get; set; }

        /// <summary>
        /// What the channel itself stores or, with `include_inherited`, what applies in it. `sources` says which.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeTagSettings Settings { get; set; }

        /// <summary>
        /// For each setting, the settings level its value in `settings` comes from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeTagSettingSources Sources { get; set; }

        /// <summary>
        /// Time the channel was set up, by whichever route. It does not change for as long as `id` does not.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time Claude Tag's record of the channel last changed. It moves on every change to a setting, and can also move when something no response holds changes, so a later value says to read the channel again, not that a setting changed. Attaching or detaching a Bundle does not by itself move it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannel" /> class.
        /// </summary>
        /// <param name="id">
        /// The channel's identifier. Starts with `slch_`. It does not change for as long as the channel is set up, with one exception: a channel that is not configured gets a new one when claude.ai replaces its record, which happens only while the organization's read-only mode is off. A channel that is removed and set up again also has a new one. The old one keeps returning 404; look the channel up by its Slack identifiers for the new one.
        /// </param>
        /// <param name="slack">
        /// Slack's own identifiers for the channel.
        /// </param>
        /// <param name="settings">
        /// What the channel itself stores or, with `include_inherited`, what applies in it. `sources` says which.
        /// </param>
        /// <param name="sources">
        /// For each setting, the settings level its value in `settings` comes from.
        /// </param>
        /// <param name="createdAt">
        /// Time the channel was set up, by whichever route. It does not change for as long as `id` does not.
        /// </param>
        /// <param name="updatedAt">
        /// Time Claude Tag's record of the channel last changed. It moves on every change to a setting, and can also move when something no response holds changes, so a later value says to read the channel again, not that a setting changed. Attaching or detaching a Bundle does not by itself move it.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackChannel(
            string id,
            global::Anthropic.BetaClaudeTagSlackChannelIdentifiers slack,
            global::Anthropic.BetaClaudeTagSettings settings,
            global::Anthropic.BetaClaudeTagSettingSources sources,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string type = "slack_channel")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Slack = slack ?? throw new global::System.ArgumentNullException(nameof(slack));
            this.Settings = settings ?? throw new global::System.ArgumentNullException(nameof(settings));
            this.Sources = sources ?? throw new global::System.ArgumentNullException(nameof(sources));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannel" /> class.
        /// </summary>
        public BetaClaudeTagSlackChannel()
        {
        }

    }
}