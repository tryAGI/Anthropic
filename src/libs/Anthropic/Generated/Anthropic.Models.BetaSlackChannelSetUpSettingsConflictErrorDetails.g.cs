
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request set the channel up, and something else then changed the channel or removed it. Nothing of `settings` was stored.
    /// </summary>
    public sealed partial class BetaSlackChannelSetUpSettingsConflictErrorDetails
    {
        /// <summary>
        /// A stable code that names the cause.
        /// </summary>
        /// <default>"slack_channel_set_up_settings_conflict"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "slack_channel_set_up_settings_conflict";

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
        /// Initializes a new instance of the <see cref="BetaSlackChannelSetUpSettingsConflictErrorDetails" /> class.
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
        public BetaSlackChannelSetUpSettingsConflictErrorDetails(
            string slackChannelId,
            string errorCode = "slack_channel_set_up_settings_conflict")
        {
            this.ErrorCode = errorCode;
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSlackChannelSetUpSettingsConflictErrorDetails" /> class.
        /// </summary>
        public BetaSlackChannelSetUpSettingsConflictErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaSlackChannelSetUpSettingsConflictErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaSlackChannelSetUpSettingsConflictErrorDetails FromSlackChannelId(string slackChannelId)
        {
            return new BetaSlackChannelSetUpSettingsConflictErrorDetails
            {
                SlackChannelId = slackChannelId,
            };
        }

    }
}