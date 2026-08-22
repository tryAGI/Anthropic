
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// When this version was redacted, in RFC 3339 format, or `null` if it has not been redacted. When set, `content`, `path`, `content_size_bytes`, and `content_sha256` are all `null`. See [Redact a memory version](/en/api/beta/memory_stores/memory_versions/redact).
    /// </summary>
    public sealed partial class BetaManagedAgentsMemoryVersionRedactedAt
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}