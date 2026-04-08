
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Response containing a paginated list of credentials.<br/>
    /// Example: {"data":[{"type":"vault_credential","id":"vcrd_011CZkZEMt8gZan2iYOQfSkw","vault_id":"vlt_011CZkZDLs7fYzm1hXNPeRjv","display_name":"Example credential","metadata":{"environment":"production"},"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z","archived_at":null,"auth":{"type":"static_bearer","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}}],"next_page":"page_MjAyNS0wNS0xNFQwMDowMDowMFo="}
    /// </summary>
    public sealed partial class BetaManagedAgentsListCredentialsResponse
    {
        /// <summary>
        /// List of credentials.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? Data { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListCredentialsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of credentials.
        /// </param>
        /// <param name="nextPage">
        /// Pagination token for the next page, or null if no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsListCredentialsResponse(
            global::System.Collections.Generic.IList<global::Anthropic.BetaManagedAgentsCredential>? data,
            string? nextPage)
        {
            this.Data = data;
            this.NextPage = nextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsListCredentialsResponse" /> class.
        /// </summary>
        public BetaManagedAgentsListCredentialsResponse()
        {
        }
    }
}