
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The credential is not a scoped API key that is bound at the organization level.
    /// </summary>
    public sealed partial class BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"organization_level_scoped_api_key_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "organization_level_scoped_api_key_required";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails(
            string errorCode = "organization_level_scoped_api_key_required")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails()
        {
        }

    }
}