
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment's workspace was archived.
    /// </summary>
    public sealed partial class BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_archived_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "workspace_archived_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError(
            string type = "workspace_archived_error")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsWorkspaceArchivedDeploymentPausedReasonError()
        {
        }

    }
}