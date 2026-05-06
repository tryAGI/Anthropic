
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// An HTTP response captured during a credential validation probe.
    /// </summary>
    public sealed partial class BetaManagedAgentsRefreshHttpResponse
    {
        /// <summary>
        /// HTTP status code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Value of the `Content-Type` response header.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContentType { get; set; }

        /// <summary>
        /// Response body. May be truncated and has sensitive values scrubbed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Body { get; set; }

        /// <summary>
        /// Whether `body` was truncated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body_truncated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool BodyTruncated { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRefreshHttpResponse" /> class.
        /// </summary>
        /// <param name="statusCode">
        /// HTTP status code.
        /// </param>
        /// <param name="contentType">
        /// Value of the `Content-Type` response header.
        /// </param>
        /// <param name="body">
        /// Response body. May be truncated and has sensitive values scrubbed.
        /// </param>
        /// <param name="bodyTruncated">
        /// Whether `body` was truncated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsRefreshHttpResponse(
            int statusCode,
            string contentType,
            string body,
            bool bodyTruncated)
        {
            this.StatusCode = statusCode;
            this.ContentType = contentType ?? throw new global::System.ArgumentNullException(nameof(contentType));
            this.Body = body ?? throw new global::System.ArgumentNullException(nameof(body));
            this.BodyTruncated = bodyTruncated;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRefreshHttpResponse" /> class.
        /// </summary>
        public BetaManagedAgentsRefreshHttpResponse()
        {
        }
    }
}