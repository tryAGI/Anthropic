
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `settings.environment_id` names no Environment within the organization's reach, and the request had set the channel up by then. The channel stays set up with every setting unset.
    /// </summary>
    public sealed partial class BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_channel_set_up_environment_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "slack_channel_set_up_environment_not_found";

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
        /// Initializes a new instance of the <see cref="BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="slackChannelId">
        /// The identifier of the channel the request set up, starting with `slch_`.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails(
            string slackChannelId,
            string errorCode = "slack_channel_set_up_environment_not_found")
        {
            this.ErrorCode = errorCode;
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails" /> class.
        /// </summary>
        public BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails FromSlackChannelId(string slackChannelId)
        {
            return new BetaSlackChannelSetUpEnvironmentNotFoundErrorDetails
            {
                SlackChannelId = slackChannelId,
            };
        }

    }
}