
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response when listing work items with cursor-based pagination.
    /// </summary>
    public sealed partial class BetaSelfHostedWorkListResponse
    {
        /// <summary>
        /// List of work items
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaSelfHostedWork> Data { get; set; }

        /// <summary>
        /// Opaque cursor for fetching the next page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWorkListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of work items
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for fetching the next page of results
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSelfHostedWorkListResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaSelfHostedWork> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSelfHostedWorkListResponse" /> class.
        /// </summary>
        public BetaSelfHostedWorkListResponse()
        {
        }

    }
}