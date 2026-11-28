
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request can't use External Storage on this cloud provider. The error's message says why.
    /// </summary>
    public sealed partial class BetaProviderNotAllowedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"provider_not_allowed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "provider_not_allowed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProviderNotAllowedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaProviderNotAllowedErrorDetails(
            string errorCode = "provider_not_allowed")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaProviderNotAllowedErrorDetails" /> class.
        /// </summary>
        public BetaProviderNotAllowedErrorDetails()
        {
        }

    }
}