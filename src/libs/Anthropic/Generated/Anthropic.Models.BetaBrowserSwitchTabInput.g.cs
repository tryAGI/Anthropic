
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Make the tab with the given tab_id the active tab — the tab that actions without<br/>
    /// a tab_id apply to.
    /// </summary>
    public sealed partial class BetaBrowserSwitchTabInput
    {
        /// <summary>
        /// The tab to switch to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TabId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserSwitchTabInput" /> class.
        /// </summary>
        /// <param name="tabId">
        /// The tab to switch to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserSwitchTabInput(
            string tabId)
        {
            this.TabId = tabId ?? throw new global::System.ArgumentNullException(nameof(tabId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserSwitchTabInput" /> class.
        /// </summary>
        public BetaBrowserSwitchTabInput()
        {
        }

    }
}