
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGetCostReportResponse
    {
        /// <summary>
        /// List of time buckets for this page, oldest first: one per `bucket_width` interval, including intervals with no costs (their `results` list is empty). A page holds at most `limit` buckets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket> Data { get; set; }

        /// <summary>
        /// Indicates if there are more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor for the next page, or `null` when `has_more` is false. Pass it as the `page` parameter in the next request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetCostReportResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of time buckets for this page, oldest first: one per `bucket_width` interval, including intervals with no costs (their `results` list is empty). A page holds at most `limit` buckets.
        /// </param>
        /// <param name="hasMore">
        /// Indicates if there are more results.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page, or `null` when `has_more` is false. Pass it as the `page` parameter in the next request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGetCostReportResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaCostReportTimeBucket> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetCostReportResponse" /> class.
        /// </summary>
        public BetaGetCostReportResponse()
        {
        }

    }
}