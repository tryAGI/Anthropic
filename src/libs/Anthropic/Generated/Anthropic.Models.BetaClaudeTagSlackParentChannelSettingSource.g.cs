
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The value comes from the channel that a code channel was started from. A parent channel contributes `instructions` and `environment_id` only.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackParentChannelSettingSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_parent_channel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_parent_channel";

        /// <summary>
        /// The parent channel's identifier, starting with `slch_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_channel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlackChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackParentChannelSettingSource" /> class.
        /// </summary>
        /// <param name="slackChannelId">
        /// The parent channel's identifier, starting with `slch_`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackParentChannelSettingSource(
            string slackChannelId,
            string type = "slack_parent_channel")
        {
            this.Type = type;
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackParentChannelSettingSource" /> class.
        /// </summary>
        public BetaClaudeTagSlackParentChannelSettingSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackParentChannelSettingSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackParentChannelSettingSource FromSlackChannelId(string slackChannelId)
        {
            return new BetaClaudeTagSlackParentChannelSettingSource
            {
                SlackChannelId = slackChannelId,
            };
        }

    }
}