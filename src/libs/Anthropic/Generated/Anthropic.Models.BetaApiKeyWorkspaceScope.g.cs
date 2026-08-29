
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApiKeyWorkspaceScope
    {
        /// <summary>
        /// Scope type. Always `"workspace"`: the API key belongs to one Workspace.<br/>
        /// Default Value: workspace
        /// </summary>
        /// <default>"workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace";

        /// <summary>
        /// ID of the Workspace the API key belongs to. Unlike the deprecated top-level `workspace_id`, this is the Workspace's real ID even for the organization's default Workspace.
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
        /// Initializes a new instance of the <see cref="BetaApiKeyWorkspaceScope" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// ID of the Workspace the API key belongs to. Unlike the deprecated top-level `workspace_id`, this is the Workspace's real ID even for the organization's default Workspace.
        /// </param>
        /// <param name="type">
        /// Scope type. Always `"workspace"`: the API key belongs to one Workspace.<br/>
        /// Default Value: workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKeyWorkspaceScope(
            string workspaceId,
            string type = "workspace")
        {
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyWorkspaceScope" /> class.
        /// </summary>
        public BetaApiKeyWorkspaceScope()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaApiKeyWorkspaceScope"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaApiKeyWorkspaceScope FromWorkspaceId(string workspaceId)
        {
            return new BetaApiKeyWorkspaceScope
            {
                WorkspaceId = workspaceId,
            };
        }

    }
}