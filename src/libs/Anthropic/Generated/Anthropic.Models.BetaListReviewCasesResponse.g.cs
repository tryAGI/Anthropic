
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A page of review cases.
    /// </summary>
    public sealed partial class BetaListReviewCasesResponse
    {
        /// <summary>
        /// The cases on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewCase> Data { get; set; }

        /// <summary>
        /// Cursor for the next page. Null on the last page. A page can be short or empty while this is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListReviewCasesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The cases on this page.
        /// </param>
        /// <param name="nextPage">
        /// Cursor for the next page. Null on the last page. A page can be short or empty while this is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListReviewCasesResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewCase> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListReviewCasesResponse" /> class.
        /// </summary>
        public BetaListReviewCasesResponse()
        {
        }

    }
}