
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of sessions.<br/>
    /// Example: {"data":[],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo=","prev_page":"page_MjAyNS0wNS0xM1QwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessions
    {
        /// <summary>
        /// List of sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page. Null when no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Opaque cursor for the previous page. Null when on the first page. Pass as the `page` parameter to navigate backward.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_page")]
        public string? PrevPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessions" /> class.
        /// </summary>
        /// <param name="data">
        /// List of sessions.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
        /// <param name="prevPage">
        /// Opaque cursor for the previous page. Null when on the first page. Pass as the `page` parameter to navigate backward.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListSessions(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSession>? data,
            string? nextPage,
            string? prevPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
            this.PrevPage = prevPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessions" /> class.
        /// </summary>
        public BetaManagedAgentsListSessions()
        {
        }

    }
}