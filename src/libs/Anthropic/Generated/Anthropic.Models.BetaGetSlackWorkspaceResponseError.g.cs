
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGetSlackWorkspaceResponseError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"permission_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "permission_error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaClaudeTagApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaClaudeTagComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails>))]
        public global::Anthropic.AnyOf<global::Anthropic.BetaClaudeTagApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaClaudeTagComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetSlackWorkspaceResponseError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGetSlackWorkspaceResponseError(
            string message,
            global::Anthropic.AnyOf<global::Anthropic.BetaClaudeTagApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaClaudeTagComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaClaudeTagOrganizationLevelScopedApiKeyRequiredErrorDetails>? details,
            string type = "permission_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetSlackWorkspaceResponseError" /> class.
        /// </summary>
        public BetaGetSlackWorkspaceResponseError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaGetSlackWorkspaceResponseError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaGetSlackWorkspaceResponseError FromMessage(string message)
        {
            return new BetaGetSlackWorkspaceResponseError
            {
                Message = message,
            };
        }

    }
}