
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The deployment's agent was archived.
    /// </summary>
    public sealed partial class BetaManagedAgentsAgentArchivedDeploymentPausedReasonError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"agent_archived_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "agent_archived_error";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentArchivedDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsAgentArchivedDeploymentPausedReasonError(
            string type = "agent_archived_error")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsAgentArchivedDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsAgentArchivedDeploymentPausedReasonError()
        {
        }

    }
}