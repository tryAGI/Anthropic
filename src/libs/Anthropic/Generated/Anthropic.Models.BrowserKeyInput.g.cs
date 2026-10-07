
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Press a key or key chord. Use "+" to combine modifiers with a key (e.g. "ctrl+a",<br/>
    /// "cmd+shift+p") and space to sequence presses (e.g. "Backspace Backspace Delete").<br/>
    /// Common names like "Return", "Tab", "Escape", "BackSpace" are supported.
    /// </summary>
    public sealed partial class BrowserKeyInput
    {
        /// <summary>
        /// Number of times to repeat. Default 1.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat")]
        public int? Repeat { get; set; }

        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// The key, chord, or space-separated sequence to press.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserKeyInput" /> class.
        /// </summary>
        /// <param name="text">
        /// The key, chord, or space-separated sequence to press.
        /// </param>
        /// <param name="repeat">
        /// Number of times to repeat. Default 1.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserKeyInput(
            string text,
            int? repeat,
            string? tabId)
        {
            this.Repeat = repeat;
            this.TabId = tabId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserKeyInput" /> class.
        /// </summary>
        public BrowserKeyInput()
        {
        }

    }
}