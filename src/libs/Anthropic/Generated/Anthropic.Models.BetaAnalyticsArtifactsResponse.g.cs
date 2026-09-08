
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response for GET /v1/organizations/analytics/artifacts.<br/>
    /// `next_page` is null on ungrouped queries — the artifact-type cube is<br/>
    /// finite and returned in full. Grouped queries (`group_by[]` on `product` /<br/>
    /// `user_id` / `rbac_group_id`) multiply the cube and paginate like the other<br/>
    /// analytics list endpoints.
    /// </summary>
    public sealed partial class BetaAnalyticsArtifactsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity> Data { get; set; }

        /// <summary>
        /// Cursor for the next page of a grouped query; always null for the ungrouped artifact-type cube, which is returned in full.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsArtifactsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextPage">
        /// Cursor for the next page of a grouped query; always null for the ungrouped artifact-type cube, which is returned in full.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsArtifactsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsArtifactActivity> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsArtifactsResponse" /> class.
        /// </summary>
        public BetaAnalyticsArtifactsResponse()
        {
        }

    }
}