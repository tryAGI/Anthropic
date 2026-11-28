
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The RBAC Group order already has the most groups allowed. Delete another group's settings first.
    /// </summary>
    public sealed partial class BetaRbacGroupOrderLimitExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"rbac_group_order_limit_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "rbac_group_order_limit_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupOrderLimitExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacGroupOrderLimitExceededErrorDetails(
            string errorCode = "rbac_group_order_limit_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacGroupOrderLimitExceededErrorDetails" /> class.
        /// </summary>
        public BetaRbacGroupOrderLimitExceededErrorDetails()
        {
        }

    }
}