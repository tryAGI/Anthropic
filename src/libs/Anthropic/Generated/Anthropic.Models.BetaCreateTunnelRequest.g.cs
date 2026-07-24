
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for creating a tunnel.
    /// </summary>
    public sealed partial class BetaCreateTunnelRequest
    {
        /// <summary>
        /// Optional human-readable name for the tunnel (1-255 characters).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateTunnelRequest" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Optional human-readable name for the tunnel (1-255 characters).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateTunnelRequest(
            string? displayName)
        {
            this.DisplayName = displayName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateTunnelRequest" /> class.
        /// </summary>
        public BetaCreateTunnelRequest()
        {
        }

    }
}