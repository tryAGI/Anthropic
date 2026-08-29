
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOrganizationTunnelCertificate
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the certificate was archived, or<br/>
        /// `null` if it is not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the certificate was registered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the certificate expires, or<br/>
        /// `null` if it does not expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The certificate's SHA-256 fingerprint, as a lowercase hex string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fingerprint { get; set; }

        /// <summary>
        /// ID of the Tunnel Certificate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the Tunnel this certificate is registered against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TunnelId { get; set; }

        /// <summary>
        /// Object type. Always `tunnel_certificate` for Tunnel Certificates.<br/>
        /// Default Value: tunnel_certificate
        /// </summary>
        /// <default>"tunnel_certificate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tunnel_certificate";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTunnelCertificate" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the certificate was registered.
        /// </param>
        /// <param name="fingerprint">
        /// The certificate's SHA-256 fingerprint, as a lowercase hex string.
        /// </param>
        /// <param name="id">
        /// ID of the Tunnel Certificate.
        /// </param>
        /// <param name="tunnelId">
        /// ID of the Tunnel this certificate is registered against.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string indicating when the certificate was archived, or<br/>
        /// `null` if it is not archived.
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 datetime string indicating when the certificate expires, or<br/>
        /// `null` if it does not expire.
        /// </param>
        /// <param name="type">
        /// Object type. Always `tunnel_certificate` for Tunnel Certificates.<br/>
        /// Default Value: tunnel_certificate
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationTunnelCertificate(
            global::System.DateTime createdAt,
            string fingerprint,
            string id,
            string tunnelId,
            global::System.DateTime? archivedAt,
            global::System.DateTime? expiresAt,
            string type = "tunnel_certificate")
        {
            this.ArchivedAt = archivedAt;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Fingerprint = fingerprint ?? throw new global::System.ArgumentNullException(nameof(fingerprint));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TunnelId = tunnelId ?? throw new global::System.ArgumentNullException(nameof(tunnelId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTunnelCertificate" /> class.
        /// </summary>
        public BetaOrganizationTunnelCertificate()
        {
        }

    }
}