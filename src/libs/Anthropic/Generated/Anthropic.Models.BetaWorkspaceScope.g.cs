
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Scope selecting one workspace of a Claude Console organization.
    /// </summary>
    public sealed partial class BetaWorkspaceScope
    {
        /// <summary>
        /// Scope type. Always `workspace` for this scope.<br/>
        /// Default Value: workspace
        /// </summary>
        /// <default>"workspace"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace";

        /// <summary>
        /// Tagged ID of the workspace the spend limit applies to.
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
        /// Initializes a new instance of the <see cref="BetaWorkspaceScope" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace the spend limit applies to.
        /// </param>
        /// <param name="type">
        /// Scope type. Always `workspace` for this scope.<br/>
        /// Default Value: workspace
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceScope(
            string workspaceId,
            string type = "workspace")
        {
            this.Type = type;
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceScope" /> class.
        /// </summary>
        public BetaWorkspaceScope()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaWorkspaceScope"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaWorkspaceScope FromWorkspaceId(string workspaceId)
        {
            return new BetaWorkspaceScope
            {
                WorkspaceId = workspaceId,
            };
        }

    }
}