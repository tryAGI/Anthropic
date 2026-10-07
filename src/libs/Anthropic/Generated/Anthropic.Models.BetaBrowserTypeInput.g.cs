
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Type a literal string at the current focus.
    /// </summary>
    public sealed partial class BetaBrowserTypeInput
    {
        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// The text to type.
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
        /// Initializes a new instance of the <see cref="BetaBrowserTypeInput" /> class.
        /// </summary>
        /// <param name="text">
        /// The text to type.
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaBrowserTypeInput(
            string text,
            string? tabId)
        {
            this.TabId = tabId;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaBrowserTypeInput" /> class.
        /// </summary>
        public BetaBrowserTypeInput()
        {
        }

    }
}