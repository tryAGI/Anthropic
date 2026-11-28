
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The feature isn't offered to this organization. The error's `message` names the kind of organization or, when it names none, says to contact your Anthropic account team.
    /// </summary>
    public sealed partial class BetaOrganizationNotEligibleErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"organization_not_eligible"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "organization_not_eligible";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationNotEligibleErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationNotEligibleErrorDetails(
            string errorCode = "organization_not_eligible")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationNotEligibleErrorDetails" /> class.
        /// </summary>
        public BetaOrganizationNotEligibleErrorDetails()
        {
        }

    }
}