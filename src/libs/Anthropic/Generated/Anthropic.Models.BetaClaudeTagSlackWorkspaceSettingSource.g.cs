
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The value comes from a Slack workspace of the organization.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackWorkspaceSettingSource
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_workspace";

        /// <summary>
        /// The workspace's identifier, starting with `slws_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlackWorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceSettingSource" /> class.
        /// </summary>
        /// <param name="slackWorkspaceId">
        /// The workspace's identifier, starting with `slws_`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackWorkspaceSettingSource(
            string slackWorkspaceId,
            string type = "slack_workspace")
        {
            this.Type = type;
            this.SlackWorkspaceId = slackWorkspaceId ?? throw new global::System.ArgumentNullException(nameof(slackWorkspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceSettingSource" /> class.
        /// </summary>
        public BetaClaudeTagSlackWorkspaceSettingSource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackWorkspaceSettingSource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackWorkspaceSettingSource FromSlackWorkspaceId(string slackWorkspaceId)
        {
            return new BetaClaudeTagSlackWorkspaceSettingSource
            {
                SlackWorkspaceId = slackWorkspaceId,
            };
        }

    }
}