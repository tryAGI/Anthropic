
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response for GET /v1/organizations/analytics/summaries.
    /// </summary>
    public sealed partial class BetaAnalyticsActivitySummaryResponse
    {
        /// <summary>
        /// One entry per day in the requested range, ascending by date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary> Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page, or null if no more results. Currently always null: the day series is returned in full.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Deprecated: use `data`, which carries the same entries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summaries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary> Summaries { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsActivitySummaryResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// One entry per day in the requested range, ascending by date.
        /// </param>
        /// <param name="summaries">
        /// Deprecated: use `data`, which carries the same entries.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page, or null if no more results. Currently always null: the day series is returned in full.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsActivitySummaryResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary> data,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary> summaries,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
            this.Summaries = summaries ?? throw new global::System.ArgumentNullException(nameof(summaries));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsActivitySummaryResponse" /> class.
        /// </summary>
        public BetaAnalyticsActivitySummaryResponse()
        {
        }

    }
}