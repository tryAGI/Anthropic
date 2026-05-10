
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response payload for [List memory versions](/en/api/beta/memory_stores/memory_versions/list).
    /// </summary>
    public sealed partial class BetaManagedAgentsListMemoryVersionsResult
    {
        /// <summary>
        /// One page of `memory_version` objects, ordered by `created_at` descending (newest first), with `id` as tiebreak.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListMemoryVersionsResult" /> class.
        /// </summary>
        /// <param name="data">
        /// One page of `memory_version` objects, ordered by `created_at` descending (newest first), with `id` as tiebreak.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page (a `page_...` value), or `null` if there are no more results. Pass as `page` on the next request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListMemoryVersionsResult(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryVersion>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListMemoryVersionsResult" /> class.
        /// </summary>
        public BetaManagedAgentsListMemoryVersionsResult()
        {
        }

    }
}