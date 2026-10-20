
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The API could not finish checking whether an RBAC Group in the request grants owner access (the check reached a fixed limit), so it made no change. Retrying the same request will not help. Make the change in the organization's admin settings in Claude.
    /// </summary>
    public sealed partial class RbacGroupOwnerAccessUnconfirmedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"rbac_group_owner_access_unconfirmed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "rbac_group_owner_access_unconfirmed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RbacGroupOwnerAccessUnconfirmedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RbacGroupOwnerAccessUnconfirmedErrorDetails(
            string errorCode = "rbac_group_owner_access_unconfirmed")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RbacGroupOwnerAccessUnconfirmedErrorDetails" /> class.
        /// </summary>
        public RbacGroupOwnerAccessUnconfirmedErrorDetails()
        {
        }

    }
}