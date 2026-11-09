
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The request came from a Claude sandbox with restricted network access, which is not allowed to make this change. Send it from outside the sandbox, or from a sandbox with unrestricted network access.
    /// </summary>
    public sealed partial class BetaSandboxEgressRestrictedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"sandbox_egress_restricted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "sandbox_egress_restricted";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSandboxEgressRestrictedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSandboxEgressRestrictedErrorDetails(
            string errorCode = "sandbox_egress_restricted")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSandboxEgressRestrictedErrorDetails" /> class.
        /// </summary>
        public BetaSandboxEgressRestrictedErrorDetails()
        {
        }

    }
}