
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has reached its limit of active API keys.
    /// </summary>
    public sealed partial class OrgApiKeyLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"org_api_key_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "org_api_key_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgApiKeyLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgApiKeyLimitExceededErrorDetails(
            string errorCode = "org_api_key_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgApiKeyLimitExceededErrorDetails" /> class.
        /// </summary>
        public OrgApiKeyLimitExceededErrorDetails()
        {
        }

    }
}