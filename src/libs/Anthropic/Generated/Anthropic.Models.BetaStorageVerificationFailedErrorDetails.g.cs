
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The External Storage failed verification, so the request changed nothing. `failed_checks` lists what to fix.
    /// </summary>
    public sealed partial class BetaStorageVerificationFailedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"storage_verification_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "storage_verification_failed";

        /// <summary>
        /// One entry for each check that failed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed_checks")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaExternalStorageFailedCheck> FailedChecks { get; set; }

        /// <summary>
        /// The request field at fault. Sent when the refused request is a Workspace's create or update.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string? Field { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageVerificationFailedErrorDetails" /> class.
        /// </summary>
        /// <param name="failedChecks">
        /// One entry for each check that failed.
        /// </param>
        /// <param name="field">
        /// The request field at fault. Sent when the refused request is a Workspace's create or update.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaStorageVerificationFailedErrorDetails(
            global::System.Collections.Generic.IList<global::Anthropic.BetaExternalStorageFailedCheck> failedChecks,
            string? field,
            string errorCode = "storage_verification_failed")
        {
            this.ErrorCode = errorCode;
            this.FailedChecks = failedChecks ?? throw new global::System.ArgumentNullException(nameof(failedChecks));
            this.Field = field;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaStorageVerificationFailedErrorDetails" /> class.
        /// </summary>
        public BetaStorageVerificationFailedErrorDetails()
        {
        }

    }
}