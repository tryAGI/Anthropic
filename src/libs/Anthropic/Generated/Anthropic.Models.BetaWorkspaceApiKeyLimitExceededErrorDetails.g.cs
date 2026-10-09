
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The workspace has reached its limit of active API keys.
    /// </summary>
    public sealed partial class BetaWorkspaceApiKeyLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"workspace_api_key_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "workspace_api_key_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceApiKeyLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaWorkspaceApiKeyLimitExceededErrorDetails(
            string errorCode = "workspace_api_key_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaWorkspaceApiKeyLimitExceededErrorDetails" /> class.
        /// </summary>
        public BetaWorkspaceApiKeyLimitExceededErrorDetails()
        {
        }

    }
}