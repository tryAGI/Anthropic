
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Attach the Bundle to a Slack channel.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackChannelBundleTargetCreate
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_channel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_channel";

        /// <summary>
        /// The identifier of the Slack channel to attach the Bundle to, starting with `slch_`. It is the channel object's `id`, not Slack's `channel_id`.
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
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelBundleTargetCreate" /> class.
        /// </summary>
        /// <param name="slackChannelId">
        /// The identifier of the Slack channel to attach the Bundle to, starting with `slch_`. It is the channel object's `id`, not Slack's `channel_id`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackChannelBundleTargetCreate(
            string slackChannelId,
            string type = "slack_channel")
        {
            this.Type = type;
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelBundleTargetCreate" /> class.
        /// </summary>
        public BetaClaudeTagSlackChannelBundleTargetCreate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackChannelBundleTargetCreate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackChannelBundleTargetCreate FromSlackChannelId(string slackChannelId)
        {
            return new BetaClaudeTagSlackChannelBundleTargetCreate
            {
                SlackChannelId = slackChannelId,
            };
        }

    }
}