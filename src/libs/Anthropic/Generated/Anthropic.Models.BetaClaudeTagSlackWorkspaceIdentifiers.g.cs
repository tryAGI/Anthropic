
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The identifier Slack shows for a workspace. It is Slack's own, not an identifier of this API.
    /// </summary>
    public sealed partial class BetaClaudeTagSlackWorkspaceIdentifiers
    {
        /// <summary>
        /// Slack's identifier for the workspace, starting with `T`, such as `T0123ABCD`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceIdentifiers" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Slack's identifier for the workspace, starting with `T`, such as `T0123ABCD`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagSlackWorkspaceIdentifiers(
            string workspaceId)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagSlackWorkspaceIdentifiers" /> class.
        /// </summary>
        public BetaClaudeTagSlackWorkspaceIdentifiers()
        {
        }

    }
}