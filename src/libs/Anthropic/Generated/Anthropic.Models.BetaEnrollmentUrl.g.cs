
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"type":"enrollment_url","url":"https://platform.claude.com/user-profiles/enrollment/M3J0bGJxZ2ppMnptbnB1","expires_at":"2026-03-15T10:15:00Z"}
    /// </summary>
    public sealed partial class BetaEnrollmentUrl
    {
        /// <summary>
        /// Enrollment URL to send to the end user. Valid until `expires_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// When this enrollment URL expires, in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Object type. Always `enrollment_url`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaEnrollmentUrlTypeJsonConverter))]
        public global::Anthropic.BetaEnrollmentUrlType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnrollmentUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// Enrollment URL to send to the end user. Valid until `expires_at`.
        /// </param>
        /// <param name="expiresAt">
        /// When this enrollment URL expires, in RFC 3339 format.
        /// </param>
        /// <param name="type">
        /// Object type. Always `enrollment_url`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEnrollmentUrl(
            string url,
            global::System.DateTime expiresAt,
            global::Anthropic.BetaEnrollmentUrlType type)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnrollmentUrl" /> class.
        /// </summary>
        public BetaEnrollmentUrl()
        {
        }
    }
}