
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The captured HTTP error response. Null when no HTTP response was received (timeout, DNS, TLS).
    /// </summary>
    public sealed partial class BetaManagedAgentsMcpProbeHttpResponse
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}