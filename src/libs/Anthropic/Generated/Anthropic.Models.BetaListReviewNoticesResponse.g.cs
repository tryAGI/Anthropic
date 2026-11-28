
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A page of review notices.
    /// </summary>
    public sealed partial class BetaListReviewNoticesResponse
    {
        /// <summary>
        /// The notices on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewNotice> Data { get; set; }

        /// <summary>
        /// Cursor for the next page. Null on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListReviewNoticesResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The notices on this page.
        /// </param>
        /// <param name="nextPage">
        /// Cursor for the next page. Null on the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListReviewNoticesResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaComplianceReviewNotice> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListReviewNoticesResponse" /> class.
        /// </summary>
        public BetaListReviewNoticesResponse()
        {
        }

    }
}