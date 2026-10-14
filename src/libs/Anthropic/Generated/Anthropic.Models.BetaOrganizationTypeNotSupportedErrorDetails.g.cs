
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The endpoint does not support the organization's type. Each endpoint's description says which organization types it supports.
    /// </summary>
    public sealed partial class BetaOrganizationTypeNotSupportedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"organization_type_not_supported"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "organization_type_not_supported";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTypeNotSupportedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationTypeNotSupportedErrorDetails(
            string errorCode = "organization_type_not_supported")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationTypeNotSupportedErrorDetails" /> class.
        /// </summary>
        public BetaOrganizationTypeNotSupportedErrorDetails()
        {
        }

    }
}