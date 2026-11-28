
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Another organization has data controls turned on for this Google Cloud project, or turned them off recently. The message says how long to wait.
    /// </summary>
    public sealed partial class BetaGcpProjectControlledByAnotherOrganizationErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"gcp_project_controlled_by_another_organization"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "gcp_project_controlled_by_another_organization";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpProjectControlledByAnotherOrganizationErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGcpProjectControlledByAnotherOrganizationErrorDetails(
            string errorCode = "gcp_project_controlled_by_another_organization")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGcpProjectControlledByAnotherOrganizationErrorDetails" /> class.
        /// </summary>
        public BetaGcpProjectControlledByAnotherOrganizationErrorDetails()
        {
        }

    }
}