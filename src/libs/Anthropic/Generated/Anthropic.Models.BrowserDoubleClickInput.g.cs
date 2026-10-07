
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Double left-click at a viewport coordinate or on an element by reference.
    /// </summary>
    public sealed partial class BrowserDoubleClickInput
    {
        /// <summary>
        /// Optional modifier key chord to hold for the duration of this action (e.g. "shift", "ctrl+shift", "cmd+alt").<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modifiers")]
        public string? Modifiers { get; set; }

        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// Where to act: either a viewport coordinate or an element reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BrowserClickTargetJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BrowserClickTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserDoubleClickInput" /> class.
        /// </summary>
        /// <param name="target">
        /// Where to act: either a viewport coordinate or an element reference.
        /// </param>
        /// <param name="modifiers">
        /// Optional modifier key chord to hold for the duration of this action (e.g. "shift", "ctrl+shift", "cmd+alt").<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserDoubleClickInput(
            global::Anthropic.BrowserClickTarget target,
            string? modifiers,
            string? tabId)
        {
            this.Modifiers = modifiers;
            this.TabId = tabId;
            this.Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserDoubleClickInput" /> class.
        /// </summary>
        public BrowserDoubleClickInput()
        {
        }

    }
}