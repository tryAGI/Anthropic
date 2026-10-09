
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has disabled the organization for trust and safety reasons. An organization disabled for any other reason, such as billing, does not get this code. `appeal_url`, when present, is where the organization can appeal.
    /// </summary>
    public sealed partial class OrganizationOnHoldErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appeal_url")]
        public string? AppealUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"organization_on_hold"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "organization_on_hold";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationOnHoldErrorDetails" /> class.
        /// </summary>
        /// <param name="appealUrl"></param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationOnHoldErrorDetails(
            string? appealUrl,
            string errorCode = "organization_on_hold")
        {
            this.AppealUrl = appealUrl;
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationOnHoldErrorDetails" /> class.
        /// </summary>
        public OrganizationOnHoldErrorDetails()
        {
        }

    }
}