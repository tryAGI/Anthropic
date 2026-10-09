
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The file's `expires_at` has passed, so its content is no longer available.
    /// </summary>
    public sealed partial class BetaFileExpiredErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"file_expired"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "file_expired";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileExpiredErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFileExpiredErrorDetails(
            string errorCode = "file_expired")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileExpiredErrorDetails" /> class.
        /// </summary>
        public BetaFileExpiredErrorDetails()
        {
        }

    }
}