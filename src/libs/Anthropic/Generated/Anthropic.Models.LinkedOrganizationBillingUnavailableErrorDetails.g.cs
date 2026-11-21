
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic cannot currently bill the organization linked to the request's user profile, for a reason that lies with that organization's own account. The response does not say what the reason is.
    /// </summary>
    public sealed partial class LinkedOrganizationBillingUnavailableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"linked_organization_billing_unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "linked_organization_billing_unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedOrganizationBillingUnavailableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LinkedOrganizationBillingUnavailableErrorDetails(
            string errorCode = "linked_organization_billing_unavailable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedOrganizationBillingUnavailableErrorDetails" /> class.
        /// </summary>
        public LinkedOrganizationBillingUnavailableErrorDetails()
        {
        }

    }
}