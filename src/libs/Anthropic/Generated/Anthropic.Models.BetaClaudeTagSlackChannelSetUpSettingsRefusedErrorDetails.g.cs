
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request set the channel up, and `settings` was then refused. The channel stays set up with every setting unset.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails
    {
        /// <summary>
        /// A stable code that names the cause.
        /// </summary>
        /// <default>"slack_channel_set_up_settings_refused"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "slack_channel_set_up_settings_refused";

        /// <summary>
        /// The identifier of the channel the request set up, starting with `slch_`.
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
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails" /> class.
        /// </summary>
        /// <param name="slackChannelId">
        /// The identifier of the channel the request set up, starting with `slch_`.
        /// </param>
        /// <param name="errorCode">
        /// A stable code that names the cause.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails(
            string slackChannelId,
            string errorCode = "slack_channel_set_up_settings_refused")
        {
            this.ErrorCode = errorCode;
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails FromSlackChannelId(string slackChannelId)
        {
            return new BetaClaudeTagSlackChannelSetUpSettingsRefusedErrorDetails
            {
                SlackChannelId = slackChannelId,
            };
        }

    }
}