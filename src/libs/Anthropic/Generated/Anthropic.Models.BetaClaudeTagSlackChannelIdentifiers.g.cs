
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The identifiers Slack shows for a channel. They are Slack's own, not identifiers of this API.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackChannelIdentifiers
    {
        /// <summary>
        /// Slack's identifier for the workspace the channel is in, starting with `T`, such as `T0123ABCD`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Slack's identifier for the channel, starting with `C` or `G`, such as `C0456EFGH`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChannelId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelIdentifiers" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Slack's identifier for the workspace the channel is in, starting with `T`, such as `T0123ABCD`.
        /// </param>
        /// <param name="channelId">
        /// Slack's identifier for the channel, starting with `C` or `G`, such as `C0456EFGH`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackChannelIdentifiers(
            string workspaceId,
            string channelId)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
            this.ChannelId = channelId ?? throw new global::System.ArgumentNullException(nameof(channelId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackChannelIdentifiers" /> class.
        /// </summary>
        public BetaClaudeTagSlackChannelIdentifiers()
        {
        }

    }
}