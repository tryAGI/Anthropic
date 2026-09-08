
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response for GET /v1/organizations/analytics/plugins.
    /// </summary>
    public sealed partial class BetaAnalyticsPluginsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity> Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page, or null if no more results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginsResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page, or null if no more results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAnalyticsPluginsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaAnalyticsPluginActivity> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAnalyticsPluginsResponse" /> class.
        /// </summary>
        public BetaAnalyticsPluginsResponse()
        {
        }

    }
}