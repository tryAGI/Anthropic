
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The caller's browser state after a browser toolset member call —<br/>
    /// the full inventory of open tabs, which tab is active, and any side<br/>
    /// effects (tabs opened, download state changes) the call produced.<br/>
    /// At most one per `tool_result`, only on a non-error result answering a<br/>
    /// browser toolset member `tool_use`. The server renders the<br/>
    /// model-visible text from it; the model never sees the raw fields.
    /// </summary>
    public sealed partial class RequestBrowserStateBlock
    {
        /// <summary>
        /// Create a cache control breakpoint at this content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_control")]
        public global::Anthropic.CacheControlVariant164? CacheControl { get; set; }

        /// <summary>
        /// Tabs opened and download state changes during this call. "Nothing to report" is expressed by omitting the field, never by an empty list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state_changes")]
        public global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? StateChanges { get; set; }

        /// <summary>
        /// All tabs open in the browser after this call — the full inventory, not a delta. May be empty. Whenever non-empty, exactly one entry carries `active: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tabs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry> Tabs { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"browser_state"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "browser_state";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBrowserStateBlock" /> class.
        /// </summary>
        /// <param name="tabs">
        /// All tabs open in the browser after this call — the full inventory, not a delta. May be empty. Whenever non-empty, exactly one entry carries `active: true`.
        /// </param>
        /// <param name="cacheControl">
        /// Create a cache control breakpoint at this content block.
        /// </param>
        /// <param name="stateChanges">
        /// Tabs opened and download state changes during this call. "Nothing to report" is expressed by omitting the field, never by an empty list.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RequestBrowserStateBlock(
            global::System.Collections.Generic.IList<global::Anthropic.BrowserStateTabEntry> tabs,
            global::Anthropic.CacheControlVariant164? cacheControl,
            global::System.Collections.Generic.IList<global::Anthropic.StateChangesVariant1Item2>? stateChanges,
            string type = "browser_state")
        {
            this.CacheControl = cacheControl;
            this.StateChanges = stateChanges;
            this.Tabs = tabs ?? throw new global::System.ArgumentNullException(nameof(tabs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBrowserStateBlock" /> class.
        /// </summary>
        public RequestBrowserStateBlock()
        {
        }

    }
}