
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The organization's file storage quota is exhausted. Delete files to free up space, then retry the upload.
    /// </summary>
    public sealed partial class StorageQuotaExceededErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_quota_exceeded"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_quota_exceeded";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageQuotaExceededErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageQuotaExceededErrorDetails(
            string errorCode = "storage_quota_exceeded")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageQuotaExceededErrorDetails" /> class.
        /// </summary>
        public StorageQuotaExceededErrorDetails()
        {
        }

    }
}