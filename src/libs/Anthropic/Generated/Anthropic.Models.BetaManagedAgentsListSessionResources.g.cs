
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Paginated list of resources attached to a session.<br/>
    /// Example: {"data":[{"type":"file","id":"sesrsc_011CZkZBJq5dWxk9fVLNcPht","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"},{"type":"github_repository","id":"sesrsc_011CZkZCKr6eXyl0gWMOdQiu","url":"https://github.com/example-org/example-repo","mount_path":"/workspace/example-repo","checkout":{"type":"branch","name":"main"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListSessionResources
    {
        /// <summary>
        /// Resources for the session, ordered by `created_at`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionResources" /> class.
        /// </summary>
        /// <param name="data">
        /// Resources for the session, ordered by `created_at`.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page. Null when no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListSessionResources(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsSessionResource> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListSessionResources" /> class.
        /// </summary>
        public BetaManagedAgentsListSessionResources()
        {
        }
    }
}