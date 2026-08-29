
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOrganizationTunnel
    {
        /// <summary>
        /// RFC 3339 datetime string indicating when the Tunnel was archived, or<br/>
        /// `null` if it is not archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public global::System.DateTime? ArchivedAt { get; set; }

        /// <summary>
        /// RFC 3339 datetime string indicating when the Tunnel was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Human-readable name for the Tunnel (1–255 characters), or `null` if unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Anthropic-assigned hostname for the Tunnel. MCP server URLs whose host is a<br/>
        /// subdomain of this value are routed through the Tunnel. Globally unique and<br/>
        /// never reused, even after the Tunnel is archived.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Domain { get; set; }

        /// <summary>
        /// ID of the Tunnel.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object type. Always `tunnel` for Tunnels.<br/>
        /// Default Value: tunnel
        /// </summary>
        /// <default>"tunnel"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tunnel";

        /// <summary>
        /// ID of the Workspace this Tunnel belongs to, or `null` for the default<br/>
        /// Workspace. Immutable after creation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTunnel" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// RFC 3339 datetime string indicating when the Tunnel was created.
        /// </param>
        /// <param name="domain">
        /// Anthropic-assigned hostname for the Tunnel. MCP server URLs whose host is a<br/>
        /// subdomain of this value are routed through the Tunnel. Globally unique and<br/>
        /// never reused, even after the Tunnel is archived.
        /// </param>
        /// <param name="id">
        /// ID of the Tunnel.
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 datetime string indicating when the Tunnel was archived, or<br/>
        /// `null` if it is not archived.
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for the Tunnel (1–255 characters), or `null` if unset.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the Workspace this Tunnel belongs to, or `null` for the default<br/>
        /// Workspace. Immutable after creation.
        /// </param>
        /// <param name="type">
        /// Object type. Always `tunnel` for Tunnels.<br/>
        /// Default Value: tunnel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationTunnel(
            global::System.DateTime createdAt,
            string domain,
            string id,
            global::System.DateTime? archivedAt,
            string? displayName,
            string? workspaceId,
            string type = "tunnel")
        {
            this.ArchivedAt = archivedAt;
            this.CreatedAt = createdAt;
            this.DisplayName = displayName;
            this.Domain = domain ?? throw new global::System.ArgumentNullException(nameof(domain));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTunnel" /> class.
        /// </summary>
        public BetaOrganizationTunnel()
        {
        }

    }
}