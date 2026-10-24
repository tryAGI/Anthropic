
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
        /// <default>"mcp_egress_blocked_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_egress_blocked_error";

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
            string type = "mcp_egress_blocked_error")
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