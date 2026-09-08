
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response for GET /v1/organizations/analytics/summaries.
    /// </summary>
    public sealed partial class BetaAnalyticsActivitySummaryResponse
    {
        /// <summary>
        ///
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
        /// <param name="summaries"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsActivitySummaryResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsSingleDayActivitySummary> summaries)
        {
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