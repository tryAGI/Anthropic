
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Optimistic-concurrency precondition: the update applies only if the memory's stored `content_sha256` equals the supplied value. On mismatch, the request returns `memory_precondition_failed_error` (HTTP 409); re-read the memory and retry against the fresh state. If the precondition fails but the stored state already exactly matches the requested `content` and `path`, the server returns 200 instead of 409.
    /// </summary>
    public sealed partial class BetaManagedAgentsContentSha256Precondition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsContentSha256PreconditionTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsContentSha256PreconditionType Type { get; set; }

        /// <summary>
        /// Expected `content_sha256` of the stored memory (64 lowercase hexadecimal characters). Typically the `content_sha256` returned by a prior read or list call. Because the server applies no content normalization, clients can also compute this locally as the SHA-256 of the UTF-8 content bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_sha256")]
        public string? ContentSha256 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsContentSha256Precondition" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="contentSha256">
        /// Expected `content_sha256` of the stored memory (64 lowercase hexadecimal characters). Typically the `content_sha256` returned by a prior read or list call. Because the server applies no content normalization, clients can also compute this locally as the SHA-256 of the UTF-8 content bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsContentSha256Precondition(
            global::Anthropic.BetaManagedAgentsContentSha256PreconditionType type,
            string? contentSha256)
        {
            this.Type = type;
            this.ContentSha256 = contentSha256;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsContentSha256Precondition" /> class.
        /// </summary>
        public BetaManagedAgentsContentSha256Precondition()
        {
        }
    }
}