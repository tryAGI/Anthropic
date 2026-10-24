
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagSetUpSettingsRefusedErrorDetails
    {
        /// <summary>
        /// A stable code that names the cause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorCode { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaClaudeTagSetUpSettingsRefusedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// A stable code that names the cause.
        /// </param>
        /// <param name="slackChannelId">
        /// The identifier of the channel the request set up, starting with `slch_`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSetUpSettingsRefusedErrorDetails(
            string errorCode,
            string slackChannelId)
        {
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
            this.SlackChannelId = slackChannelId ?? throw new global::System.ArgumentNullException(nameof(slackChannelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSetUpSettingsRefusedErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagSetUpSettingsRefusedErrorDetails()
        {
        }

    }
}