
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One Bundle attached to one Slack workspace. The Bundle can be used in the workspace and in every channel in it.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackWorkspaceBundleTarget
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"slack_workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "slack_workspace";

        /// <summary>
        /// The Bundle Target's identifier. Starts with `btgt_`. No two Bundle Targets have the same one, and the same Bundle and target always give the same one, also after a detach and a new attach. It is opaque.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The identifier of the Slack workspace the Bundle is attached to, starting with `slws_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slack_workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SlackWorkspaceId { get; set; }

        /// <summary>
        /// Time the Bundle was attached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceBundleTarget" /> class.
        /// </summary>
        /// <param name="id">
        /// The Bundle Target's identifier. Starts with `btgt_`. No two Bundle Targets have the same one, and the same Bundle and target always give the same one, also after a detach and a new attach. It is opaque.
        /// </param>
        /// <param name="slackWorkspaceId">
        /// The identifier of the Slack workspace the Bundle is attached to, starting with `slws_`.
        /// </param>
        /// <param name="createdAt">
        /// Time the Bundle was attached.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackWorkspaceBundleTarget(
            string id,
            string slackWorkspaceId,
            global::System.DateTime createdAt,
            string type = "slack_workspace")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.SlackWorkspaceId = slackWorkspaceId ?? throw new global::System.ArgumentNullException(nameof(slackWorkspaceId));
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceBundleTarget" /> class.
        /// </summary>
        public BetaClaudeTagSlackWorkspaceBundleTarget()
        {
        }

    }
}