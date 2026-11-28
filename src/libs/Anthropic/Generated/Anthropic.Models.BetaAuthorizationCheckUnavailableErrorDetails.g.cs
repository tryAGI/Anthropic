
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One of the organization's approvals from Anthropic could not be read right now, so nothing was done. Retry after the `Retry-After` delay.
    /// </summary>
    public sealed partial class BetaAuthorizationCheckUnavailableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"authorization_check_unavailable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "authorization_check_unavailable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAuthorizationCheckUnavailableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAuthorizationCheckUnavailableErrorDetails(
            string errorCode = "authorization_check_unavailable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAuthorizationCheckUnavailableErrorDetails" /> class.
        /// </summary>
        public BetaAuthorizationCheckUnavailableErrorDetails()
        {
        }

    }
}