
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization has reached the spend limit of its contract.
    /// </summary>
    public sealed partial class ContractSpendLimitReachedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"contract_spend_limit_reached"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "contract_spend_limit_reached";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractSpendLimitReachedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContractSpendLimitReachedErrorDetails(
            string errorCode = "contract_spend_limit_reached")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContractSpendLimitReachedErrorDetails" /> class.
        /// </summary>
        public ContractSpendLimitReachedErrorDetails()
        {
        }

    }
}