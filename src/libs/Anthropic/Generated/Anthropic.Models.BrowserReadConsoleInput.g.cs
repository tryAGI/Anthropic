
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Return console output (log entries, errors, warnings) accumulated since the<br/>
    /// driver attached to the tab and since the last read, one line per entry. An empty<br/>
    /// result does not mean no traffic for a tab that predates attach.
    /// </summary>
    public sealed partial class BrowserReadConsoleInput
    {
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
        /// Initializes a new instance of the <see cref="BrowserReadConsoleInput" /> class.
        /// </summary>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserReadConsoleInput(
            string? tabId)
        {
            this.TabId = tabId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserReadConsoleInput" /> class.
        /// </summary>
        public BrowserReadConsoleInput()
        {
        }

    }
}