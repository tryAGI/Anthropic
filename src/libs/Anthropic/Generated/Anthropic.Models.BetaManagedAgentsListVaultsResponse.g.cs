
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response containing a paginated list of vaults.<br/>
    /// Example: {"data":[{"type":"vault","id":"vlt_011CZkZDLs7fYzm1hXNPeRjv","display_name":"Example vault","metadata":{"environment":"production"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListVaultsResponse
    {
        /// <summary>
        /// List of vaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? Data { get; set; }

        /// <summary>
        /// Pagination token for the next page, or null if no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page")]
        public string? NextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListVaultsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of vaults.
        /// </param>
        /// <param name="nextPage">
        /// Pagination token for the next page, or null if no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListVaultsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsVault>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListVaultsResponse" /> class.
        /// </summary>
        public BetaManagedAgentsListVaultsResponse()
        {
        }
    }
}