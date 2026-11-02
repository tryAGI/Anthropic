
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization's compliance configuration does not let Claude Tag store anything new.
    /// </summary>
    public sealed partial class BetaClaudeTagComplianceConfigurationRestrictedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"compliance_configuration_restricted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "compliance_configuration_restricted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagComplianceConfigurationRestrictedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagComplianceConfigurationRestrictedErrorDetails(
            string errorCode = "compliance_configuration_restricted")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagComplianceConfigurationRestrictedErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagComplianceConfigurationRestrictedErrorDetails()
        {
        }

    }
}