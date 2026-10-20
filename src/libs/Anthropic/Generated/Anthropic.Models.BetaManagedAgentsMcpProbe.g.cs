
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The failing step of an MCP validation probe.
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpProbe
    {
        /// <summary>
        /// The MCP method that failed (for example `initialize` or `tools/list`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Method { get; set; }

        /// <summary>
        /// The HTTP error response from the MCP server, or `null` if the MCP server didn't return one for the failing step, for example after a timeout or a DNS or TLS failure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_response")]
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? HttpResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpProbe" /> class.
        /// </summary>
        /// <param name="method">
        /// The MCP method that failed (for example `initialize` or `tools/list`).
        /// </param>
        /// <param name="httpResponse">
        /// The HTTP error response from the MCP server, or `null` if the MCP server didn't return one for the failing step, for example after a timeout or a DNS or TLS failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsMcpProbe(
            string method,
            global::Anthropic.BetaManagedAgentsRefreshHttpResponse? httpResponse)
        {
            this.Method = method ?? throw new global::System.ArgumentNullException(nameof(method));
            this.HttpResponse = httpResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsMcpProbe" /> class.
        /// </summary>
        public BetaManagedAgentsMcpProbe()
        {
        }

    }
}