
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An MCP server host used by the deployment's agent is blocked by the environment's network policy.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpEgressBlockedRunError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"mcp_egress_blocked_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "mcp_egress_blocked_error";

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpEgressBlockedRunError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpEgressBlockedRunError(
            string message,
            string type = "mcp_egress_blocked_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpEgressBlockedRunError" /> class.
        /// </summary>
        public BetaManagedAgentsMcpEgressBlockedRunError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaManagedAgentsMcpEgressBlockedRunError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaManagedAgentsMcpEgressBlockedRunError FromMessage(string message)
        {
            return new BetaManagedAgentsMcpEgressBlockedRunError
            {
                Message = message,
            };
        }

    }
}