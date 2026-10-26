
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The value comes from the addressed channel as it is set up under another workspace of its Enterprise Grid: a channel shared across the Grid keeps one Slack channel identifier in every workspace that sees it.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackGridChannelSettingSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_grid_channel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_grid_channel";

        /// <summary>
        /// Slack's own identifiers for the channel under that other workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaClaudeTagSlackChannelIdentifiers Slack { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackGridChannelSettingSource" /> class.
        /// </summary>
        /// <param name="slack">
        /// Slack's own identifiers for the channel under that other workspace.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackGridChannelSettingSource(
            global::Anthropic.BetaClaudeTagSlackChannelIdentifiers slack,
            string type = "slack_grid_channel")
        {
            this.Type = type;
            this.Slack = slack ?? throw new global::System.ArgumentNullException(nameof(slack));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackGridChannelSettingSource" /> class.
        /// </summary>
        public BetaClaudeTagSlackGridChannelSettingSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackGridChannelSettingSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackGridChannelSettingSource FromSlack(global::Anthropic.BetaClaudeTagSlackChannelIdentifiers slack)
        {
            return new BetaClaudeTagSlackGridChannelSettingSource
            {
                Slack = slack,
            };
        }

    }
}