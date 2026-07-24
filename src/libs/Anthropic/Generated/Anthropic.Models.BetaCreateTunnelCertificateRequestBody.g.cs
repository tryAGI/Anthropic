
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaCreateTunnelCertificateRequestBody
    {
        /// <summary>
        /// PEM-encoded X.509 CA certificate. Must contain exactly one certificate and no private-key material. Maximum 8KB.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ca_certificate_pem")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CaCertificatePem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateTunnelCertificateRequestBody" /> class.
        /// </summary>
        /// <param name="caCertificatePem">
        /// PEM-encoded X.509 CA certificate. Must contain exactly one certificate and no private-key material. Maximum 8KB.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCreateTunnelCertificateRequestBody(
            string caCertificatePem)
        {
            this.CaCertificatePem = caCertificatePem ?? throw new global::System.ArgumentNullException(nameof(caCertificatePem));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCreateTunnelCertificateRequestBody" /> class.
        /// </summary>
        public BetaCreateTunnelCertificateRequestBody()
        {
        }

    }
}