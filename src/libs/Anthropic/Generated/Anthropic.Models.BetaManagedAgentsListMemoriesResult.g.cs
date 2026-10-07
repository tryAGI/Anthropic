
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response payload for [List memories](/en/api/beta/memory_stores/memories/list).<br/>
    /// Example: {"data":[{"type":"memory","id":"mem_011CZkZ9X2dpNyB6YbtxvB6e","memory_store_id":"memstore_01Wf3kQ8tZxB2mVr7HcJ4aNd","path":"/preferences/formatting.md","content":null,"content_size_bytes":28,"content_sha256":"ba7936d94c84d948a2232088f78228f175df6a8353b2d5bc9228eee5794a0024","memory_version_id":"memver_011CZkZBJq5dWxk9fVLNcPht","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListMemoriesResult
    {
        /// <summary>
        /// One page of results. Each item is either a `memory` object or, when `depth` was set, a `memory_prefix` rollup marker. Items are returned in a stable, server-defined order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page (a `page_...` value), or `null` if there are no more results. Pass as `page` on the next request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListMemoriesResult" /> class.
        /// </summary>
        /// <param name="data">
        /// One page of results. Each item is either a `memory` object or, when `depth` was set, a `memory_prefix` rollup marker. Items are returned in a stable, server-defined order.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page (a `page_...` value), or `null` if there are no more results. Pass as `page` on the next request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListMemoriesResult(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryListItem>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListMemoriesResult" /> class.
        /// </summary>
        public BetaManagedAgentsListMemoriesResult()
        {
        }

    }
}