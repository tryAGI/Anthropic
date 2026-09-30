
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginTargetRbacGroup
    {
        /// <summary>
        /// The RBAC Group's ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rbac_group_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RbacGroupId { get; set; }

        /// <summary>
        /// An RBAC Group.<br/>
        /// Default Value: rbac_group
        /// </summary>
        /// <default>"rbac_group"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_group";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginTargetRbacGroup" /> class.
        /// </summary>
        /// <param name="rbacGroupId">
        /// The RBAC Group's ID.
        /// </param>
        /// <param name="type">
        /// An RBAC Group.<br/>
        /// Default Value: rbac_group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginTargetRbacGroup(
            string rbacGroupId,
            string type = "rbac_group")
        {
            this.RbacGroupId = rbacGroupId ?? throw new global::System.ArgumentNullException(nameof(rbacGroupId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginTargetRbacGroup" /> class.
        /// </summary>
        public BetaPluginTargetRbacGroup()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaPluginTargetRbacGroup"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaPluginTargetRbacGroup FromRbacGroupId(string rbacGroupId)
        {
            return new BetaPluginTargetRbacGroup
            {
                RbacGroupId = rbacGroupId,
            };
        }

    }
}