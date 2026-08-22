
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tab this call's execution opened that remains open at its end —<br/>
    /// the creation delta of the `tabs` inventory, not an event log.<br/>
    /// Carries only the `tab_id`; the tab's `title` and `url` live on its<br/>
    /// `tabs` entry, which must include the same `tab_id`. A tab opened<br/>
    /// during a failed call gets no deferred `tab_opened`; it simply appears<br/>
    /// in the next result's `tabs` inventory.
    /// </summary>
    public sealed partial class BrowserStateChangeTabOpened
    {
        /// <summary>
        /// The `tab_id` of the opened tab, present in `tabs`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TabId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"tab_opened"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "tab_opened";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserStateChangeTabOpened" /> class.
        /// </summary>
        /// <param name="tabId">
        /// The `tab_id` of the opened tab, present in `tabs`.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserStateChangeTabOpened(
            string tabId,
            string type = "tab_opened")
        {
            this.TabId = tabId ?? throw new global::System.ArgumentNullException(nameof(tabId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserStateChangeTabOpened" /> class.
        /// </summary>
        public BrowserStateChangeTabOpened()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BrowserStateChangeTabOpened"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BrowserStateChangeTabOpened FromTabId(string tabId)
        {
            return new BrowserStateChangeTabOpened
            {
                TabId = tabId,
            };
        }

    }
}