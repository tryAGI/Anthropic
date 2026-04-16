
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"data":[{"id":"uprof_011CZkZCu8hGbp5mYRQgUmz9","type":"user_profile","external_id":"user_12345","trust_grants":{"cyber":{"status":"active"}},"metadata":{},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaListUserProfilesResponse
    {
        /// <summary>
        /// User profiles on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile> Data { get; set; }

        /// <summary>
        /// Cursor for the next page, or `null` when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListUserProfilesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// User profiles on this page.
        /// </param>
        /// <param name="nextPage">
        /// Cursor for the next page, or `null` when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListUserProfilesResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaUserProfile> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListUserProfilesResponse" /> class.
        /// </summary>
        public BetaListUserProfilesResponse()
        {
        }
    }
}