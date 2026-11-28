
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// External Storage isn't available for this Workspace, so only `internal` storage is accepted. The error's `message` says why.
    /// </summary>
    public sealed partial class BetaExternalStorageNotAvailableErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_storage_not_available"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_storage_not_available";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageNotAvailableErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageNotAvailableErrorDetails(
            string errorCode = "external_storage_not_available")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageNotAvailableErrorDetails" /> class.
        /// </summary>
        public BetaExternalStorageNotAvailableErrorDetails()
        {
        }

    }
}