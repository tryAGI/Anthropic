
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Storage is `active` or `draining`, so this delete didn't erase it. The message says what to do next. On `draining` storage this delete may have started a removal that can't be undone: get the storage and read `status.removal_started`.
    /// </summary>
    public sealed partial class BetaExternalStorageInUseErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_storage_in_use"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_storage_in_use";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageInUseErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageInUseErrorDetails(
            string errorCode = "external_storage_in_use")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageInUseErrorDetails" /> class.
        /// </summary>
        public BetaExternalStorageInUseErrorDetails()
        {
        }

    }
}