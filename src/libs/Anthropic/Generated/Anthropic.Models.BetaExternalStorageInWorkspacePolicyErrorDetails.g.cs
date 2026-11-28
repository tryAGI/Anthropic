
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Storage can't be deleted while an Enterprise Frontier Safeguards workspace policy lists it as allowed storage.
    /// </summary>
    public sealed partial class BetaExternalStorageInWorkspacePolicyErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"external_storage_in_workspace_policy"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "external_storage_in_workspace_policy";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageInWorkspacePolicyErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageInWorkspacePolicyErrorDetails(
            string errorCode = "external_storage_in_workspace_policy")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageInWorkspacePolicyErrorDetails" /> class.
        /// </summary>
        public BetaExternalStorageInWorkspacePolicyErrorDetails()
        {
        }

    }
}