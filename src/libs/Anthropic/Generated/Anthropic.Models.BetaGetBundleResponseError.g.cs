
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGetBundleResponseError
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.AnyOfJsonConverter<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>))]
        public global::Anthropic.AnyOf<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetBundleResponseError" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGetBundleResponseError(
            string message,
            global::Anthropic.AnyOf<global::Anthropic.BetaApiKeyScopeMissingErrorDetails, global::Anthropic.BetaClaudeTagWritesNotEnabledErrorDetails, global::Anthropic.BetaComplianceConfigurationRestrictedErrorDetails, global::Anthropic.BetaOrganizationLevelScopedApiKeyRequiredErrorDetails>? details,
            string type = "permission_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetBundleResponseError" /> class.
        /// </summary>
        public BetaGetBundleResponseError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaGetBundleResponseError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaGetBundleResponseError FromMessage(string message)
        {
            return new BetaGetBundleResponseError
            {
                Message = message,
            };
        }

    }
}