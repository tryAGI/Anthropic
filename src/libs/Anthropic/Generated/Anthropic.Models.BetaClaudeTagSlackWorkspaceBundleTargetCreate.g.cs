
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Attach the Bundle to a Slack workspace.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackWorkspaceBundleTargetCreate
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_workspace";

        /// <summary>
        /// The identifier of the Slack workspace to attach the Bundle to, starting with `slws_`.
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
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceBundleTargetCreate" /> class.
        /// </summary>
        /// <param name="slackWorkspaceId">
        /// The identifier of the Slack workspace to attach the Bundle to, starting with `slws_`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackWorkspaceBundleTargetCreate(
            string slackWorkspaceId,
            string type = "slack_workspace")
        {
            this.Type = type;
            this.SlackWorkspaceId = slackWorkspaceId ?? throw new global::System.ArgumentNullException(nameof(slackWorkspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceBundleTargetCreate" /> class.
        /// </summary>
        public BetaClaudeTagSlackWorkspaceBundleTargetCreate()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagSlackWorkspaceBundleTargetCreate"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagSlackWorkspaceBundleTargetCreate FromSlackWorkspaceId(string slackWorkspaceId)
        {
            return new BetaClaudeTagSlackWorkspaceBundleTargetCreate
            {
                SlackWorkspaceId = slackWorkspaceId,
            };
        }

    }
}