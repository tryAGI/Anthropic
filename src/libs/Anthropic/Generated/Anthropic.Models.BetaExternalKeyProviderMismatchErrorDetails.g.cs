
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Key is held by a key management service that this endpoint does not take. The message names the field and the service it takes.
    /// </summary>
    public sealed partial class BetaExternalKeyProviderMismatchErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_key_provider_mismatch"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_key_provider_mismatch";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyProviderMismatchErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalKeyProviderMismatchErrorDetails(
            string errorCode = "external_key_provider_mismatch")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalKeyProviderMismatchErrorDetails" /> class.
        /// </summary>
        public BetaExternalKeyProviderMismatchErrorDetails()
        {
        }

    }
}