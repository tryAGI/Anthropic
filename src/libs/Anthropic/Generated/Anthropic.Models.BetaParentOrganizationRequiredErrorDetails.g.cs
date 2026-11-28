
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The endpoint serves only organizations that belong to a parent organization, and this organization belongs to none.
    /// </summary>
    public sealed partial class BetaParentOrganizationRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"parent_organization_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "parent_organization_required";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaParentOrganizationRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaParentOrganizationRequiredErrorDetails(
            string errorCode = "parent_organization_required")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaParentOrganizationRequiredErrorDetails" /> class.
        /// </summary>
        public BetaParentOrganizationRequiredErrorDetails()
        {
        }

    }
}