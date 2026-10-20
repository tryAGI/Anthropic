
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The workspace's customer-managed encryption key could not be reached. Retry the request; if this continues, check that the key is available in your key management service, or contact Anthropic support.
    /// </summary>
    public sealed partial class BetaCmekKeyUnreachableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cmek_key_unreachable"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cmek_key_unreachable";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekKeyUnreachableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekKeyUnreachableErrorDetails(
            string errorCode = "cmek_key_unreachable")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekKeyUnreachableErrorDetails" /> class.
        /// </summary>
        public BetaCmekKeyUnreachableErrorDetails()
        {
        }

    }
}