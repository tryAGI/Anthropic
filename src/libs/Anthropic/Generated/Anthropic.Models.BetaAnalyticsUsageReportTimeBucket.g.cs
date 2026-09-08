
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsUsageReportTimeBucket
    {
        /// <summary>
        /// End of the time bucket (exclusive) in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// Rows for this time bucket. Empty when the bucket has no data; otherwise a single combined row when `group_by[]` is omitted, or one row per group (subject to the per-bucket group cap described on the `group_by[]` parameter).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult> Results { get; set; }

        /// <summary>
        /// Start of the time bucket (inclusive) in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartingAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUsageReportTimeBucket" /> class.
        /// </summary>
        /// <param name="endingAt">
        /// End of the time bucket (exclusive) in RFC 3339 format.
        /// </param>
        /// <param name="results">
        /// Rows for this time bucket. Empty when the bucket has no data; otherwise a single combined row when `group_by[]` is omitted, or one row per group (subject to the per-bucket group cap described on the `group_by[]` parameter).
        /// </param>
        /// <param name="startingAt">
        /// Start of the time bucket (inclusive) in RFC 3339 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsUsageReportTimeBucket(
            global::System.DateTime endingAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsUsageBucketedResult> results,
            global::System.DateTime startingAt)
        {
            this.EndingAt = endingAt;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.StartingAt = startingAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsUsageReportTimeBucket" /> class.
        /// </summary>
        public BetaAnalyticsUsageReportTimeBucket()
        {
        }

    }
}