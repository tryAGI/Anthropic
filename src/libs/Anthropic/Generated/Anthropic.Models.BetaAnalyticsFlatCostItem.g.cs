
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAnalyticsFlatCostItem
    {
        /// <summary>
        /// Cost for this row.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsFlatCostMetrics Cost { get; set; }

        /// <summary>
        /// End of the period this row covers (exclusive), as an RFC 3339 UTC timestamp: the end of the row's time bucket when a time-bucket width is set; otherwise the requested `ending_at` (or, when omitted, the earlier of now and `starting_at` plus 31 days) rounded down to the hour, because without a time bucket the report covers whole hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// The dimension values this row's cost is broken out by.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsFlatCostGroup Group { get; set; }

        /// <summary>
        /// Start of the period this row covers (inclusive), as an RFC 3339 UTC timestamp: the start of the row's time bucket when a time-bucket width is set, otherwise the requested `starting_at` rounded down to the hour.
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
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatCostItem" /> class.
        /// </summary>
        /// <param name="cost">
        /// Cost for this row.
        /// </param>
        /// <param name="endingAt">
        /// End of the period this row covers (exclusive), as an RFC 3339 UTC timestamp: the end of the row's time bucket when a time-bucket width is set; otherwise the requested `ending_at` (or, when omitted, the earlier of now and `starting_at` plus 31 days) rounded down to the hour, because without a time bucket the report covers whole hours.
        /// </param>
        /// <param name="group">
        /// The dimension values this row's cost is broken out by.
        /// </param>
        /// <param name="startingAt">
        /// Start of the period this row covers (inclusive), as an RFC 3339 UTC timestamp: the start of the row's time bucket when a time-bucket width is set, otherwise the requested `starting_at` rounded down to the hour.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsFlatCostItem(
            global::Anthropic.BetaAnalyticsFlatCostMetrics cost,
            global::System.DateTime endingAt,
            global::Anthropic.BetaAnalyticsFlatCostGroup group,
            global::System.DateTime startingAt)
        {
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.EndingAt = endingAt;
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.StartingAt = startingAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsFlatCostItem" /> class.
        /// </summary>
        public BetaAnalyticsFlatCostItem()
        {
        }

    }
}