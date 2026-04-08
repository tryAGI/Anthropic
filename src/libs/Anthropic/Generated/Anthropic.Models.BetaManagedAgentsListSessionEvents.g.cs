
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of events for a `session`.<br/>
    /// Example: {"data":[{"type":"user.message","id":"sevt_011CZkZGOp0iBcp4kaQSihUmy","content":[{"type":"text","text":"Where is my order #1234?"}],"processed_at":"2026-03-15T10:00:00Z"},{"type":"agent.message","id":"sevt_011CZkZHPq1jCdq5lbRTjiVnz","content":[{"type":"text","text":"Let me look up order #1234 for you."}],"processed_at":"2026-03-15T10:00:00Z"}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessionEvents
    {
        /// <summary>
        /// Events for the session, ordered by `created_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page. Null when no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionEvents" /> class.
        /// </summary>
        /// <param name="data">
        /// Events for the session, ordered by `created_at`.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListSessionEvents(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionEvents" /> class.
        /// </summary>
        public BetaManagedAgentsListSessionEvents()
        {
        }
    }
}