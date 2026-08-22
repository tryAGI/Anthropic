
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A CA certificate attached to a tunnel.
    /// </summary>
    public sealed partial class BetaTunnelCertificate
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tunnel_certificate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tunnel_certificate";

        /// <summary>
        /// Unique identifier for the certificate, prefixed with `tcrt_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the tunnel the certificate is registered against.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tunnel_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TunnelId { get; set; }

        /// <summary>
        /// Lowercase hex SHA-256 fingerprint of the certificate's DER encoding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fingerprint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Fingerprint { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the certificate expires, or `null` if it does not expire.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the certificate was registered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the certificate was archived. Null if it is still in the trusted set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTunnelCertificate" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the certificate, prefixed with `tcrt_`.
        /// </param>
        /// <param name="tunnelId">
        /// ID of the tunnel the certificate is registered against.
        /// </param>
        /// <param name="fingerprint">
        /// Lowercase hex SHA-256 fingerprint of the certificate's DER encoding.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the certificate was registered.
        /// </param>
        /// <param name="expiresAt">
        /// RFC 3339 datetime string indicating when the certificate expires, or `null` if it does not expire.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string indicating when the certificate was archived. Null if it is still in the trusted set.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTunnelCertificate(
            string id,
            string tunnelId,
            string fingerprint,
            global::System.DateTime createdAt,
            global::System.DateTime? expiresAt,
            global::System.DateTime? archivedAt,
            string type = "tunnel_certificate")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TunnelId = tunnelId ?? throw new global::System.ArgumentNullException(nameof(tunnelId));
            this.Fingerprint = fingerprint ?? throw new global::System.ArgumentNullException(nameof(fingerprint));
            this.ExpiresAt = expiresAt;
            this.CreatedAt = createdAt;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTunnelCertificate" /> class.
        /// </summary>
        public BetaTunnelCertificate()
        {
        }

    }
}