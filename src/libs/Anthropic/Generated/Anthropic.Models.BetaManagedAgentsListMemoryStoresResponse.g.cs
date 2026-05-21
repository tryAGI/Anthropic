
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A page of `memory_store` results, ordered by `created_at` descending (newest first).
    /// </summary>
    public sealed partial class BetaManagedAgentsListMemoryStoresResponse
    {
        /// <summary>
        /// Memory stores on this page, newest first. Empty when there are no stores matching the filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page (a `page_...` value). Pass as `page` on the next request. `null` when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListMemoryStoresResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Memory stores on this page, newest first. Empty when there are no stores matching the filters.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page (a `page_...` value). Pass as `page` on the next request. `null` when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListMemoryStoresResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsMemoryStore>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListMemoryStoresResponse" /> class.
        /// </summary>
        public BetaManagedAgentsListMemoryStoresResponse()
        {
        }

    }
}