
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has not approved customer-managed encryption keys for the organization, project or user profile this request applies to, or has paused or withdrawn its approval. If you did not expect this, contact Anthropic.
    /// </summary>
    public sealed partial class BetaCmekNotApprovedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"cmek_not_approved"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "cmek_not_approved";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekNotApprovedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaCmekNotApprovedErrorDetails(
            string errorCode = "cmek_not_approved")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaCmekNotApprovedErrorDetails" /> class.
        /// </summary>
        public BetaCmekNotApprovedErrorDetails()
        {
        }

    }
}