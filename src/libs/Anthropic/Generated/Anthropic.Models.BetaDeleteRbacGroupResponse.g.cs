
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaDeleteRbacGroupResponse
    {
        /// <summary>
        /// ID of the RBAC Group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Deleted object type.<br/>
        /// For RBAC Groups, this is always `"rbac_group_deleted"`.<br/>
        /// Default Value: rbac_group_deleted
        /// </summary>
        /// <default>"rbac_group_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rbac_group_deleted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteRbacGroupResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the RBAC Group.
        /// </param>
        /// <param name="type">
        /// Deleted object type.<br/>
        /// For RBAC Groups, this is always `"rbac_group_deleted"`.<br/>
        /// Default Value: rbac_group_deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeleteRbacGroupResponse(
            string id,
            string type = "rbac_group_deleted")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeleteRbacGroupResponse" /> class.
        /// </summary>
        public BetaDeleteRbacGroupResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeleteRbacGroupResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeleteRbacGroupResponse FromId(string id)
        {
            return new BetaDeleteRbacGroupResponse
            {
                Id = id,
            };
        }

    }
}