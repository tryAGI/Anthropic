
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The key management service's network access controls blocked the request to the workspace's customer-managed encryption key. The key itself may be healthy.
    /// </summary>
    public sealed partial class BetaCmekKeyNetworkBlockedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cmek_key_network_blocked"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cmek_key_network_blocked";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekKeyNetworkBlockedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekKeyNetworkBlockedErrorDetails(
            string errorCode = "cmek_key_network_blocked")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekKeyNetworkBlockedErrorDetails" /> class.
        /// </summary>
        public BetaCmekKeyNetworkBlockedErrorDetails()
        {
        }

    }
}