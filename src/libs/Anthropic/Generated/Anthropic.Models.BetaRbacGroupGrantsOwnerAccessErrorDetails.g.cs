
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A role attached to an RBAC Group in the request grants owner access, so this API does not add members to that group (directly or through an invite), remove its members, or delete it. Make the change in the organization's admin settings in Claude.
    /// </summary>
    public sealed partial class BetaRbacGroupGrantsOwnerAccessErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"rbac_group_grants_owner_access"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "rbac_group_grants_owner_access";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupGrantsOwnerAccessErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacGroupGrantsOwnerAccessErrorDetails(
            string errorCode = "rbac_group_grants_owner_access")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupGrantsOwnerAccessErrorDetails" /> class.
        /// </summary>
        public BetaRbacGroupGrantsOwnerAccessErrorDetails()
        {
        }

    }
}