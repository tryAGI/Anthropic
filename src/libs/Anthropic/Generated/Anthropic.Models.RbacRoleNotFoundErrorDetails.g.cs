
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No RBAC Role with this ID was found.
    /// </summary>
    public sealed partial class RbacRoleNotFoundErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"rbac_role_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "rbac_role_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RbacRoleNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RbacRoleNotFoundErrorDetails(
            string errorCode = "rbac_role_not_found")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RbacRoleNotFoundErrorDetails" /> class.
        /// </summary>
        public RbacRoleNotFoundErrorDetails()
        {
        }

    }
}