
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaConnectorScopePermissionResource
    {
        /// <summary>
        /// ID of the connector the permission applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connector_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConnectorId { get; set; }

        /// <summary>
        /// OAuth scope the permission names — the role may receive this scope when<br/>
        /// tokens are minted for the connector.<br/>
        /// Subject to the same encoding rule as `tool_name`: a scope containing<br/>
        /// characters outside `[a-zA-Z0-9_-]` (or colliding with a reserved form)<br/>
        /// appears server-encoded in a stable `{prefix}_{32-hex}` form. OAuth<br/>
        /// scopes routinely contain `:` and `/`, so most appear encoded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Scope { get; set; }

        /// <summary>
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: connector_scope
        /// </summary>
        /// <default>"connector_scope"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "connector_scope";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConnectorScopePermissionResource" /> class.
        /// </summary>
        /// <param name="connectorId">
        /// ID of the connector the permission applies to.
        /// </param>
        /// <param name="scope">
        /// OAuth scope the permission names — the role may receive this scope when<br/>
        /// tokens are minted for the connector.<br/>
        /// Subject to the same encoding rule as `tool_name`: a scope containing<br/>
        /// characters outside `[a-zA-Z0-9_-]` (or colliding with a reserved form)<br/>
        /// appears server-encoded in a stable `{prefix}_{32-hex}` form. OAuth<br/>
        /// scopes routinely contain `:` and `/`, so most appear encoded.
        /// </param>
        /// <param name="type">
        /// Kind of resource the permission applies to.<br/>
        /// Default Value: connector_scope
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaConnectorScopePermissionResource(
            string connectorId,
            string scope,
            string type = "connector_scope")
        {
            this.ConnectorId = connectorId ?? throw new global::System.ArgumentNullException(nameof(connectorId));
            this.Scope = scope ?? throw new global::System.ArgumentNullException(nameof(scope));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConnectorScopePermissionResource" /> class.
        /// </summary>
        public BetaConnectorScopePermissionResource()
        {
        }

    }
}