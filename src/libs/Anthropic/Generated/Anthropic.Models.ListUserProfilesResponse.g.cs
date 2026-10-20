
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A page of user profiles, sorted by the request's `order_by` and `order`.<br/>
    /// Example: {"data":[{"id":"uprof_011CZkZCu8hGbp5mYRQgUmz9","type":"user_profile","name":"Example User","access_type":"application","programs":{"cyber":{"status":"active","tiers":{},"requirements":null},"efs":null},"external_user_details":{"reference_id":"user_12345","onboarded_at":"2024-11-02T08:15:00Z","account_status":"active","entity_type":"business","country":"US","name_hash":null,"email_hash":null},"metadata":{},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class ListUserProfilesResponse
    {
        /// <summary>
        /// User profiles on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.UserProfile> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="ListUserProfilesResponse" /> class.
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
        public ListUserProfilesResponse(
            global::System.Collections.Generic.IList<global::Anthropic.UserProfile> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListUserProfilesResponse" /> class.
        /// </summary>
        public ListUserProfilesResponse()
        {
        }

    }
}