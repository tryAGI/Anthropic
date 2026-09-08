
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Office Agent activity metrics for a single user on a given day, broken out by Office product.
    /// </summary>
    public sealed partial class BetaAnalyticsOfficeMetrics
    {
        /// <summary>
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("excel")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsOfficeProductMetrics Excel { get; set; }

        /// <summary>
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outlook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsOfficeProductMetrics Outlook { get; set; }

        /// <summary>
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("powerpoint")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsOfficeProductMetrics Powerpoint { get; set; }

        /// <summary>
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("word")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaAnalyticsOfficeProductMetrics Word { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsOfficeMetrics" /> class.
        /// </summary>
        /// <param name="excel">
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </param>
        /// <param name="outlook">
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </param>
        /// <param name="powerpoint">
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </param>
        /// <param name="word">
        /// Office Agent activity metrics for a single user on a given day within one Office product.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsOfficeMetrics(
            global::Anthropic.BetaAnalyticsOfficeProductMetrics excel,
            global::Anthropic.BetaAnalyticsOfficeProductMetrics outlook,
            global::Anthropic.BetaAnalyticsOfficeProductMetrics powerpoint,
            global::Anthropic.BetaAnalyticsOfficeProductMetrics word)
        {
            this.Excel = excel ?? throw new global::System.ArgumentNullException(nameof(excel));
            this.Outlook = outlook ?? throw new global::System.ArgumentNullException(nameof(outlook));
            this.Powerpoint = powerpoint ?? throw new global::System.ArgumentNullException(nameof(powerpoint));
            this.Word = word ?? throw new global::System.ArgumentNullException(nameof(word));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsOfficeMetrics" /> class.
        /// </summary>
        public BetaAnalyticsOfficeMetrics()
        {
        }

    }
}