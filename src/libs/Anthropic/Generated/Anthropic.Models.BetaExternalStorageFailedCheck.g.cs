
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One check that an External Storage's verification failed.
    /// </summary>
    public sealed partial class BetaExternalStorageFailedCheck
    {
        /// <summary>
        /// Name of the check that failed, such as `versioning`, for code to branch on. New names may be added; `other` is a check this API does not name. The value is a name with no data of its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("check")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaExternalStorageFailedCheckCheckJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaExternalStorageFailedCheckCheck Check { get; set; }

        /// <summary>
        /// What failed and how to fix it, in plain words.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The part of your access grant that the check is about, such as `ingest`: on AWS, one of the IAM roles your setup created; on Google Cloud, the grant to one of Anthropic's service accounts. `null` when the check is not about one. New names may be added. The value is a name with no data of its own.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public global::Anthropic.BetaExternalStorageFailedCheckRole? Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageFailedCheck" /> class.
        /// </summary>
        /// <param name="check">
        /// Name of the check that failed, such as `versioning`, for code to branch on. New names may be added; `other` is a check this API does not name. The value is a name with no data of its own.
        /// </param>
        /// <param name="message">
        /// What failed and how to fix it, in plain words.
        /// </param>
        /// <param name="role">
        /// The part of your access grant that the check is about, such as `ingest`: on AWS, one of the IAM roles your setup created; on Google Cloud, the grant to one of Anthropic's service accounts. `null` when the check is not about one. New names may be added. The value is a name with no data of its own.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaExternalStorageFailedCheck(
            global::Anthropic.BetaExternalStorageFailedCheckCheck check,
            string message,
            global::Anthropic.BetaExternalStorageFailedCheckRole? role)
        {
            this.Check = check;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaExternalStorageFailedCheck" /> class.
        /// </summary>
        public BetaExternalStorageFailedCheck()
        {
        }

    }
}