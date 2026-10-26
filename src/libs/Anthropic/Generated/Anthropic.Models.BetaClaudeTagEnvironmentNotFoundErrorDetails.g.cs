
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagEnvironmentNotFoundErrorDetails
    {
        /// <summary>
        /// A stable code that names the cause.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorCode { get; set; }

        /// <summary>
        /// On a setup request that set the channel up before the refusal: the channel's identifier, starting with `slch_`. The channel stays set up with every setting unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_channel_id")]
        public string? SlackChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagEnvironmentNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// A stable code that names the cause.
        /// </param>
        /// <param name="slackChannelId">
        /// On a setup request that set the channel up before the refusal: the channel's identifier, starting with `slch_`. The channel stays set up with every setting unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagEnvironmentNotFoundErrorDetails(
            string errorCode,
            string? slackChannelId)
        {
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
            this.SlackChannelId = slackChannelId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagEnvironmentNotFoundErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagEnvironmentNotFoundErrorDetails()
        {
        }

    }
}