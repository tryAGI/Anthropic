
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response when listing environments.<br/>
    /// This response model uses opaque cursor-based pagination. Use the `page`<br/>
    /// query parameter with the value from `next_page` to fetch the next page.
    /// </summary>
    public sealed partial class BetaEnvironmentListResponse
    {
        /// <summary>
        /// List of environments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment> Data { get; set; }

        /// <summary>
        /// Token for fetching the next page of results. If `null`, there are no more results available. Pass this value to the `page` parameter in the next request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of environments.
        /// </param>
        /// <param name="nextPage">
        /// Token for fetching the next page of results. If `null`, there are no more results available. Pass this value to the `page` parameter in the next request.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEnvironmentListResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaEnvironment> data,
            string? nextPage)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentListResponse" /> class.
        /// </summary>
        public BetaEnvironmentListResponse()
        {
        }
    }
}