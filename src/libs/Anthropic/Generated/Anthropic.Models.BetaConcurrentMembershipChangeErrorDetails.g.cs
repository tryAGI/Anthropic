
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Another change to the organization's members is in progress. Retry the request once it completes.
    /// </summary>
    public sealed partial class BetaConcurrentMembershipChangeErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"concurrent_membership_change"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "concurrent_membership_change";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConcurrentMembershipChangeErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaConcurrentMembershipChangeErrorDetails(
            string errorCode = "concurrent_membership_change")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaConcurrentMembershipChangeErrorDetails" /> class.
        /// </summary>
        public BetaConcurrentMembershipChangeErrorDetails()
        {
        }

    }
}