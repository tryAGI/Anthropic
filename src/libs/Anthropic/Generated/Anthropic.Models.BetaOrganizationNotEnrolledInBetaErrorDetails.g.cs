
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The beta that the endpoint requires is not enabled for the organization. The message names the beta value.
    /// </summary>
    public sealed partial class BetaOrganizationNotEnrolledInBetaErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"organization_not_enrolled_in_beta"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "organization_not_enrolled_in_beta";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationNotEnrolledInBetaErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationNotEnrolledInBetaErrorDetails(
            string errorCode = "organization_not_enrolled_in_beta")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationNotEnrolledInBetaErrorDetails" /> class.
        /// </summary>
        public BetaOrganizationNotEnrolledInBetaErrorDetails()
        {
        }

    }
}