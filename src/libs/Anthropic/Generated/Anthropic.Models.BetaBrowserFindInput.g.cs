
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Find elements matching a natural-language description (e.g. "search bar", "add to<br/>
    /// cart button") and return up to 20 matches with element references.
    /// </summary>
    public sealed partial class BetaBrowserFindInput
    {
        /// <summary>
        /// Natural-language description of the element(s) to find.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserFindInput" /> class.
        /// </summary>
        /// <param name="query">
        /// Natural-language description of the element(s) to find.
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserFindInput(
            string query,
            string? tabId)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.TabId = tabId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserFindInput" /> class.
        /// </summary>
        public BetaBrowserFindInput()
        {
        }

    }
}