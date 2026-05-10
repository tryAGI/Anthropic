
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response payload for [List memories](/en/api/beta/memory_stores/memories/list).
    /// </summary>
    public sealed partial class BetaManagedAgentsListMemoriesResult
    {
        /// <summary>
        /// One page of results. Each item is either a `memory` object or, when `depth` was set, a `memory_prefix` rollup marker. Items appear in the requested `order_by`/`order`.
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
        /// One page of results. Each item is either a `memory` object or, when `depth` was set, a `memory_prefix` rollup marker. Items appear in the requested `order_by`/`order`.
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