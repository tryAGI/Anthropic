
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRbacRolePermission
    {
        /// <summary>
        /// Action the permission grants on the resource.<br/>
        /// The vocabulary follows the resource: an `organization` grant carries a<br/>
        /// product-feature entitlement (for example `chat`), an admin-panel<br/>
        /// permission entitlement (`permission_*`), or a blanket capability-access<br/>
        /// mode — `capability_access_all` grants every product-feature entitlement,<br/>
        /// and `capability_access_all_ga` grants the generally-available subset as<br/>
        /// it stands at permission-check time; neither mode grants model-access<br/>
        /// entitlements. A consumer enumerating a role's per-feature grants should<br/>
        /// treat a blanket row as granting every product-feature entitlement it<br/>
        /// covers, or it will under-report the role's effective access. A `connector_tool` grant carries<br/>
        /// a tool-access action (`use` or `always_allow`); a `connector_scope` grant<br/>
        /// carries the scope action `grant` (the role may receive the named OAuth<br/>
        /// scope when tokens are minted for the connector); `connector` and<br/>
        /// `all_connectors` grants carry a tool-access action, the scope action, or<br/>
        /// an authentication-method action (`interactive` or `managed`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Action { get; set; }

        /// <summary>
        /// What the permission applies to.<br/>
        /// A tagged union: `type` names the kind of resource and determines which<br/>
        /// identifier fields are present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.ResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Resource Resource { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For RBAC Role Permissions, this is always `"rbac_role_permission"`.<br/>
        /// Default Value: rbac_role_permission
        /// </summary>
        /// <default>"rbac_role_permission"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_role_permission";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacRolePermission" /> class.
        /// </summary>
        /// <param name="action">
        /// Action the permission grants on the resource.<br/>
        /// The vocabulary follows the resource: an `organization` grant carries a<br/>
        /// product-feature entitlement (for example `chat`), an admin-panel<br/>
        /// permission entitlement (`permission_*`), or a blanket capability-access<br/>
        /// mode — `capability_access_all` grants every product-feature entitlement,<br/>
        /// and `capability_access_all_ga` grants the generally-available subset as<br/>
        /// it stands at permission-check time; neither mode grants model-access<br/>
        /// entitlements. A consumer enumerating a role's per-feature grants should<br/>
        /// treat a blanket row as granting every product-feature entitlement it<br/>
        /// covers, or it will under-report the role's effective access. A `connector_tool` grant carries<br/>
        /// a tool-access action (`use` or `always_allow`); a `connector_scope` grant<br/>
        /// carries the scope action `grant` (the role may receive the named OAuth<br/>
        /// scope when tokens are minted for the connector); `connector` and<br/>
        /// `all_connectors` grants carry a tool-access action, the scope action, or<br/>
        /// an authentication-method action (`interactive` or `managed`).
        /// </param>
        /// <param name="resource">
        /// What the permission applies to.<br/>
        /// A tagged union: `type` names the kind of resource and determines which<br/>
        /// identifier fields are present.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For RBAC Role Permissions, this is always `"rbac_role_permission"`.<br/>
        /// Default Value: rbac_role_permission
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacRolePermission(
            string action,
            global::Anthropic.Resource resource,
            string type = "rbac_role_permission")
        {
            this.Action = action ?? throw new global::System.ArgumentNullException(nameof(action));
            this.Resource = resource;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacRolePermission" /> class.
        /// </summary>
        public BetaRbacRolePermission()
        {
        }

    }
}