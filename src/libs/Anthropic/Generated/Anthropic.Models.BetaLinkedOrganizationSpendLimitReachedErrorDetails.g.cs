
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization linked to the request's user profile has reached a spend limit that it set, or lacks credit for the request. The response does not say which applies.
    /// </summary>
    public sealed partial class BetaLinkedOrganizationSpendLimitReachedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"linked_organization_spend_limit_reached"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "linked_organization_spend_limit_reached";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLinkedOrganizationSpendLimitReachedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaLinkedOrganizationSpendLimitReachedErrorDetails(
            string errorCode = "linked_organization_spend_limit_reached")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaLinkedOrganizationSpendLimitReachedErrorDetails" /> class.
        /// </summary>
        public BetaLinkedOrganizationSpendLimitReachedErrorDetails()
        {
        }

    }
}