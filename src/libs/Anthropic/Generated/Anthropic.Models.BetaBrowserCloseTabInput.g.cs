
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Close the tab with the given tab_id.
    /// </summary>
    public sealed partial class BetaBrowserCloseTabInput
    {
        /// <summary>
        /// The tab to close.
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
        /// Initializes a new instance of the <see cref="BetaBrowserCloseTabInput" /> class.
        /// </summary>
        /// <param name="tabId">
        /// The tab to close.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserCloseTabInput(
            string tabId)
        {
            this.TabId = tabId ?? throw new global::System.ArgumentNullException(nameof(tabId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserCloseTabInput" /> class.
        /// </summary>
        public BetaBrowserCloseTabInput()
        {
        }

    }
}