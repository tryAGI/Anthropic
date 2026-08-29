
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGetClaudeCodeUsageReportResponse
    {
        /// <summary>
        /// List of Claude Code usage records for the requested date.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem> Data { get; set; }

        /// <summary>
        /// True if there are more records available beyond the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor token for fetching the next page of results, or null if no more pages are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetClaudeCodeUsageReportResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of Claude Code usage records for the requested date.
        /// </param>
        /// <param name="hasMore">
        /// True if there are more records available beyond the current page.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor token for fetching the next page of results, or null if no more pages are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGetClaudeCodeUsageReportResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeCodeUsageReportItem> data,
            bool hasMore,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGetClaudeCodeUsageReportResponse" /> class.
        /// </summary>
        public BetaGetClaudeCodeUsageReportResponse()
        {
        }

    }
}