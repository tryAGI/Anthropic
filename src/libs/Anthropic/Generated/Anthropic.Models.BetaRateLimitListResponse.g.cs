
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRateLimitListResponse
    {
        /// <summary>
        /// Rate-limit entries for the organization, one per group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit> Data { get; set; }

        /// <summary>
        /// Opaque cursor for the next page of results, or `null` when no entries remain beyond this response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRateLimitListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Rate-limit entries for the organization, one per group.
        /// </param>
        /// <param name="nextPage">
        /// Opaque cursor for the next page of results, or `null` when no entries remain beyond this response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRateLimitListResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaRateLimit> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRateLimitListResponse" /> class.
        /// </summary>
        public BetaRateLimitListResponse()
        {
        }

    }
}