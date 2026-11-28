
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Anthropic has not approved keeping data in a customer-owned storage bucket for the organization, project or user profile this request applies to, or has paused or withdrawn its approval. If you did not expect this, contact Anthropic.
    /// </summary>
    public sealed partial class BetaStorageNotApprovedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_not_approved"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_not_approved";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageNotApprovedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageNotApprovedErrorDetails(
            string errorCode = "storage_not_approved")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageNotApprovedErrorDetails" /> class.
        /// </summary>
        public BetaStorageNotApprovedErrorDetails()
        {
        }

    }
}