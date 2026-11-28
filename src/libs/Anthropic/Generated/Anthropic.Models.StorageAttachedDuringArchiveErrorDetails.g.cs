
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The Workspace was archived, but External Storage was attached to it during the archive and is still attached. To detach it, archive the Workspace again as a caller with the `org:external-storage:use` permission.
    /// </summary>
    public sealed partial class StorageAttachedDuringArchiveErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_attached_during_archive"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_attached_during_archive";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAttachedDuringArchiveErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StorageAttachedDuringArchiveErrorDetails(
            string errorCode = "storage_attached_during_archive")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageAttachedDuringArchiveErrorDetails" /> class.
        /// </summary>
        public StorageAttachedDuringArchiveErrorDetails()
        {
        }

    }
}