
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// JWKS fetched from a fixed endpoint.
    /// </summary>
    public sealed partial class BetaJwksExplicitUrl
    {
        /// <summary>
        /// Optional custom CA (PEM) for TLS verification of the JWKS fetch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ca_cert_pem")]
        public string? CaCertPem { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"explicit_url"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "explicit_url";

        /// <summary>
        /// JWKS endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJwksExplicitUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// JWKS endpoint.
        /// </param>
        /// <param name="caCertPem">
        /// Optional custom CA (PEM) for TLS verification of the JWKS fetch.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaJwksExplicitUrl(
            string url,
            string? caCertPem,
            string type = "explicit_url")
        {
            this.CaCertPem = caCertPem;
            this.Type = type;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaJwksExplicitUrl" /> class.
        /// </summary>
        public BetaJwksExplicitUrl()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaJwksExplicitUrl"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaJwksExplicitUrl FromUrl(string url)
        {
            return new BetaJwksExplicitUrl
            {
                Url = url,
            };
        }

    }
}