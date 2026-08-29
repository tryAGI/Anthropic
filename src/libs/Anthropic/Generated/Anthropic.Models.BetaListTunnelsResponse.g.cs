
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A paginated list of tunnels.
    /// </summary>
    public sealed partial class BetaListTunnelsResponse
    {
        /// <summary>
        /// List of tunnels, ordered by created_at descending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel> Data { get; set; }

        /// <summary>
        /// Pagination cursor for the next page, or null if no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListTunnelsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of tunnels, ordered by created_at descending.
        /// </param>
        /// <param name="nextPage">
        /// Pagination cursor for the next page, or null if no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaListTunnelsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaTunnel> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaListTunnelsResponse" /> class.
        /// </summary>
        public BetaListTunnelsResponse()
        {
        }

    }
}