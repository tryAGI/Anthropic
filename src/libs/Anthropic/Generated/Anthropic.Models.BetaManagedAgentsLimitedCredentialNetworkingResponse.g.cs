
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The secret is substituted only on requests to the listed hosts.
    /// </summary>
    public sealed partial class BetaManagedAgentsLimitedCredentialNetworkingResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsLimitedCredentialNetworkingResponseTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponseType Type { get; set; }

        /// <summary>
        /// The destination hosts of the outbound requests that the credential's secret is substituted into.<br/>
        /// An entry matches the request host exactly. An entry such as `*.example.com` matches any subdomain of `example.com` but not `example.com` itself.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsLimitedCredentialNetworkingResponse" /> class.
        /// </summary>
        /// <param name="allowedHosts">
        /// The destination hosts of the outbound requests that the credential's secret is substituted into.<br/>
        /// An entry matches the request host exactly. An entry such as `*.example.com` matches any subdomain of `example.com` but not `example.com` itself.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsLimitedCredentialNetworkingResponse(
            global::System.Collections.Generic.IList<string> allowedHosts,
            global::Anthropic.BetaManagedAgentsLimitedCredentialNetworkingResponseType type)
        {
            this.Type = type;
            this.AllowedHosts = allowedHosts ?? throw new global::System.ArgumentNullException(nameof(allowedHosts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsLimitedCredentialNetworkingResponse" /> class.
        /// </summary>
        public BetaManagedAgentsLimitedCredentialNetworkingResponse()
        {
        }

    }
}