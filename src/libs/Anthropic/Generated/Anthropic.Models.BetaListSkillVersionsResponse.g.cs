
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaListSkillVersionsResponse
    {
        /// <summary>
        /// List of skill versions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion> Data { get; set; }

        /// <summary>
        /// Indicates if there are more results in the requested page direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Token to provide in as `page` in the subsequent request to retrieve the next page of data.<br/>
        /// Example: page_MjAyNS0wNS0xNFQwMDowMDowMFo=
        /// </summary>
        /// <example>page_MjAyNS0wNS0xNFQwMDowMDowMFo=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListSkillVersionsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of skill versions.
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more results in the requested page direction.
        /// </param>
        /// <param name="nextPage">
        /// Token to provide in as `page` in the subsequent request to retrieve the next page of data.<br/>
        /// Example: page_MjAyNS0wNS0xNFQwMDowMDowMFo=
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListSkillVersionsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaSkillVersion> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage ?? throw new global::System.ArgumentNullException(nameof(nextPage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListSkillVersionsResponse" /> class.
        /// </summary>
        public BetaListSkillVersionsResponse()
        {
        }
    }
}