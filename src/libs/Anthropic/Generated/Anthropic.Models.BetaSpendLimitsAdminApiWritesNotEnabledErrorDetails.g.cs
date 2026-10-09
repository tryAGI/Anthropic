
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization cannot list, retrieve, set or delete spend limits with an Admin API credential.
    /// </summary>
    public sealed partial class BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"spend_limits_admin_api_writes_not_enabled"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "spend_limits_admin_api_writes_not_enabled";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails(
            string errorCode = "spend_limits_admin_api_writes_not_enabled")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails" /> class.
        /// </summary>
        public BetaSpendLimitsAdminApiWritesNotEnabledErrorDetails()
        {
        }

    }
}