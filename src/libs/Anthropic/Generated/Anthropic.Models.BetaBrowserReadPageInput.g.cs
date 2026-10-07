
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Return a structured accessibility tree of the page (or the subtree rooted at<br/>
    /// `ref`), with element references like [ref_7] that can be used as targets on later<br/>
    /// actions. Output is capped at 50,000 characters — narrow with `ref` or a smaller<br/>
    /// `depth` when exceeded.
    /// </summary>
    public sealed partial class BetaBrowserReadPageInput
    {
        /// <summary>
        /// Maximum tree depth. Default 15.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth")]
        public int? Depth { get; set; }

        /// <summary>
        /// Which elements to include. Omitted: every visible element. "interactive": interactive elements only. "all": additionally includes off-viewport elements.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::Anthropic.BetaBrowserReadPageFilter? Filter { get; set; }

        /// <summary>
        /// Element reference to read a subtree from. Omit to read from the page root.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        public string? Ref { get; set; }

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
        /// Initializes a new instance of the <see cref="BetaBrowserReadPageInput" /> class.
        /// </summary>
        /// <param name="depth">
        /// Maximum tree depth. Default 15.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="filter">
        /// Which elements to include. Omitted: every visible element. "interactive": interactive elements only. "all": additionally includes off-viewport elements.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ref">
        /// Element reference to read a subtree from. Omit to read from the page root.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserReadPageInput(
            int? depth,
            global::Anthropic.BetaBrowserReadPageFilter? filter,
            string? @ref,
            string? tabId)
        {
            this.Depth = depth;
            this.Filter = filter;
            this.Ref = @ref;
            this.TabId = tabId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserReadPageInput" /> class.
        /// </summary>
        public BetaBrowserReadPageInput()
        {
        }

    }
}