
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An MCP server host used by the deployment's agent is blocked by the environment's network policy.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError(
            global::Anthropic.BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonErrorType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError" /> class.
        /// </summary>
        public BetaManagedAgentsMcpEgressBlockedDeploymentPausedReasonError()
        {
        }

    }
}