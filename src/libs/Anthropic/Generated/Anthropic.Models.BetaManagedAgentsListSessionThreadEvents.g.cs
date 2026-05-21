
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of events for a single thread within a `session`.
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessionThreadEvents
    {
        /// <summary>
        /// Events for the thread, ordered by `created_at`.
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionThreadEvents" /> class.
        /// </summary>
        /// <param name="data">
        /// Events for the thread, ordered by `created_at`.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListSessionThreadEvents(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionEvent>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionThreadEvents" /> class.
        /// </summary>
        public BetaManagedAgentsListSessionThreadEvents()
        {
        }

    }
}