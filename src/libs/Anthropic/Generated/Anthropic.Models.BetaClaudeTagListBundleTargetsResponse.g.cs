
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaClaudeTagListBundleTargetsResponse
    {
        /// <summary>
        /// Bundle Targets on this page, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundleTarget> Data { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaClaudeTagListBundleTargetsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Bundle Targets on this page, newest first.
        /// </param>
        /// <param name="nextPage">
        /// Cursor for the next page. Null on the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagListBundleTargetsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaClaudeTagBundleTarget> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagListBundleTargetsResponse" /> class.
        /// </summary>
        public BetaClaudeTagListBundleTargetsResponse()
        {
        }

    }
}