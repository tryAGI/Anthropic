
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// This storage is bound to a different user profile from storage the Workspace has attached, or from active or draining storage it once had for safeguards data. Detaching storage the Workspace uses only for transcripts clears this. Detaching safeguards storage doesn't, so use a new Workspace instead.
    /// </summary>
    public sealed partial class BetaStorageProfileStillRequiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_profile_still_required"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_profile_still_required";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageProfileStillRequiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageProfileStillRequiredErrorDetails(
            string errorCode = "storage_profile_still_required")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageProfileStillRequiredErrorDetails" /> class.
        /// </summary>
        public BetaStorageProfileStillRequiredErrorDetails()
        {
        }

    }
}