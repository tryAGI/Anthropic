
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// One open browser tab reported in a `browser_state` block's `tabs`<br/>
    /// inventory.<br/>
    /// `tab_id` is the caller-assigned identifier for the tab; `title` and<br/>
    /// `url` describe the page the tab is currently showing and may be empty<br/>
    /// strings (a blank tab legitimately has both empty). `active` marks the<br/>
    /// tab that is active after this call; whenever `tabs` is non-empty,<br/>
    /// exactly one entry is marked.
    /// </summary>
    public sealed partial class BetaBrowserStateTabEntry
    {
        /// <summary>
        /// Whether this tab is the active tab after this call. Whenever `tabs` is non-empty, exactly one entry is marked `active: true`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// The caller-assigned identifier for this tab, unique within the inventory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TabId { get; set; }

        /// <summary>
        /// The title of the page the tab is showing. May be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// The URL of the page the tab is showing. May be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserStateTabEntry" /> class.
        /// </summary>
        /// <param name="tabId">
        /// The caller-assigned identifier for this tab, unique within the inventory.
        /// </param>
        /// <param name="title">
        /// The title of the page the tab is showing. May be empty.
        /// </param>
        /// <param name="url">
        /// The URL of the page the tab is showing. May be empty.
        /// </param>
        /// <param name="active">
        /// Whether this tab is the active tab after this call. Whenever `tabs` is non-empty, exactly one entry is marked `active: true`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserStateTabEntry(
            string tabId,
            string title,
            string url,
            bool? active)
        {
            this.Active = active;
            this.TabId = tabId ?? throw new global::System.ArgumentNullException(nameof(tabId));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserStateTabEntry" /> class.
        /// </summary>
        public BetaBrowserStateTabEntry()
        {
        }

    }
}