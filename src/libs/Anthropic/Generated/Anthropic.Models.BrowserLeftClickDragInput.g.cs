
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Press at `from`, drag to `target`, release. Both must be coordinate targets.
    /// </summary>
    public sealed partial class BrowserLeftClickDragInput
    {
        /// <summary>
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BrowserCoordinateTarget From { get; set; }

        /// <summary>
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tab_id")]
        public string? TabId { get; set; }

        /// <summary>
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BrowserCoordinateTarget Target { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserLeftClickDragInput" /> class.
        /// </summary>
        /// <param name="from">
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </param>
        /// <param name="target">
        /// A point in the browser viewport, in viewport pixels (the same frame as a<br/>
        /// full-viewport screenshot).
        /// </param>
        /// <param name="tabId">
        /// Tab to act on. Defaults to the active tab when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserLeftClickDragInput(
            global::Anthropic.BrowserCoordinateTarget from,
            global::Anthropic.BrowserCoordinateTarget target,
            string? tabId)
        {
            this.From = from ?? throw new global::System.ArgumentNullException(nameof(from));
            this.TabId = tabId;
            this.Target = target ?? throw new global::System.ArgumentNullException(nameof(target));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserLeftClickDragInput" /> class.
        /// </summary>
        public BrowserLeftClickDragInput()
        {
        }

    }
}