
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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsLimitedCredentialNetworkingParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParamsType Type { get; set; }

        /// <summary>
        /// Hostnames on which the secret will be substituted. Each entry is a bare hostname (`api.example.com`), an IPv4 address (`192.0.2.1`), or a `*.`-prefixed wildcard (`*.example.com`). URLs, ports, paths, and IPv6 addresses are not accepted. At most 16 entries.
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
        /// Hostnames on which the secret will be substituted. Each entry is a bare hostname (`api.example.com`), an IPv4 address (`192.0.2.1`), or a `*.`-prefixed wildcard (`*.example.com`). URLs, ports, paths, and IPv6 addresses are not accepted. At most 16 entries.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsLimitedCredentialNetworkingParams(
            global::System.Collections.Generic.IList<string> allowedHosts,
            global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingParamsType type)
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