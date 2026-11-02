
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `settings.environment_id` names no Environment within the organization's reach.
    /// </summary>
    public sealed partial class BetaClaudeTagEnvironmentNotFoundErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"environment_not_found"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "environment_not_found";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagEnvironmentNotFoundErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagEnvironmentNotFoundErrorDetails(
            string errorCode = "environment_not_found")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagEnvironmentNotFoundErrorDetails" /> class.
        /// </summary>
        public BetaClaudeTagEnvironmentNotFoundErrorDetails()
        {
        }

    }
}