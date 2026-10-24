
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The value comes from the addressed Slack channel itself.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackChannelSettingSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_channel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_channel";

        /// <summary>
        /// The channel's identifier, starting with `slch_`.
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
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelSettingSource" /> class.
        /// </summary>
        /// <param name="slackChannelId">
        /// The channel's identifier, starting with `slch_`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackChannelSettingSource(
            string slackChannelId,
            string type = "slack_channel")
        {
            this.Type = type;
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelSettingSource" /> class.
        /// </summary>
        public BetaClaudeTagSlackChannelSettingSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackChannelSettingSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackChannelSettingSource FromSlackChannelId(string slackChannelId)
        {
            return new BetaClaudeTagSlackChannelSettingSource
            {
                SlackChannelId = slackChannelId,
            };
        }

    }
}