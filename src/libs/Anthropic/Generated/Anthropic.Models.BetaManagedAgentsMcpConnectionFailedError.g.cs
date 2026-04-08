
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Failed to connect to an MCP server.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpConnectionFailedError
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsMcpConnectionFailedErrorTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsMcpConnectionFailedErrorType Type { get; set; }

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// What the client should do next.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRetryStatus RetryStatus { get; set; }

        /// <summary>
        /// Name of the MCP server that failed to connect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string McpServerName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpConnectionFailedError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="retryStatus">
        /// What the client should do next.
        /// </param>
        /// <param name="mcpServerName">
        /// Name of the MCP server that failed to connect.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpConnectionFailedError(
            string message,
            global::Anthropic.BetaManagedAgentsRetryStatus retryStatus,
            string mcpServerName,
            global::Anthropic.BetaManagedAgentsMcpConnectionFailedErrorType type)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryStatus = retryStatus;
            this.McpServerName = mcpServerName ?? throw new global::System.ArgumentNullException(nameof(mcpServerName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpConnectionFailedError" /> class.
        /// </summary>
        public BetaManagedAgentsMcpConnectionFailedError()
        {
        }
    }
}