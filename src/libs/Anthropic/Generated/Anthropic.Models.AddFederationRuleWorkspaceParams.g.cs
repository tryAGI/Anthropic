
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AddFederationRuleWorkspaceParams
    {
        /// <summary>
        /// Tagged ID of the workspace to enable this rule for.
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
        /// Initializes a new instance of the <see cref="AddFederationRuleWorkspaceParams" /> class.
        /// </summary>
        /// <param name="workspaceId">
        /// Tagged ID of the workspace to enable this rule for.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddFederationRuleWorkspaceParams(
            string workspaceId)
        {
            this.WorkspaceId = workspaceId ?? throw new global::System.ArgumentNullException(nameof(workspaceId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddFederationRuleWorkspaceParams" /> class.
        /// </summary>
        public AddFederationRuleWorkspaceParams()
        {
        }

    }
}