
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A precondition that applies an update only if the memory's current content has the hash in `content_sha256`.<br/>
    /// If the hashes differ, the request fails with HTTP status 409. Retrieve the memory and retry. If the memory already has exactly the requested `content` and `path`, the request succeeds even though the hashes differ.
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