
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListSkillsResponse
    {
        /// <summary>
        /// List of skills.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Anthropic.Skill> Data { get; set; } = default!;

        /// <summary>
        /// Whether there are more results available.<br/>
        /// If `true`, there are additional results that can be fetched using the `next_page` token.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// Token for fetching the next page of results.<br/>
        /// If `null`, there are no more results available. Pass this value to the `page_token` parameter in the next request to get the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSkillsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of skills.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results available.<br/>
        /// If `true`, there are additional results that can be fetched using the `next_page` token.
        /// </param>
        /// <param name="nextPage">
        /// Token for fetching the next page of results.<br/>
        /// If `null`, there are no more results available. Pass this value to the `page_token` parameter in the next request to get the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListSkillsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.Skill> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSkillsResponse" /> class.
        /// </summary>
        public ListSkillsResponse()
        {
        }
    }
}