
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Substitute the secret only on requests to the listed hosts.
    /// </summary>
    public sealed partial class BetaManagedAgentsLimitedCredentialNetworkingParams
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"limited"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "limited";

        /// <summary>
        /// The destination hosts of the outbound requests that the credential's secret is substituted into.<br/>
        /// Each entry is a bare hostname (`api.example.com`), an IPv4 address (`192.0.2.1`), or a `*.` wildcard (`*.example.com`). URLs, ports, paths, and IPv6 addresses aren't accepted. The list can have up to 16 entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_hosts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> AllowedHosts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsLimitedCredentialNetworkingParams" /> class.
        /// </summary>
        /// <param name="allowedHosts">
        /// The destination hosts of the outbound requests that the credential's secret is substituted into.<br/>
        /// Each entry is a bare hostname (`api.example.com`), an IPv4 address (`192.0.2.1`), or a `*.` wildcard (`*.example.com`). URLs, ports, paths, and IPv6 addresses aren't accepted. The list can have up to 16 entries.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsLimitedCredentialNetworkingParams(
            global::System.Collections.Generic.IList<string> allowedHosts,
            string type = "limited")
        {
            this.Type = type;
            this.AllowedHosts = allowedHosts ?? throw new global::System.ArgumentNullException(nameof(allowedHosts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsLimitedCredentialNetworkingParams" /> class.
        /// </summary>
        public BetaManagedAgentsLimitedCredentialNetworkingParams()
        {
        }

    }
}