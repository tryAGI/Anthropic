
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType Type { get; set; }

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
            global::Anthropic.BetaManagedAgentsAgentArchivedDeploymentPausedReasonErrorType type)
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