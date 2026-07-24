
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An MCP tunnel.
    /// </summary>
    public sealed partial class BetaTunnel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"tunnel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tunnel";

        /// <summary>
        /// Unique identifier for the tunnel, prefixed with `tnl_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Anthropic-assigned hostname for the tunnel. MCP server URLs whose host is a subdomain of this value are routed through the tunnel. Globally unique and never reused, even after the tunnel is archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// Human-readable name for the tunnel (1-255 characters). Null if unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the tunnel was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the tunnel was archived. Null if it is not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTunnel" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the tunnel, prefixed with `tnl_`.
        /// </param>
        /// <param name="domain">
        /// Anthropic-assigned hostname for the tunnel. MCP server URLs whose host is a subdomain of this value are routed through the tunnel. Globally unique and never reused, even after the tunnel is archived.
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the tunnel was created.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the tunnel (1-255 characters). Null if unset.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string indicating when the tunnel was archived. Null if it is not archived.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaTunnel(
            string id,
            string domain,
            global::System.DateTime createdAt,
            string? displayName,
            global::System.DateTime? archivedAt,
            string type = "tunnel")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.DisplayName = displayName;
            this.CreatedAt = createdAt;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaTunnel" /> class.
        /// </summary>
        public BetaTunnel()
        {
        }

    }
}