
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The workspace's customer-managed encryption key is disabled or revoked. Re-enable the key, then retry.
    /// </summary>
    public sealed partial class BetaCmekKeyDisabledErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cmek_key_disabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cmek_key_disabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekKeyDisabledErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekKeyDisabledErrorDetails(
            string errorCode = "cmek_key_disabled")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekKeyDisabledErrorDetails" /> class.
        /// </summary>
        public BetaCmekKeyDisabledErrorDetails()
        {
        }

    }
}