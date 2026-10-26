
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFlatUsageItem
    {
        /// <summary>
        /// End of the period this row covers (exclusive), as an RFC 3339 UTC timestamp: the end of the row's time bucket when a time-bucket width is set; otherwise the requested `ending_at` (or, when omitted, the earlier of now and `starting_at` plus 31 days) rounded down to the hour, because without a time bucket the report covers whole hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// The dimension values this row's usage is broken out by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsFlatGroup Group { get; set; }

        /// <summary>
        /// Start of the period this row covers (inclusive), as an RFC 3339 UTC timestamp: the start of the row's time bucket when a time-bucket width is set, otherwise the requested `starting_at` rounded down to the hour.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartingAt { get; set; }

        /// <summary>
        /// Token usage for this row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsFlatUsageMetrics Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatUsageItem" /> class.
        /// </summary>
        /// <param name="endingAt">
        /// End of the period this row covers (exclusive), as an RFC 3339 UTC timestamp: the end of the row's time bucket when a time-bucket width is set; otherwise the requested `ending_at` (or, when omitted, the earlier of now and `starting_at` plus 31 days) rounded down to the hour, because without a time bucket the report covers whole hours.
        /// </param>
        /// <param name="group">
        /// The dimension values this row's usage is broken out by.
        /// </param>
        /// <param name="startingAt">
        /// Start of the period this row covers (inclusive), as an RFC 3339 UTC timestamp: the start of the row's time bucket when a time-bucket width is set, otherwise the requested `starting_at` rounded down to the hour.
        /// </param>
        /// <param name="usage">
        /// Token usage for this row.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFlatUsageItem(
            global::System.DateTime endingAt,
            global::Anthropic.BetaAnalyticsFlatGroup group,
            global::System.DateTime startingAt,
            global::Anthropic.BetaAnalyticsFlatUsageMetrics usage)
        {
            this.EndingAt = endingAt;
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.StartingAt = startingAt;
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatUsageItem" /> class.
        /// </summary>
        public BetaAnalyticsFlatUsageItem()
        {
        }

    }
}