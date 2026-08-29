
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaMessagesUsageReportTimeBucket
    {
        /// <summary>
        /// Start of the time bucket (inclusive) in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("starting_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartingAt { get; set; }

        /// <summary>
        /// End of the time bucket (exclusive) in RFC 3339 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ending_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndingAt { get; set; }

        /// <summary>
        /// List of usage items for this time bucket.  There may be multiple items if one or more `group_by[]` parameters are specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesUsageReportTimeBucket" /> class.
        /// </summary>
        /// <param name="startingAt">
        /// Start of the time bucket (inclusive) in RFC 3339 format.
        /// </param>
        /// <param name="endingAt">
        /// End of the time bucket (exclusive) in RFC 3339 format.
        /// </param>
        /// <param name="results">
        /// List of usage items for this time bucket.  There may be multiple items if one or more `group_by[]` parameters are specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessagesUsageReportTimeBucket(
            global::System.DateTime startingAt,
            global::System.DateTime endingAt,
            global::System.Collections.Generic.IList<global::Anthropic.BetaMessagesUsageReportItem> results)
        {
            this.StartingAt = startingAt;
            this.EndingAt = endingAt;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessagesUsageReportTimeBucket" /> class.
        /// </summary>
        public BetaMessagesUsageReportTimeBucket()
        {
        }

    }
}